using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qnewwwwwww
{
    public partial class hizlierisimcs : Form
    {
        public hizlierisimcs()
        {
            InitializeComponent();
        }

        private void biblicotecaHikayesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ahmetikaradag.wordpress.com/2019/09/27/biblioteca-hikayesi/");

        }

        private void destekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Destek için ahmetikrdg@outlook.com adresine e-mail gönderebilirsiniz.","Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu program Haliç Üniversitesi Kariyer Merkezi desteği ile İşletme Enformatiği öğrencisi Ahmet Karadağ Tarafından oluşturulmuştur.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kullanımKlavuzuVideosuİçinTıklayınızToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=Lg7ueVhoPrs&feature=youtu.be");

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
