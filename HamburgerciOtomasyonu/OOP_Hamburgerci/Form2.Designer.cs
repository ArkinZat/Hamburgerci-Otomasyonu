
namespace OOP_Hamburgerci
{
    partial class Form2
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
            this.grpMenuBilgileri = new System.Windows.Forms.GroupBox();
            this.btnMenuEkle = new System.Windows.Forms.Button();
            this.nmrMenuFiyati = new System.Windows.Forms.NumericUpDown();
            this.txtMenuAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpMenuBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrMenuFiyati)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMenuBilgileri
            // 
            this.grpMenuBilgileri.Controls.Add(this.btnMenuEkle);
            this.grpMenuBilgileri.Controls.Add(this.nmrMenuFiyati);
            this.grpMenuBilgileri.Controls.Add(this.txtMenuAdi);
            this.grpMenuBilgileri.Controls.Add(this.label2);
            this.grpMenuBilgileri.Controls.Add(this.label1);
            this.grpMenuBilgileri.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpMenuBilgileri.Location = new System.Drawing.Point(3, 12);
            this.grpMenuBilgileri.Name = "grpMenuBilgileri";
            this.grpMenuBilgileri.Size = new System.Drawing.Size(341, 186);
            this.grpMenuBilgileri.TabIndex = 0;
            this.grpMenuBilgileri.TabStop = false;
            this.grpMenuBilgileri.Text = "MENÜ BİLGİLERİ";
            // 
            // btnMenuEkle
            // 
            this.btnMenuEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMenuEkle.Location = new System.Drawing.Point(107, 93);
            this.btnMenuEkle.Name = "btnMenuEkle";
            this.btnMenuEkle.Size = new System.Drawing.Size(163, 64);
            this.btnMenuEkle.TabIndex = 4;
            this.btnMenuEkle.Text = "MENÜYÜ KAYDET";
            this.btnMenuEkle.UseVisualStyleBackColor = false;
            this.btnMenuEkle.Click += new System.EventHandler(this.btnMenuEkle_Click);
            // 
            // nmrMenuFiyati
            // 
            this.nmrMenuFiyati.Location = new System.Drawing.Point(107, 67);
            this.nmrMenuFiyati.Name = "nmrMenuFiyati";
            this.nmrMenuFiyati.Size = new System.Drawing.Size(163, 22);
            this.nmrMenuFiyati.TabIndex = 3;
            // 
            // txtMenuAdi
            // 
            this.txtMenuAdi.Location = new System.Drawing.Point(107, 24);
            this.txtMenuAdi.Multiline = true;
            this.txtMenuAdi.Name = "txtMenuAdi";
            this.txtMenuAdi.Size = new System.Drawing.Size(163, 27);
            this.txtMenuAdi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 69);
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
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menü Adı:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 224);
            this.Controls.Add(this.grpMenuBilgileri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form2";
            this.grpMenuBilgileri.ResumeLayout(false);
            this.grpMenuBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrMenuFiyati)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMenuBilgileri;
        private System.Windows.Forms.Button btnMenuEkle;
        private System.Windows.Forms.NumericUpDown nmrMenuFiyati;
        private System.Windows.Forms.TextBox txtMenuAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}