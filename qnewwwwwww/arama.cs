using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace qnewwwwwww
{
    public partial class arama : Form
    {
        public arama()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-U7PU1B5\\SQLEXPRESS;Initial Catalog=book;Integrated Security=True");
        baglantisinif bgl = new baglantisinif();
        private void arama_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bookDataSet3.books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.bookDataSet3.books);

        }


        private void textBox1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 1; i++)
            {
                textBox1.Clear();
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 1; i++)
            {
                textBox2.Clear();
            }
        }

       

        private void textBox3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 1; i++)
            {
                textBox3.Clear();
            }
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 1; i++)
            {
                textBox4.Clear();
            }
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 1; i++)
            {
                textBox5.Clear();
            }
        }

        private void textBox6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 1; i++)
            {
                textBox6.Clear();
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.adres);
            conn.Open();
            SqlCommand komut1 = new SqlCommand("Select * from books where kitapad like '%" + textBox1.Text + "%'", baglanti);
            komut1.Parameters.AddWithValue("@p1", textBox1.Text);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut1);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.adres);
            conn.Open();
            SqlCommand komut1 = new SqlCommand("Select * from books where yazar like '%" + textBox2.Text + "%'", baglanti);
            komut1.Parameters.AddWithValue("@p1", textBox2.Text);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut1);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(bgl.adres);
            conn.Open();
            SqlCommand komut1 = new SqlCommand("Select * from books where yazar like '%" + textBox3.Text + "%'", baglanti);
            komut1.Parameters.AddWithValue("@p1", textBox3.Text);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut1);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.adres);
            conn.Open();
            SqlCommand komut1 = new SqlCommand("Select * from books where Tür like '%" + textBox4.Text + "%'", baglanti);
            komut1.Parameters.AddWithValue("@p1", textBox4.Text);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut1);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.adres);
            conn.Open();
            SqlCommand komut1 = new SqlCommand("Select * from books where BasımYılı like '%" + textBox5.Text + "%'", baglanti);
            komut1.Parameters.AddWithValue("@p1", textBox5.Text);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut1);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.adres);
            conn.Open();
            SqlCommand komut1 = new SqlCommand("Select * from books where YayınEvi like '%" + textBox6.Text + "%'", baglanti);
            komut1.Parameters.AddWithValue("@p1", textBox6.Text);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut1);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
    }
}
