using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LerafSchoolManage.UserControls;

namespace LerafSchoolManage
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock= DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UC_Dashboard uc = new UC_Dashboard();
            addUserControl(uc);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UC_Students uc = new UC_Students();
            addUserControl(uc);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UC_Jurusan uc = new UC_Jurusan();
            addUserControl(uc);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
            MessageBox.Show("Anda telah keluar!");
        }
    }
}
