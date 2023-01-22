using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LerafSchoolManage
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if(UNameTb.Text == "" || UPassTb.Text == "")
            {
                MessageBox.Show("Data Salah!");
            }else if(UNameTb.Text == "admin" && UPassTb.Text == "admin")
            {
                Home Obj = new Home();
                Obj.Show();
                this.Hide();
            }else
            {
                MessageBox.Show("Username atau Password salah!");
                UNameTb.Text = "";
                UPassTb.Text = "";
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
