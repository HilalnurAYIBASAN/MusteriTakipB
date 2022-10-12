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
    public partial class FrmKategoriler : Form
    {
        public FrmKategoriler()
        {
            InitializeComponent();
        }

        private void FrmKategoriler_Load(object sender, EventArgs e)
        {
            // kategoriler tablosunu datagridview1 de gösterelim
            DataSet1TableAdapters.KategorilerTableAdapter kta = 
                new DataSet1TableAdapters.KategorilerTableAdapter();
            dataGridView1.DataSource = kta.GetKategoriler();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // textbx1 e yazılan kategori adını tabloya ekleyelim :
            DataSet1TableAdapters.KategorilerTableAdapter kta =
                new DataSet1TableAdapters.KategorilerTableAdapter();

            if ( string.IsNullOrWhiteSpace(textBox1.Text) ) //(textBox1.Text.Length == 0)
            {
                MessageBox.Show("Boş Bırakma!");
            }
            else
            {
                kta.KategoriEkle(textBox1.Text);
                // değişikliği göster
                dataGridView1.DataSource = kta.GetKategoriler();
                textBox1.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // txtbx2 de numarası yazan kategoriyi silelim
            DataSet1TableAdapters.KategorilerTableAdapter kta =
                new DataSet1TableAdapters.KategorilerTableAdapter();
            int no = int.Parse(textBox2.Text);
            kta.KategoriSil(no);
            // göster
            dataGridView1.DataSource=kta.GetKategoriler();
            textBox2.Text = "";

        }
    }
}
