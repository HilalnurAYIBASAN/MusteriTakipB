
namespace MusteriTakipB
{
    partial class FrmSatis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GrdMusteriler = new System.Windows.Forms.DataGridView();
            this.GrdUrunler = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbTutar = new System.Windows.Forms.TextBox();
            this.tbAciklama = new System.Windows.Forms.TextBox();
            this.dtbTarih = new System.Windows.Forms.DateTimePicker();
            this.tbAdet = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GrdMusteriler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdUrunler)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrdMusteriler
            // 
            this.GrdMusteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdMusteriler.Dock = System.Windows.Forms.DockStyle.Left;
            this.GrdMusteriler.Location = new System.Drawing.Point(0, 0);
            this.GrdMusteriler.Name = "GrdMusteriler";
            this.GrdMusteriler.RowHeadersWidth = 51;
            this.GrdMusteriler.RowTemplate.Height = 24;
            this.GrdMusteriler.Size = new System.Drawing.Size(350, 581);
            this.GrdMusteriler.TabIndex = 0;
            // 
            // GrdUrunler
            // 
            this.GrdUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdUrunler.Dock = System.Windows.Forms.DockStyle.Top;
            this.GrdUrunler.Location = new System.Drawing.Point(350, 0);
            this.GrdUrunler.Name = "GrdUrunler";
            this.GrdUrunler.RowHeadersWidth = 51;
            this.GrdUrunler.RowTemplate.Height = 24;
            this.GrdUrunler.Size = new System.Drawing.Size(862, 253);
            this.GrdUrunler.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbTutar);
            this.panel1.Controls.Add(this.tbAciklama);
            this.panel1.Controls.Add(this.dtbTarih);
            this.panel1.Controls.Add(this.tbAdet);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(350, 251);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 330);
            this.panel1.TabIndex = 2;
            // 
            // tbTutar
            // 
            this.tbTutar.Location = new System.Drawing.Point(234, 184);
            this.tbTutar.Multiline = true;
            this.tbTutar.Name = "tbTutar";
            this.tbTutar.Size = new System.Drawing.Size(124, 28);
            this.tbTutar.TabIndex = 9;
            // 
            // tbAciklama
            // 
            this.tbAciklama.Location = new System.Drawing.Point(234, 130);
            this.tbAciklama.Multiline = true;
            this.tbAciklama.Name = "tbAciklama";
            this.tbAciklama.Size = new System.Drawing.Size(148, 35);
            this.tbAciklama.TabIndex = 8;
            // 
            // dtbTarih
            // 
            this.dtbTarih.Location = new System.Drawing.Point(234, 96);
            this.dtbTarih.Name = "dtbTarih";
            this.dtbTarih.Size = new System.Drawing.Size(200, 22);
            this.dtbTarih.TabIndex = 7;
            // 
            // tbAdet
            // 
            this.tbAdet.Location = new System.Drawing.Point(234, 45);
            this.tbAdet.Multiline = true;
            this.tbAdet.Name = "tbAdet";
            this.tbAdet.Size = new System.Drawing.Size(100, 25);
            this.tbAdet.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(692, 239);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 47);
            this.button2.TabIndex = 5;
            this.button2.Text = "İptal";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGreen;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(561, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 47);
            this.button1.TabIndex = 4;
            this.button1.Text = "Satış Yap";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(104, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tutar : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(104, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Açıklama : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tarih : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adet : ";
            // 
            // FrmSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 581);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GrdUrunler);
            this.Controls.Add(this.GrdMusteriler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSatis";
            this.Text = "SATIŞ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.GrdMusteriler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdUrunler)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView GrdUrunler;
        public System.Windows.Forms.DataGridView GrdMusteriler;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbTutar;
        private System.Windows.Forms.TextBox tbAciklama;
        private System.Windows.Forms.DateTimePicker dtbTarih;
        private System.Windows.Forms.TextBox tbAdet;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}