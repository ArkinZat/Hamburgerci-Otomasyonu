
namespace OOP_Hamburgerci
{
    partial class Form3
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
            this.grpMalzemeBilgileri = new System.Windows.Forms.GroupBox();
            this.btnEkstraEkle = new System.Windows.Forms.Button();
            this.nmrEkstraFiyati = new System.Windows.Forms.NumericUpDown();
            this.txtEkstraMalzemeler = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpMalzemeBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrEkstraFiyati)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMalzemeBilgileri
            // 
            this.grpMalzemeBilgileri.BackColor = System.Drawing.Color.IndianRed;
            this.grpMalzemeBilgileri.Controls.Add(this.btnEkstraEkle);
            this.grpMalzemeBilgileri.Controls.Add(this.nmrEkstraFiyati);
            this.grpMalzemeBilgileri.Controls.Add(this.txtEkstraMalzemeler);
            this.grpMalzemeBilgileri.Controls.Add(this.label2);
            this.grpMalzemeBilgileri.Controls.Add(this.label1);
            this.grpMalzemeBilgileri.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpMalzemeBilgileri.Location = new System.Drawing.Point(6, 24);
            this.grpMalzemeBilgileri.Name = "grpMalzemeBilgileri";
            this.grpMalzemeBilgileri.Size = new System.Drawing.Size(364, 172);
            this.grpMalzemeBilgileri.TabIndex = 1;
            this.grpMalzemeBilgileri.TabStop = false;
            this.grpMalzemeBilgileri.Text = "EKSTRA MALZEME BİLGİLERİ";
            // 
            // btnEkstraEkle
            // 
            this.btnEkstraEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEkstraEkle.Location = new System.Drawing.Point(115, 95);
            this.btnEkstraEkle.Name = "btnEkstraEkle";
            this.btnEkstraEkle.Size = new System.Drawing.Size(213, 64);
            this.btnEkstraEkle.TabIndex = 4;
            this.btnEkstraEkle.Text = "EKSTRA MALZEMEYİ KAYDET";
            this.btnEkstraEkle.UseVisualStyleBackColor = false;
            this.btnEkstraEkle.Click += new System.EventHandler(this.btnEkstraEkle_Click);
            // 
            // nmrEkstraFiyati
            // 
            this.nmrEkstraFiyati.Location = new System.Drawing.Point(165, 67);
            this.nmrEkstraFiyati.Name = "nmrEkstraFiyati";
            this.nmrEkstraFiyati.Size = new System.Drawing.Size(163, 22);
            this.nmrEkstraFiyati.TabIndex = 3;
            // 
            // txtEkstraMalzemeler
            // 
            this.txtEkstraMalzemeler.Location = new System.Drawing.Point(165, 24);
            this.txtEkstraMalzemeler.Multiline = true;
            this.txtEkstraMalzemeler.Name = "txtEkstraMalzemeler";
            this.txtEkstraMalzemeler.Size = new System.Drawing.Size(163, 27);
            this.txtEkstraMalzemeler.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fiyatı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ekstra Malzeme Adı:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 220);
            this.Controls.Add(this.grpMalzemeBilgileri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form3";
            this.grpMalzemeBilgileri.ResumeLayout(false);
            this.grpMalzemeBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrEkstraFiyati)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMalzemeBilgileri;
        private System.Windows.Forms.Button btnEkstraEkle;
        private System.Windows.Forms.NumericUpDown nmrEkstraFiyati;
        private System.Windows.Forms.TextBox txtEkstraMalzemeler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}