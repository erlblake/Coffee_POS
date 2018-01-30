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
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (IDText.Text == "" || FullNameText.Text == "" || UserNameText.Text == "" || PasswordText.Text == "")
            {
                MessageBox.Show("Please fill in all the boxes");
            }
        }
    }
}
