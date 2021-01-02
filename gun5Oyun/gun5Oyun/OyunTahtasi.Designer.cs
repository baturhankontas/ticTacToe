namespace gun5Oyun
{
    partial class OyunTahtasi
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
            this.oyunTahtasiTablo = new System.Windows.Forms.DataGridView();
            this.boxKullanicilar = new System.Windows.Forms.GroupBox();
            this.rbKullanici2 = new System.Windows.Forms.RadioButton();
            this.rbKullanici1 = new System.Windows.Forms.RadioButton();
            this.btnOyunBitir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.oyunTahtasiTablo)).BeginInit();
            this.boxKullanicilar.SuspendLayout();
            this.SuspendLayout();
            // 
            // oyunTahtasiTablo
            // 
            this.oyunTahtasiTablo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.oyunTahtasiTablo.Location = new System.Drawing.Point(44, 27);
            this.oyunTahtasiTablo.Name = "oyunTahtasiTablo";
            this.oyunTahtasiTablo.Size = new System.Drawing.Size(99, 53);
            this.oyunTahtasiTablo.TabIndex = 0;
            this.oyunTahtasiTablo.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.oyunTahtasiTablo_CellMouseDoubleClick);
            // 
            // boxKullanicilar
            // 
            this.boxKullanicilar.Controls.Add(this.rbKullanici2);
            this.boxKullanicilar.Controls.Add(this.rbKullanici1);
            this.boxKullanicilar.Location = new System.Drawing.Point(44, 197);
            this.boxKullanicilar.Name = "boxKullanicilar";
            this.boxKullanicilar.Size = new System.Drawing.Size(257, 52);
            this.boxKullanicilar.TabIndex = 3;
            this.boxKullanicilar.TabStop = false;
            this.boxKullanicilar.Text = "Hamle Yapacak Kullanıcı";
            // 
            // rbKullanici2
            // 
            this.rbKullanici2.AutoSize = true;
            this.rbKullanici2.Location = new System.Drawing.Point(123, 19);
            this.rbKullanici2.Name = "rbKullanici2";
            this.rbKullanici2.Size = new System.Drawing.Size(14, 13);
            this.rbKullanici2.TabIndex = 1;
            this.rbKullanici2.TabStop = true;
            this.rbKullanici2.UseVisualStyleBackColor = true;
            // 
            // rbKullanici1
            // 
            this.rbKullanici1.AutoSize = true;
            this.rbKullanici1.Location = new System.Drawing.Point(19, 19);
            this.rbKullanici1.Name = "rbKullanici1";
            this.rbKullanici1.Size = new System.Drawing.Size(14, 13);
            this.rbKullanici1.TabIndex = 0;
            this.rbKullanici1.TabStop = true;
            this.rbKullanici1.UseVisualStyleBackColor = true;
            // 
            // btnOyunBitir
            // 
            this.btnOyunBitir.Location = new System.Drawing.Point(395, 197);
            this.btnOyunBitir.Name = "btnOyunBitir";
            this.btnOyunBitir.Size = new System.Drawing.Size(75, 23);
            this.btnOyunBitir.TabIndex = 4;
            this.btnOyunBitir.Text = "Oyun Bitir";
            this.btnOyunBitir.UseVisualStyleBackColor = true;
            this.btnOyunBitir.Click += new System.EventHandler(this.btnOyunBitir_Click);
            // 
            // OyunTahtasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 325);
            this.Controls.Add(this.btnOyunBitir);
            this.Controls.Add(this.boxKullanicilar);
            this.Controls.Add(this.oyunTahtasiTablo);
            this.Name = "OyunTahtasi";
            this.Text = "OyunEkrani";
            ((System.ComponentModel.ISupportInitialize)(this.oyunTahtasiTablo)).EndInit();
            this.boxKullanicilar.ResumeLayout(false);
            this.boxKullanicilar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView oyunTahtasiTablo;
        private System.Windows.Forms.GroupBox boxKullanicilar;
        private System.Windows.Forms.RadioButton rbKullanici2;
        private System.Windows.Forms.RadioButton rbKullanici1;
        private System.Windows.Forms.Button btnOyunBitir;
    }
}