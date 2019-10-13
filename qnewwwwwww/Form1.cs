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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-U7PU1B5\\SQLEXPRESS;Initial Catalog=book;Integrated Security=True");
        baglantisinif bgl = new baglantisinif();
        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }
        void listele()
        {
            
            this.booksTableAdapter.Fill(this.bookDataSet.books);

        }

        
        private void btnekle_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.adres);
            conn.Open();
            SqlCommand komut = new SqlCommand(" insert into books (kitapad,yazar,çevirmen,tür,basımyılı,yayınevi) values (@p1,@p2,@p3,@p4,@p5,@p6)", conn);
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtyazar.Text);
            komut.Parameters.AddWithValue("@p3", txtcevirmen.Text);
            komut.Parameters.AddWithValue("@p4", cmbtür.Text);
            komut.Parameters.AddWithValue("@p5", txtbasyıl.Text);
            komut.Parameters.AddWithValue("@p6", txtyayev.Text);
            komut.ExecuteNonQuery();
            listele();
            conn.Close();
            listele();
            
            MessageBox.Show("Kitap Kayıt Edildi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.adres);
            conn.Open();
            SqlCommand komutsil = new SqlCommand("Delete from books where kitapid=@p1 ", conn);
            komutsil.Parameters.AddWithValue("@p1", txtid.Text);
            komutsil.ExecuteNonQuery();
            listele();
            conn.Close();
            listele();

            MessageBox.Show("Kitap Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtid.Text= dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtad.Text= dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtyazar.Text= dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtcevirmen.Text= dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            cmbtür.Text= dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtbasyıl.Text= dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtyayev.Text= dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.adres);
            conn.Open();
            SqlCommand komutgun = new SqlCommand("update books set kitapad=@p1,yazar=@p2,çevirmen=@p3,tür=@p4,basımyılı=@p5,yayınevi=@p6 where kitapid=@p7", conn);
            komutgun.Parameters.AddWithValue("@p1", txtad.Text);
            komutgun.Parameters.AddWithValue("@p2", txtyazar.Text);
            komutgun.Parameters.AddWithValue("@p3", txtcevirmen.Text);
            komutgun.Parameters.AddWithValue("@p4", cmbtür.Text);
            komutgun.Parameters.AddWithValue("@p5", txtbasyıl.Text);
            komutgun.Parameters.AddWithValue("@p6", txtyayev.Text);
            komutgun.Parameters.AddWithValue("@p7", txtid.Text);
            komutgun.ExecuteNonQuery();
            listele();
            conn.Close();
            listele();
            MessageBox.Show("Kitap Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtid.Text = "";
            txtad.Text = "";
            txtyazar.Text = "";
            txtbasyıl.Text = "";
            cmbtür.Text = "";
            txtyayev.Text = "";
            txtyazar.Text = "";
            txtcevirmen.Text = "";
        }

        

       

        private void btnara_Click(object sender, EventArgs e)
        {

           
        }

        

        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
