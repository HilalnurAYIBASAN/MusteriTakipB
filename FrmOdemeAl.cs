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
    public partial class FrmOdemeAl : Form
    {
        public FrmOdemeAl()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.MüşterilerTableAdapter taMusteriler = new DataSet1TableAdapters.MüşterilerTableAdapter();
            DataSet1TableAdapters.MusteriDetayTableAdapter taMusteriDetay = new DataSet1TableAdapters.MusteriDetayTableAdapter();
            taMusteriler.BorcAzalt(decimal.Parse(tbTutar.Text), int.Parse(lblMusteriNo.Text));
            taMusteriDetay.DetayEkleme(int.Parse(lblMusteriNo.Text),0, decimal.Parse(tbTutar.Text),dtpTarih.Value,tbAciklama.Text);
            this.Close();
        }
    }
}
