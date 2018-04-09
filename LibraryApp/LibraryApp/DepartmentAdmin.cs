using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class DepartmentAdmin : Form
    {
        public DepartmentAdmin()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void DepartmentAdmin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            AdminForm AdminForm1 = new AdminForm();


            this.Hide();

            AdminForm1.Show();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LoginForm lo = new LoginForm();
            lo.Close();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

            LoginForm lo = new LoginForm();
            lo.Close();
            Application.Exit();
        }
    }
}
