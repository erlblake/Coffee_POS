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
            PasswordText.UseSystemPasswordChar = true;

        }
        public bool inuse;

        public void Clear()
        {
            IDText.Clear();
            FullNameText.Clear();
            UserNameText.Clear();
            PasswordText.Clear();
        }

        public void ReadingInTextFile()
        {

            const string textfile = "Savedlist.txt";
            using (StreamReader r = new StreamReader(textfile))
            {
                string line;
                string Password = "";
                string UserName = "";
                string FullName = "";
                string ID = "";
                while ((line = r.ReadLine()) != "")
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
                    if (UserName == UserNameText.Text || ID == IDText.Text)
                    {
                        MessageBox.Show("Please enter a different username or ID as this has already been used");
                        if (UserName == UserNameText.Text)
                        {
                            UserNameText.Clear();
                        }
                        if (ID == IDText.Text)
                        {
                            IDText.Clear();
                        }
                        inuse = true;
                    }
                }
            }

        }


        private void Save_Click(object sender, EventArgs e)
        {
            if (IDText.Text == "" || FullNameText.Text == "" || UserNameText.Text == "" || PasswordText.Text == "")
            {
                MessageBox.Show("Please fill in all the boxes");
                IDText.Clear();
                FullNameText.Clear();
                UserNameText.Clear();
                PasswordText.Clear();

            }
            if (System.Text.RegularExpressions.Regex.IsMatch(IDText.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers");
                IDText.Clear();
            }
            else if (IDText.Text != "" && FullNameText.Text != "" && UserNameText.Text != "" && PasswordText.Text != "")
            {
                ReadingInTextFile();
                if (inuse == false)
                {
                    List<EmployeeDetails> Listofemployees = new List<EmployeeDetails>();
                    Listofemployees.Add(new EmployeeDetails(int.Parse(IDText.Text), FullNameText.Text, UserNameText.Text, PasswordText.Text));

                    MessageBox.Show("Employee has been added to the system");
                    using (StreamWriter tw = new StreamWriter("Savedlist.txt", true))
                    {

                        foreach (EmployeeDetails s in Listofemployees)
                        {
                            tw.WriteLine(s.ID + "," + s.FullName + "," + s.UserName + "," + s.Password);
                            tw.Close();
                        }
                    }
                    Clear();
                }
            }
            inuse = false;
        }

        private void IDText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


