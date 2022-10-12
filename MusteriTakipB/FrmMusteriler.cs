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
    public partial class FrmMusteriler : Form
    {
        // Field Alan
        DataSet1TableAdapters.MüşterilerTableAdapter mta =
            new DataSet1TableAdapters.MüşterilerTableAdapter();

        public FrmMusteriler()
        {
            InitializeComponent();
        }

        private void FrmMusteriler_Load(object sender, EventArgs e)
        {
            // form yüklendiğinde Müşterileri gridde göster
            dataGridView1.DataSource = mta.GetMusteriler();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Yeni müşteri kaydetmek için FrmMusteriEkle formunu aç
            FrmMusteriEkle frmMusteriEkle = new FrmMusteriEkle();
            frmMusteriEkle.ShowDialog();// program akışı burada frmMusteriEkle yi bekler
            //frmMusteriEkle den dönüldü, gridde göster
            dataGridView1.DataSource = mta.GetMusteriler();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // datagridview 1 in güncel/aktif satırını  seçilen satır olarak al
            // seçili satırdaki daki müşterinin numarasını , adını, soyadını, borcunu al,
            
            DataGridViewRow secilisatir = dataGridView1.CurrentRow;
            int no = Convert.ToInt32(secilisatir.Cells["MüşteriNo"].Value);
            string ad = secilisatir.Cells["Adı"].Value.ToString();
            string soyad = secilisatir.Cells["Soyadı"].Value.ToString();
            string borc = secilisatir.Cells["Borç"].Value.ToString();
            // FrmMusteriDuzenle formuna aktarmak için 
            // FrmMusteriDuzenle formunu aç, no,ad,soy,borc bilgilerini
            // label5, txtbx1, 2, ve 3 e aktar
            // orneğin bu bilgiler 1, alp, imrek, 0TL olsun
            // aktaralım
            FrmMusteriDuzenle frmMusteriDuzenle = new FrmMusteriDuzenle();
            frmMusteriDuzenle.label5.Text = no.ToString();
            frmMusteriDuzenle.textBox1.Text = ad;
            frmMusteriDuzenle.textBox2.Text = soyad;
            frmMusteriDuzenle.textBox3.Text = borc;
            frmMusteriDuzenle.ShowDialog(); // program akış alt forma geçti bekliyoruz
            // alt formdan dönüldü , Müşteri güncellendi, gridde göster
            dataGridView1.DataSource = mta.GetMusteriler();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataGridViewRow secilisatir = dataGridView1.CurrentRow;
            FrmBorcEkle f = new FrmBorcEkle();
            f.lblMusteriAdi.Text = secilisatir.Cells["Adı"].Value.ToString() + " " + secilisatir.Cells["Soyadı"].Value.ToString();
            f.lblMusteriNo.Text = secilisatir.Cells["MüşteriNo"].Value.ToString() ;
            f.ShowDialog();
            dataGridView1.DataSource = mta.GetMusteriler();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataGridViewRow secilisatir = dataGridView1.CurrentRow;
            FrmOdemeAl f = new FrmOdemeAl();
            f.lblMusteriAdi.Text = secilisatir.Cells["Adı"].Value.ToString() + " " + secilisatir.Cells["Soyadı"].Value.ToString();
            f.lblMusteriNo.Text = secilisatir.Cells["MüşteriNo"].Value.ToString();
            f.ShowDialog();
            dataGridView1.DataSource = mta.GetMusteriler();

        }
    }
}
