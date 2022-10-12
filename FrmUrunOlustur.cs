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
    public partial class FrmUrunOlustur : Form
    {
        public FrmUrunOlustur()
        {
            InitializeComponent();
        }

        private void FrmUrunOlustur_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.KategorilerTableAdapter ta = new DataSet1TableAdapters.KategorilerTableAdapter();
            cbKategori.DisplayMember = "KategoriAdı";
            cbKategori.ValueMember = "KategoriNo";
            cbKategori.DataSource = ta.GetKategoriler();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.ÜrünlerTableAdapter ta = new DataSet1TableAdapters.ÜrünlerTableAdapter();
            ta.YeniUrun(tbAd.Text, decimal.Parse(tbFiyat.Text), int.Parse(tbAdet.Text),int.Parse( cbKategori.SelectedValue.ToString()));
            this.Close();

        }
    }
}
