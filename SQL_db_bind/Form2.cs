using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
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

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-H65VDV2\SQLEXPRESS;Initial Catalog=marcin.bohm;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
;
                if (String.IsNullOrEmpty(textBox2.Text) || String.IsNullOrEmpty(textBox3.Text) || String.IsNullOrEmpty(textBox4.Text))
                {
                    MessageBox.Show("Fill all of the textboxes");
                }
                else
                {
                    con.Open();

                    SqlCommand query = new SqlCommand("INSERT INTO Narzedzia (nazwa_podstawowa, nazwa_dodatkowa, numer_inwentarzowy, ilosc, id_rodzaj_narzedzia, narzedzie_unikatowe) " +
                    " VALUES ('@nazwa_podstawowa, @nazwa_dodatkowa, @numer_inwentarzowy, @ilosc, @id_rodzaj_narzedzia, @narzedzie_unikatowe')", con);
                    query.Connection = con;

                    query.Parameters.AddWithValue("@nazwa_podstawowa", textBox2);
                    query.Parameters.AddWithValue("@nazwa_dodatkowa", textBox3);
                    query.Parameters.AddWithValue("@numer_inwentarzowy", textBox4);
                    query.Parameters.AddWithValue("@ilosc", numericUpDown1);
                    query.Parameters.AddWithValue("@id_rodzaj_narzedzia", numericUpDown2);
                
                    if(checkBox1.Checked)
                    {
                        query.Parameters.AddWithValue("@narzedzie_unikatowe", 1);
                    }
                    else 
                    {
                        query.Parameters.AddWithValue("@narzedzie_unikatowe", 0);
                    }

                    query.ExecuteNonQuery();


                    con.Close();
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-H65VDV2\SQLEXPRESS;Initial Catalog=marcin.bohm;Integrated Security=True");
            string query = "SELECT * FROM Narzedzia";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
