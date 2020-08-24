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
            Uzytkownik u = new Uzytkownik();
            u.Server = textBox2.Text;
            u.Database = textBox1.Text;
            u.Usrname = Username.Text;
            u.Pass = Password.Text;
            SqlConnection sqlconn = new SqlConnection($"Data Source={u.Server};Initial Catalog={u.Database};User Id={u.Usrname};Password={u.Pass}");
            try
            {
                sqlconn.Open();
                using (sqlconn)
                {
                    this.Hide();
                    Form2 FrmMain = new Form2(u);
                    FrmMain.Show();
                }
                sqlconn.Close();
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
