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
    public partial class UC_Dashboard : UserControl
    {
        Functions Con;
        public UC_Dashboard()
        {
            InitializeComponent();
            Con = new Functions();
            TotalMurid();
            TotalJurusan();
            TotalMuridPria();
        }
        private void TotalMurid()
        {
            string Query = "select Count(*) as Stud from StudentTbl";
            foreach(DataRow dr in Con.GetData(Query).Rows)
            {
                StNumLbl.Text = dr["Stud"].ToString();
            }
        }

        private void TotalJurusan()
        {
            string Query = "select Count(*) as Jur from JurusanTbl";
            foreach (DataRow dr in Con.GetData(Query).Rows)
            {
                StJurLbl.Text = dr["Jur"].ToString();
            }
        }

        private void TotalMuridPria()
        {
            string Jk = "Pria";
            string Query = "select Count(*) as Pria from StudentTbl where StJk = '{0}'";
            Query = string.Format(Query, Jk);
            foreach (DataRow dr in Con.GetData(Query).Rows)
            {
                StPriaLbl.Text = dr["Pria"].ToString();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void UC_Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
