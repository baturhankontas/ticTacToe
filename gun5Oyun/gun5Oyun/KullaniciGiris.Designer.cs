namespace gun5Oyun
{
    partial class KullaniciGiris
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
            this.txtKulanici1 = new System.Windows.Forms.TextBox();
            this.txtKullanici2 = new System.Windows.Forms.TextBox();
            this.btnOyunaBasla = new System.Windows.Forms.Button();
            this.lblKullanici1 = new System.Windows.Forms.Label();
            this.lblKullanici2 = new System.Windows.Forms.Label();
            this.comboBoxZorluk = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtKulanici1
            // 
            this.txtKulanici1.Location = new System.Drawing.Point(123, 59);
            this.txtKulanici1.Name = "txtKulanici1";
            this.txtKulanici1.Size = new System.Drawing.Size(100, 20);
            this.txtKulanici1.TabIndex = 0;
            // 
            // txtKullanici2
            // 
            this.txtKullanici2.Location = new System.Drawing.Point(123, 85);
            this.txtKullanici2.Name = "txtKullanici2";
            this.txtKullanici2.Size = new System.Drawing.Size(100, 20);
            this.txtKullanici2.TabIndex = 1;
            // 
            // btnOyunaBasla
            // 
            this.btnOyunaBasla.Location = new System.Drawing.Point(106, 127);
            this.btnOyunaBasla.Name = "btnOyunaBasla";
            this.btnOyunaBasla.Size = new System.Drawing.Size(117, 34);
            this.btnOyunaBasla.TabIndex = 2;
            this.btnOyunaBasla.Text = "Kaydet ve Oyuna Başla";
            this.btnOyunaBasla.UseVisualStyleBackColor = true;
            this.btnOyunaBasla.Click += new System.EventHandler(this.btnOyunaBasla_Click);
            // 
            // lblKullanici1
            // 
            this.lblKullanici1.AutoSize = true;
            this.lblKullanici1.Location = new System.Drawing.Point(29, 62);
            this.lblKullanici1.Name = "lblKullanici1";
            this.lblKullanici1.Size = new System.Drawing.Size(55, 13);
            this.lblKullanici1.TabIndex = 3;
            this.lblKullanici1.Text = "Kullanıcı 1";
            // 
            // lblKullanici2
            // 
            this.lblKullanici2.AutoSize = true;
            this.lblKullanici2.Location = new System.Drawing.Point(29, 88);
            this.lblKullanici2.Name = "lblKullanici2";
            this.lblKullanici2.Size = new System.Drawing.Size(55, 13);
            this.lblKullanici2.TabIndex = 4;
            this.lblKullanici2.Text = "Kullanıcı 2";
            // 
            // comboBoxZorluk
            // 
            this.comboBoxZorluk.FormattingEnabled = true;
            this.comboBoxZorluk.Location = new System.Drawing.Point(32, 22);
            this.comboBoxZorluk.Name = "comboBoxZorluk";
            this.comboBoxZorluk.Size = new System.Drawing.Size(191, 21);
            this.comboBoxZorluk.TabIndex = 5;
            // 
            // KullaniciGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 187);
            this.Controls.Add(this.comboBoxZorluk);
            this.Controls.Add(this.lblKullanici2);
            this.Controls.Add(this.lblKullanici1);
            this.Controls.Add(this.btnOyunaBasla);
            this.Controls.Add(this.txtKullanici2);
            this.Controls.Add(this.txtKulanici1);
            this.Name = "KullaniciGiris";
            this.Text = "KullaniciEkrani";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKulanici1;
        private System.Windows.Forms.TextBox txtKullanici2;
        private System.Windows.Forms.Button btnOyunaBasla;
        private System.Windows.Forms.Label lblKullanici1;
        private System.Windows.Forms.Label lblKullanici2;
        private System.Windows.Forms.ComboBox comboBoxZorluk;
    }
}