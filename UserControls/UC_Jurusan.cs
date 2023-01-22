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
    public partial class UC_Jurusan : UserControl
    {
        Functions Con;
        public UC_Jurusan()
        {
            InitializeComponent();
            Con = new Functions();
            ShowJurusan();
        }
        private void ShowJurusan()
        {
            string Query = "select * from JurusanTbl";
            JurusanList.DataSource = Con.GetData(Query);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void TambahBtn_Click(object sender, EventArgs e)
        {
            if(JurNameTb.Text == "" || KetTb.Text == "")
            {
                MessageBox.Show("Data Tidak Ditemukan!");
            }else
            {
                try
                {
                    string Jname = JurNameTb.Text;
                    string KetName = KetTb.Text;
                    string Query = "insert into JurusanTbl values('{0}','{1}')";
                    Query = string.Format(Query,Jname,KetName);
                    Con.SetData(Query);
                    ShowJurusan();
                    MessageBox.Show("Jurusan telah ditambah!");
              
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
       

        private void UbahBtn_Click(object sender, EventArgs e)
        {
            if (JurNameTb.Text == "" || KetTb.Text == "")
            {
                MessageBox.Show("Data Tidak Ditemukan!");
            }
            else
            {
                try
                {
                    string Jname = JurNameTb.Text;
                    string KetName = KetTb.Text;
                    string Query = "update JurusanTbl set JurNama = '{0}', JurKet = '{1}' where JurId = {2} ";
                    Query = string.Format(Query, Jname, KetName, Key);
                    Con.SetData(Query);
                    ShowJurusan();
                    MessageBox.Show("Jurusan telah diubah!");
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        int Key = 0;
        private void JurusanList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            JurNameTb.Text = JurusanList.SelectedRows[0].Cells[1].Value.ToString();
            KetTb.Text = JurusanList.SelectedRows[0].Cells[2].Value.ToString();
            if (JurNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(JurusanList.SelectedRows[0].Cells[0].Value.ToString());
            }

        }
    }
}
