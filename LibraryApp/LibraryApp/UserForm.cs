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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {

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
            Application.Exit();
        }

        

        
    }
}
