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
    public partial class biblioteca : Form
    {
        public biblioteca()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-U7PU1B5\\SQLEXPRESS;Initial Catalog=book;Integrated Security=True");
        baglantisinif bgl = new baglantisinif();





        private void istatistik_Load(object sender, EventArgs e)
        {
            //toplam kitap sayısı
            SqlConnection conn = new SqlConnection(bgl.adres);
            conn.Open();
            
            SqlCommand komut = new SqlCommand("Select Count (*) from books", conn);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblkitapsay.Text = dr[0].ToString();
            }
            conn.Close();


            {
                conn = new SqlConnection(bgl.adres);
                conn.Open();
                SqlCommand komutg1 = new SqlCommand("Select tür,count(*) From books group by tür", conn);
                SqlDataReader dr1 = komutg1.ExecuteReader();
                while (dr1.Read())
                {
                    chart1.Series["Kitap Türleri"].Points.AddXY(dr1[0], dr1[1]);
                }
                conn.Close();
            }

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
