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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-H65VDV2\SQLEXPRESS;Initial Catalog=marcin.bohm;Integrated Security=True");
            string query = "SELECT * FROM Narzedzia";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-H65VDV2\SQLEXPRESS;Initial Catalog=marcin.bohm;Integrated Security=True");

            if (String.IsNullOrEmpty(textBox2.Text) || String.IsNullOrEmpty(textBox3.Text) || String.IsNullOrEmpty(textBox4.Text) || String.IsNullOrEmpty(textBox5.Text) || String.IsNullOrEmpty(textBox6.Text))
            {
                MessageBox.Show("Fill all of the textboxes");
            }
            else
            {
                SqlCommand query = new SqlCommand("INSERT INTO Narzedzia (nazwa_podstawowa, nazwa_dodatkowa, numer_inwentarzowy, ilosc, id_rodzaj_narzedzia, narzedzie_unikatowe) " +
                " VALUES ('" + textBox2.Text.Trim() + ", " + textBox3.Text.Trim() + ", " + textBox4.Text.Trim() + ", " + textBox5.Text.Trim() + ", " + textBox6.Text.Trim() + ", "+checkBox1.CheckState.ToString()+"')", con);
            }
        }
    }
}
