using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Cafe
{
    public partial class DataBase_Employees : Form
    {
        MySqlConnection con = new MySqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C: \Users\Emily Blake\Documents\CafeDatabase.mdf;Integrated Security=True;Connect Timeout=30");

        public DataBase_Employees()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Table values('"+EmployFirstName.Text+"','"+EmployUserNameText.Text+"','"+EmployPasswordText.Text+"')";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Information added to database");
        }
    }
}
