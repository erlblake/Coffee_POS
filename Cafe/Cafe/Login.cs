using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            IDictionary<string, string> dict = new Dictionary<string, string>();
            const string textfile = "Savedlist.txt";

            using (StreamReader r = new StreamReader(textfile))
            {
                string line = "";
                string Password = "";
                string UserName = "";
                string FullName = "";
                string ID = "";
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
                            default:
                                throw new Exception("Should not be added");
                        }
                    }
                    List<EmployeeDetails> Listofemployees = new List<EmployeeDetails>();
                    Listofemployees.Add(new EmployeeDetails(int.Parse(ID), FullName, UserName, Password));
                    dict.Add(UserName, Password);
                }
            }

            if (dict.ContainsKey(UserNameText.Text))
            {
                string value = "";
                try
                {
                    dict.TryGetValue(UserNameText.Text, out value);
                    if (value == PasswordText.Text)
                    {
                        //Thread t = new Thread(new ThreadStart(ThreadProc));
                        //t.Start();
                        var app = new Employees();                      
                        app.FormClosed += App_FormClosed;
                        app.Show();
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Password entered");
                    }
                }
                catch
                {
                    MessageBox.Show("Incorrect password entered");
                }
            }
            else
            {
                MessageBox.Show("Incorrect Password entererd");
            }

        }

        //This is an event for a method that triggers when form.formclosed is triggered
        private void App_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        public static void ThreadProc()
        {
            Application.Run(new Employees());
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

