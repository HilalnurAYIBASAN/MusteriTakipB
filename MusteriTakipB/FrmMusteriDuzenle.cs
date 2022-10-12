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
    public partial class FrmMusteriDuzenle : Form
    {
        public FrmMusteriDuzenle()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {// Müşteri bilgilerini güncelle
            DataSet1TableAdapters.MüşterilerTableAdapter mta =
                new DataSet1TableAdapters.MüşterilerTableAdapter();
            int no = int.Parse(label5.Text);
            decimal borc = decimal.Parse(textBox3.Text);
            mta.MusteriGuncelle(textBox1.Text, textBox2.Text, borc, no);
            this.Close();
        }
    }
}
