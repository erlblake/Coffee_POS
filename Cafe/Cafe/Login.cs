using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        public void ReadingTextFile()
        {
            const string textfile = "Savedlist.txt";

            using (StreamReader r = new StreamReader(textfile))
            {
                string line = "";
                string Password = "";
                string UserName = "";
                string FullName = "";
                string ID = "";
                bool enter = false;
                while ((line = r.ReadLine()) != null)
                {
                    string[] linearray = line.Split(',');
                    for (int i = 0; i < linearray.Length; i++)
                    {
                        switch (i)
                        {
                            case 0:
                                ID = linearray[i];
                                break;
                            case 1:
                                FullName = linearray[i];
                                break;
                            case 2:
                                UserName = linearray[i];
                                break;
                            case 3:
                                Password = linearray[i];
                                break;
                        }
                    }
                List<EmployeeDetails> Listofemployees = new List<EmployeeDetails>();
                Listofemployees.Add(new EmployeeDetails(int.Parse(ID), FullName, UserName, Password));
                    if (enter == false)
                    {
                        if (UserName == UserNameText.Text.ToString() && Password == PasswordText.Text.ToString())
                        {
                            //Loads another screen
                            MessageBox.Show("Correct user details entered");
                            enter = true;
                        }
                        else
                        {
                            MessageBox.Show("Username or password are not valid");
                        }
                    }
                }                      
            }
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            List<EmployeeDetails> Listofemployees = new List<EmployeeDetails>();
            ReadingTextFile();
            if (UserNameText.Text == "" || PasswordText.Text == "")
            {
                MessageBox.Show("Please enter a username and password");
            }
        }
    }
}
