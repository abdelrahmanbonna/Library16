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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            DepartmentAdmin DepartmentAdmin1 = new DepartmentAdmin();

            

            this.Hide();
            DepartmentAdmin1.Show();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            StaffAdmin StaffAdmin1 = new StaffAdmin();
           

           

            this.Hide();

            StaffAdmin1.Show();

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ParersAdmin Pare1rsAdmin = new ParersAdmin();
          

         

            this.Hide();
            Pare1rsAdmin.Show();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm lo = new LoginForm();

            this.Hide();
            lo.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LoginForm lo = new LoginForm();
            lo.Close();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            LoginForm lo = new LoginForm();
            lo.Close();
            Application.Exit();

        }
    }
}
