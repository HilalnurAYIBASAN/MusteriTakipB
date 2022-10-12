using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusteriTakipB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kategorilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Kategoriler Tablosunu göstermek ve VT işlemleri için
            // FrmKategoriler sınıfından bir nesne örneği oluşturalım :
            
            FrmKategoriler frmKategoriler = new FrmKategoriler();
            // frmkategoriler nesnesini (formunu) açalım :
            //frmKategoriler.Show();//formlar arasında geçişe olanak verir
            frmKategoriler.ShowDialog();//formlar arası geçişe izin vermez!!!

        }

        private void müşterilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Müşteriler alt formunu aç
            FrmMusteriler frmMusteriler = new FrmMusteriler();
            frmMusteriler.ShowDialog();

        }

        private void ürünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUrunler f = new FrmUrunler();
            f.ShowDialog();
        }

        private void satışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSatis f = new FrmSatis();
            f.ShowDialog();
        }
    }
}
