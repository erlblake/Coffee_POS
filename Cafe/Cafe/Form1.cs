using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        public void Login()
        {
            if (UserNameText.Text == "" || PasswordText.Text == "")
            {
                MessageBox.Show("Please enter a username and password");
                UserNameText.Clear();
                PasswordText.Clear();
            }

            else if (UserNameText.Text == "aaa" && PasswordText.Text == "aaa")
            {

                DatabaseTest databasetest = new DatabaseTest();

                databasetest.Show();

            
            }
        }
  
    }
}
