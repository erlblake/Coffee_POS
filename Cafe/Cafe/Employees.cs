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
        public List<EmployeeDetails> EmployeeDetails;

        private void Save_Click(object sender, EventArgs e)
        {
            if (IDText.Text == "" || FullNameText.Text == "" || UserNameText.Text == "" || PasswordText.Text == "")
            {
                MessageBox.Show("Please fill in all the boxes");
            }
            else
            {
                List<EmployeeDetails> EmployeeDetails = new List<EmployeeDetails>();
                EmployeeDetails.Add(int.Parse(IDText.Text), FullNameText.Text, UserNameText.Text, PasswordText.Text);
                MessageBox.Show ("Employee has been added to the system");
            }
        }
    }
}
