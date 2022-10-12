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
    public partial class FrmUrunSatis : Form
    {
        public FrmUrunSatis()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.ÜrünlerTableAdapter urunler = new DataSet1TableAdapters.ÜrünlerTableAdapter();
            urunler.AdetAzalt(int.Parse(textBox1.Text), int.Parse(label1.Text));
            this.Close();
        }
    }
}
