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
    public partial class FrmUrunler : Form
    {
        public FrmUrunler()
        {
            InitializeComponent();
        }

        private void FrmUrunler_Load(object sender, EventArgs e)
        {
            UrunleriGrideGetir();
        }
        public void UrunleriGrideGetir()
        {
            DataSet1TableAdapters.ÜrünlerTableAdapter ta = new DataSet1TableAdapters.ÜrünlerTableAdapter();
            dataGridView1.DataSource = ta.GetUrunler();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmUrunOlustur f = new FrmUrunOlustur();
            f.ShowDialog();
            UrunleriGrideGetir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmUrunAlis f = new frmUrunAlis();
            DataGridViewRow secilisatir = dataGridView1.CurrentRow;
            f.label1.Text = secilisatir.Cells["ÜrünNo"].Value.ToString();
            f.label2.Text = secilisatir.Cells["ÜrünAdı"].Value.ToString();
            UrunleriGrideGetir();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmUrunSatis urunsatis = new FrmUrunSatis();
            DataGridViewRow secilisatir = dataGridView1.CurrentRow;
            urunsatis.label1.Text = secilisatir.Cells["ÜrünNo"].Value.ToString();
            urunsatis.label2.Text = secilisatir.Cells["ÜrünAdı"].Value.ToString();
            UrunleriGrideGetir();
            urunsatis.ShowDialog();
        }
    }
}
