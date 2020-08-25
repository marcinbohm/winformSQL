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
        Uzytkownik uzytkownik;

        SqlConnection con = new SqlConnection();
        SqlCommand query = new SqlCommand();

        public Form2(Uzytkownik uzytkownik)
        {
            InitializeComponent();
            this.uzytkownik = uzytkownik;
            con.ConnectionString = $"Data Source={uzytkownik.Server};Initial Catalog={uzytkownik.Database};user id={uzytkownik.Usrname};password={uzytkownik.Pass}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT * FROM Narzedzia";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
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
            if (String.IsNullOrEmpty(textBox2.Text) || String.IsNullOrEmpty(textBox3.Text) || String.IsNullOrEmpty(textBox4.Text) || String.IsNullOrEmpty(listBox1.Text))
            {
                MessageBox.Show("Fill all of the textboxes");
            }

            else
            {
                con.Open();

                   
                query.Connection = con;
                    
                query.CommandText = "INSERT INTO Narzedzia (nazwa_podstawowa, nazwa_dodatkowa, numer_inwentarzowy, ilosc, id_rodzaj_narzedzia, narzedzie_unikatowe) VALUES ('@nazwa_podstawowa', '@nazwa_dodatkowa', '@numer_inwentarzowy', @ilosc, @id_rodzaj_narzedzia, @narzedzie_unikatowe)";

                    
                query.Parameters.AddWithValue("@nazwa_podstawowa", textBox2.Text.Trim());
                   
                query.Parameters.AddWithValue("@nazwa_dodatkowa", textBox3.Text.Trim());
                   
                query.Parameters.AddWithValue("@numer_inwentarzowy", textBox4.Text.Trim());
                   
                query.Parameters.AddWithValue("@ilosc", numericUpDown1.Value);
                   
                query.Parameters.AddWithValue("@id_rodzaj_narzedzia", listBox1.SelectedItem);
                
                    
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
            //this.narzedziaTableAdapter.Fill(this._marcin_bohmDataSet2.Narzedzia);
            //this.rodzaj_NarzedziaTableAdapter.Fill(this._marcin_bohmDataSet.Rodzaj_Narzedzia);
            con.Open();
            string query = "SELECT * FROM Narzedzia";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;


            /*string query2 = "SELECT rodzaj FROM Rodzaj_Narzedzia";
            SqlDataAdapter adpt = new SqlDataAdapter(query2, con);
            DataTable dt2 = new DataTable();
            adpt.Fill(dt2);
            foreach (DataRow row in dt2.Rows)
            {
                listBox1.Items.Add(row["rodzaj"].ToString());
            }
            con.Close();*/


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            WykonajZapytanie("EXEC zwieksz_ilosc_o_jeden");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            WykonajZapytanie("UPDATE Narzedzia SET ilosc = ilosc + 1 WHERE id_narzedzia = '" + numericUpDown3.Value + "'");
        }

        private void WykonajZapytanie(String Query)
        {
            con.Open();

            query.Connection = con;

            query.CommandText = Query;

            query.ExecuteNonQuery();

            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query2 = "SELECT id_rodzaj_narzedzia, rodzaj FROM Rodzaj_Narzedzia";
            SqlDataAdapter adpt = new SqlDataAdapter(query2, con);
            DataTable dt2 = new DataTable();
            adpt.Fill(dt2);
            //foreach (DataRow row in dt2.Rows)
            //{
            comboBox1.DataSource = dt2;
            comboBox1.ValueMember = "id_rodzaj_narzedzia";
            comboBox1.DisplayMember = "rodzaj";
            comboBox1.DataBindings.Add(new Binding("SelectedValue", dt2, "id_rodzaj_narzedzia"));
            ;// listBox1.Items.Add(row["rodzaj"]);
            //}
            con.Close();
        }
    }
}
