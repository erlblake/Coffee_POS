using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe
{
    public class EmployeeDetails
    {
        public List<EmployeeDetails> Listofemployees;

        public int ID;// { get; set; }
        public string FullName;// { get; set; }
        public string UserName{ get; set; }
        public string Password;// { get; set; }

        public EmployeeDetails(int pID, string pFullName, string pUserName, string pPassword)
        {
            ID = pID;
            FullName = pFullName;
            UserName = pUserName;
            Password = pPassword;

        }
        public EmployeeDetails(string CheckUserName)
        {
            UserName = CheckUserName;
        }
    }
        /*
        { set; get; }
        */
    }
    
   
   

