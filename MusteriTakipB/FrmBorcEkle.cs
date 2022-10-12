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
    public partial class FrmBorcEkle : Form
    {
        public FrmBorcEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* 1.musteri detay a kayıt ekle
             *2.musteriler tab. borç alanını artır
             *
             */
             
           
            DataSet1TableAdapters.MusteriDetayTableAdapter taMusteriDetay = new DataSet1TableAdapters.MusteriDetayTableAdapter();
            DataSet1TableAdapters.MüşterilerTableAdapter taMusteriler = new DataSet1TableAdapters.MüşterilerTableAdapter();
           
            taMusteriDetay.DetayEkleme(int.Parse(lblMusteriNo.Text),decimal.Parse(tbTutar.Text),0,dtpTarih.Value,tbAciklama.Text);
            taMusteriler.BorcArttir(decimal.Parse(tbTutar.Text), int.Parse(lblMusteriNo.Text));
            this.Close();

        }
    }
}
