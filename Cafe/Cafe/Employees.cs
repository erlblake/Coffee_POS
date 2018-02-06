using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
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
            else
            {
                List<EmployeeDetails> Listofemployees = new List<EmployeeDetails>();
                Listofemployees.Add(new EmployeeDetails(int.Parse(IDText.Text), FullNameText.Text, UserNameText.Text, PasswordText.Text));

                MessageBox.Show("Employee has been added to the system");
                using (StreamWriter tw = new StreamWriter("Savedlist.txt", true))
                {

                    foreach (EmployeeDetails s in Listofemployees)
                    {
                        tw.WriteLine(s.ID + ", " + s.FullName + ", " + s.UserName + ", " + s.Password);
                        tw.Close();
                    }
                }
            }
        }
    }
}

