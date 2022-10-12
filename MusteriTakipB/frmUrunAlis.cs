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
    public partial class frmUrunAlis : Form
    {
        public frmUrunAlis()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.ÜrünlerTableAdapter urunler = new DataSet1TableAdapters.ÜrünlerTableAdapter();
            urunler.AdetArtir(int.Parse(textBox1.Text), int.Parse(label1.Text));
            this.Close();

        }

        private void frmUrunAlis_Load(object sender, EventArgs e)
        {
            
           
        }
    }
}
