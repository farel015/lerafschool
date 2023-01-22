using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LerafSchoolManage.UserControls
{
    public partial class UC_Students : UserControl
    {
        Functions Con;
        public UC_Students()
        {
            InitializeComponent();
            Con = new Functions();
            ShowStudent();
            GetJurusan();
        }

        private void ShowStudent()
        {
            string Query = " select * from StudentTbl ";
            MuridList.DataSource = Con.GetData(Query);

        }

        private void GetJurusan()
        {
            string Query = "select * from JurusanTbl";
            StJurCb.DisplayMember = Con.GetData(Query).Columns["JurNama"].ToString();
            StJurCb.ValueMember = Con.GetData(Query).Columns["JurId"].ToString();
            StJurCb.DataSource = Con.GetData(Query);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        private void Clear()
        {
            StNamaTb.Text = "";
            StPhoneTb.Text = "";
            StJkCb.SelectedIndex = -1;
        }
        private void TambahBtn_Click(object sender, EventArgs e)
        {
            if (StNamaTb.Text == "" || StJkCb.SelectedIndex == -1 || StPhoneTb.Text == "" || StJurCb.SelectedIndex == -1 )
            {
                MessageBox.Show("Data Tidak Ditemukan!");
            }
            else
            {
                try
                {
                    string SNama = StNamaTb.Text;
                    string JenisKelamin = StJkCb.SelectedItem.ToString();
                    string NoTelp = StPhoneTb.Text;
                    int Jurusan = Convert.ToInt32(StJurCb.SelectedValue.ToString());
                    string Query = "insert into StudentTbl values('{0}','{1}','{2}','{3}')";
                    Query = string.Format(Query, SNama, JenisKelamin, NoTelp, Jurusan );
                    Con.SetData(Query);
                    ShowStudent();
                    MessageBox.Show("Murid telah ditambah!");
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        int Key = 0;
        private void MuridList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            StNamaTb.Text = MuridList.SelectedRows[0].Cells[1].Value.ToString();
            StJkCb.SelectedItem = MuridList.SelectedRows[0].Cells[2].Value.ToString();
            StPhoneTb.Text = MuridList.SelectedRows[0].Cells[3].Value.ToString();
            StJurCb.SelectedValue = MuridList.SelectedRows[0].Cells[4].Value.ToString();
            if (StNamaTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(MuridList.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void UbahBtn_Click(object sender, EventArgs e)
        {
            if (StNamaTb.Text == "" || StJkCb.SelectedIndex == -1 || StPhoneTb.Text == "" || StJurCb.SelectedIndex == -1)
            {
                MessageBox.Show("Data Tidak Ditemukan!");
            }
            else
            {
                try
                {
                    string SNama = StNamaTb.Text;
                    string JenisKelamin = StJkCb.SelectedItem.ToString();
                    string NoTelp = StPhoneTb.Text;
                    int Jurusan = Convert.ToInt32(StJurCb.SelectedValue.ToString());
                    string Query = "update StudentTbl set StNama ='{0}', StJk ='{1}', StPhone ='{2}', StJurusan = {3} where StCode = {4}";
                    Query = string.Format(Query, SNama, JenisKelamin, NoTelp, Jurusan, Key);
                    Con.SetData(Query);
                    ShowStudent();
                    MessageBox.Show("Murid telah diubah!");
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void HapusBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Data Tidak Ditemukan!");
            }
            else
            {
                try
                {
                    string SNama = StNamaTb.Text;
                    string JenisKelamin = StJkCb.SelectedItem.ToString();
                    string NoTelp = StPhoneTb.Text;
                    int Jurusan = Convert.ToInt32(StJurCb.SelectedValue.ToString());
                    string Query = "delete from StudentTbl where StCode = {0}";
                    Query = string.Format(Query, Key);
                    Con.SetData(Query);
                    ShowStudent();
                    MessageBox.Show("Murid telah dihapus!");
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}
