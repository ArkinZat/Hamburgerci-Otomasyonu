
namespace OOP_Hamburgerci
{
    partial class Form1
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
            this.cmbMenuler = new System.Windows.Forms.ComboBox();
            this.flpEkstraMalzemeler = new System.Windows.Forms.FlowLayoutPanel();
            this.rdKucuk = new System.Windows.Forms.RadioButton();
            this.rdOrta = new System.Windows.Forms.RadioButton();
            this.rdBuyuk = new System.Windows.Forms.RadioButton();
            this.gbBoyutlar = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nmrAdet = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSiparisEkle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbxSiparisler = new System.Windows.Forms.ListBox();
            this.btnSiparisTamamla = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.gbBoyutlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMenuler
            // 
            this.cmbMenuler.FormattingEnabled = true;
            this.cmbMenuler.Location = new System.Drawing.Point(36, 206);
            this.cmbMenuler.Name = "cmbMenuler";
            this.cmbMenuler.Size = new System.Drawing.Size(282, 21);
            this.cmbMenuler.TabIndex = 0;
            // 
            // flpEkstraMalzemeler
            // 
            this.flpEkstraMalzemeler.Location = new System.Drawing.Point(36, 332);
            this.flpEkstraMalzemeler.Name = "flpEkstraMalzemeler";
            this.flpEkstraMalzemeler.Size = new System.Drawing.Size(282, 103);
            this.flpEkstraMalzemeler.TabIndex = 1;
            // 
            // rdKucuk
            // 
            this.rdKucuk.AutoSize = true;
            this.rdKucuk.Location = new System.Drawing.Point(6, 19);
            this.rdKucuk.Name = "rdKucuk";
            this.rdKucuk.Size = new System.Drawing.Size(61, 17);
            this.rdKucuk.TabIndex = 2;
            this.rdKucuk.TabStop = true;
            this.rdKucuk.Text = "Küçük";
            this.rdKucuk.UseVisualStyleBackColor = true;
            // 
            // rdOrta
            // 
            this.rdOrta.AutoSize = true;
            this.rdOrta.Location = new System.Drawing.Point(91, 19);
            this.rdOrta.Name = "rdOrta";
            this.rdOrta.Size = new System.Drawing.Size(49, 17);
            this.rdOrta.TabIndex = 3;
            this.rdOrta.TabStop = true;
            this.rdOrta.Text = "Orta";
            this.rdOrta.UseVisualStyleBackColor = true;
            // 
            // rdBuyuk
            // 
            this.rdBuyuk.AutoSize = true;
            this.rdBuyuk.Location = new System.Drawing.Point(165, 19);
            this.rdBuyuk.Name = "rdBuyuk";
            this.rdBuyuk.Size = new System.Drawing.Size(60, 17);
            this.rdBuyuk.TabIndex = 4;
            this.rdBuyuk.TabStop = true;
            this.rdBuyuk.Text = "Büyük";
            this.rdBuyuk.UseVisualStyleBackColor = true;
            // 
            // gbBoyutlar
            // 
            this.gbBoyutlar.Controls.Add(this.rdKucuk);
            this.gbBoyutlar.Controls.Add(this.rdBuyuk);
            this.gbBoyutlar.Controls.Add(this.rdOrta);
            this.gbBoyutlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbBoyutlar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gbBoyutlar.Location = new System.Drawing.Point(36, 233);
            this.gbBoyutlar.Name = "gbBoyutlar";
            this.gbBoyutlar.Size = new System.Drawing.Size(282, 59);
            this.gbBoyutlar.TabIndex = 5;
            this.gbBoyutlar.TabStop = false;
            this.gbBoyutlar.Text = "BOYUT SEÇİNİZ";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(33, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "EKSTRA MALZEME SEÇİNİZ:";
            // 
            // nmrAdet
            // 
            this.nmrAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nmrAdet.Location = new System.Drawing.Point(117, 444);
            this.nmrAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrAdet.Name = "nmrAdet";
            this.nmrAdet.Size = new System.Drawing.Size(120, 21);
            this.nmrAdet.TabIndex = 6;
            this.nmrAdet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmrAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(62, 443);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "ADET";
            // 
            // btnSiparisEkle
            // 
            this.btnSiparisEkle.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnSiparisEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisEkle.ForeColor = System.Drawing.Color.Crimson;
            this.btnSiparisEkle.Location = new System.Drawing.Point(29, 470);
            this.btnSiparisEkle.Name = "btnSiparisEkle";
            this.btnSiparisEkle.Size = new System.Drawing.Size(282, 51);
            this.btnSiparisEkle.TabIndex = 8;
            this.btnSiparisEkle.Text = "SİPARİŞ EKLE";
            this.btnSiparisEkle.UseVisualStyleBackColor = false;
            this.btnSiparisEkle.Click += new System.EventHandler(this.btnSiparisEkle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OOP_Hamburgerci.Properties.Resources.indir__1_;
            this.pictureBox1.Location = new System.Drawing.Point(36, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(38, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 28);
            this.label3.TabIndex = 10;
            this.label3.Text = "MENÜ SEÇİN";
            // 
            // lbxSiparisler
            // 
            this.lbxSiparisler.FormattingEnabled = true;
            this.lbxSiparisler.HorizontalScrollbar = true;
            this.lbxSiparisler.Location = new System.Drawing.Point(328, 58);
            this.lbxSiparisler.Name = "lbxSiparisler";
            this.lbxSiparisler.Size = new System.Drawing.Size(433, 381);
            this.lbxSiparisler.TabIndex = 11;
   
            // 
            // btnSiparisTamamla
            // 
            this.btnSiparisTamamla.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSiparisTamamla.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisTamamla.ForeColor = System.Drawing.Color.DarkRed;
            this.btnSiparisTamamla.Location = new System.Drawing.Point(462, 470);
            this.btnSiparisTamamla.Name = "btnSiparisTamamla";
            this.btnSiparisTamamla.Size = new System.Drawing.Size(184, 51);
            this.btnSiparisTamamla.TabIndex = 12;
            this.btnSiparisTamamla.Text = "SİPARİŞİ TAMAMLA";
            this.btnSiparisTamamla.UseVisualStyleBackColor = false;
            this.btnSiparisTamamla.Click += new System.EventHandler(this.btnSiparisTamamla_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(325, 470);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "TOPLAM TUTAR";
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamTutar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblToplamTutar.Location = new System.Drawing.Point(382, 493);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(17, 18);
            this.lblToplamTutar.TabIndex = 14;
            this.lblToplamTutar.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 542);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSiparisTamamla);
            this.Controls.Add(this.lbxSiparisler);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSiparisEkle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nmrAdet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbBoyutlar);
            this.Controls.Add(this.flpEkstraMalzemeler);
            this.Controls.Add(this.cmbMenuler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbBoyutlar.ResumeLayout(false);
            this.gbBoyutlar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMenuler;
        private System.Windows.Forms.FlowLayoutPanel flpEkstraMalzemeler;
        private System.Windows.Forms.RadioButton rdKucuk;
        private System.Windows.Forms.RadioButton rdOrta;
        private System.Windows.Forms.RadioButton rdBuyuk;
        private System.Windows.Forms.GroupBox gbBoyutlar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmrAdet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSiparisEkle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbxSiparisler;
        private System.Windows.Forms.Button btnSiparisTamamla;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblToplamTutar;
    }
}