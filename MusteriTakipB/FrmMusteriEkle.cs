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
    public partial class FrmMusteriEkle : Form
    {
        public FrmMusteriEkle()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // iptal
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Müşteri kaydet 
            DataSet1TableAdapters.MüşterilerTableAdapter mta =
                new DataSet1TableAdapters.MüşterilerTableAdapter();

            decimal borc = decimal.Parse(textBox3.Text);
            mta.MusteriEkle(textBox1.Text, textBox2.Text, borc);
            this.Close();
        }
    }
}
