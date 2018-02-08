using System;
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
               string line = " ";
                string Password = " ";
                string UserName = " ";
                string FullName= " ";
                string ID = "";
                while ((line = r.ReadLine()) != null)
                {
                    string[] linearray = line.Split(',');
                    for (int i = 0; i < 1; i++)
                    {
                        Password = linearray[i+2];
                        UserName = linearray[i+1];
                        FullName = linearray[i];
                        ID = linearray[i++];
                    }
                    foreach(string linesplit in linearray)
                    {
                                                                     
                    }
                   List<EmployeeDetails> Listofemployees = new List<EmployeeDetails>();
                    Listofemployees.Add(new EmployeeDetails(int.Parse(ID), FullName, UserName, Password)); 
                }
            }
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            ReadingTextFile();
        }
    }
}
