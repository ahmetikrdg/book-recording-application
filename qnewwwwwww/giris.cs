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
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-U7PU1B5\\SQLEXPRESS;Initial Catalog=book;Integrated Security=True");
        baglantisinif bgl = new baglantisinif();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.adres);
            conn.Open();
            SqlCommand komut1 = new SqlCommand("Select * from books where kitapad like '%" + textBox1.Text + "%'", baglanti);
            komut1.Parameters.AddWithValue("@p1", textBox1.Text );
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut1);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
        void listele()
        {
            this.booksTableAdapter.Fill(this.bookDataSet2.books);

        }
        private void giris_Load(object sender, EventArgs e)
        {
            this.booksTableAdapter.Fill(this.bookDataSet2.books);

        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            biblioteca open = new biblioteca();
            open.Show();
        }

       
        

        private void btnharf_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hizlierisimcs cs = new hizlierisimcs();
            cs.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            arama ara = new arama();
            ara.Show();
        }
    }
}
