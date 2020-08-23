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

        SqlConnection con = new SqlConnection();
        SqlCommand query = new SqlCommand();

        public Form2()
        {
            InitializeComponent();
            con.ConnectionString = @"Data Source=DESKTOP-H65VDV2\SQLEXPRESS;Initial Catalog=marcin.bohm;Integrated Security=True";
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
            
;
            if (String.IsNullOrEmpty(textBox2.Text) || String.IsNullOrEmpty(textBox3.Text) || String.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Fill all of the textboxes");
            }

            else
            {
                con.Open();

                   
                query.Connection = con;
                    
                query.CommandText = "INSERT INTO Narzedzia (nazwa_podstawowa, nazwa_dodatkowa, numer_inwentarzowy, ilosc, id_rodzaj_narzedzia, narzedzie_unikatowe) " +
                " VALUES ('@nazwa_podstawowa, @nazwa_dodatkowa, @numer_inwentarzowy, @ilosc, @id_rodzaj_narzedzia, @narzedzie_unikatowe')";

                    
                query.Parameters.AddWithValue("@nazwa_podstawowa", textBox2.Text.Trim());
                   
                query.Parameters.AddWithValue("@nazwa_dodatkowa", textBox3.Text.Trim());
                   
                query.Parameters.AddWithValue("@numer_inwentarzowy", textBox4.Text.Trim());
                   
                query.Parameters.AddWithValue("@ilosc", numericUpDown1);
                   
                query.Parameters.AddWithValue("@id_rodzaj_narzedzia", listBox1.SelectedItem.ToString());
                
                    
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
            this.narzedziaTableAdapter.Fill(this._marcin_bohmDataSet2.Narzedzia);
            this.rodzaj_NarzedziaTableAdapter.Fill(this._marcin_bohmDataSet.Rodzaj_Narzedzia);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();

            query.Connection = con;

            query.CommandText = "EXEC zwieksz_ilosc_o_jeden";

            query.ExecuteNonQuery();

            con.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            con.Open();

            query.Connection = con;

            query.CommandText = "UPDATE Narzedzia SET ilosc = ilosc + 1 WHERE id_narzedzia = '"+numericUpDown3.Value+"'";

            query.ExecuteNonQuery();

            con.Close();
        }
    }
}
