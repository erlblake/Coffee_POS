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
using System.Data.SqlClient;

namespace Cafe
{
    public partial class DatabaseTest : Form
    {
        // SqlConnection con = new SqlConnection();


        //MySqlConnection con = new MySqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C: \Users\Emily Blake\Documents\CafeDatabase.mdf;Integrated Security=True;Connect Timeout=30");

        MySqlConnection con = new MySqlConnection(@"Data Source=(localdb)\v11.0;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public DatabaseTest()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Table ('"+FullName.Text+"', '"+UserName.Text+"', '"+Password.Text+"')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("records created");
        }
    }
}
