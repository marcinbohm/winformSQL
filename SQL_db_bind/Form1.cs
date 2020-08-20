using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_db_bind
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection(@"Data Source=DESKTOP-H65VDV2\SQLEXPRESS;Initial Catalog=marcin.bohm;Integrated Security=True");
            string query = "SELECT Count(*) FROM Login WHERE Username = '" + Username.Text + "' AND Password = '"+Password.Text.Trim()+"'";
            SqlDataAdapter sqlda = new SqlDataAdapter(query, sqlconn);
            DataTable dataTable = new DataTable();
            sqlda.Fill(dataTable);
            if(dataTable.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Form2 FrmMain = new Form2();
                FrmMain.Show();
            }
            else
            {
                MessageBox.Show("Username or password is incorrect");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
