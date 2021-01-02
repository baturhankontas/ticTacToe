namespace gun5Oyun
{
    partial class AnaEkran
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rbKisi = new System.Windows.Forms.RadioButton();
			this.rbPC = new System.Windows.Forms.RadioButton();
			this.btnButton = new System.Windows.Forms.Button();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rbKisi);
			this.groupBox1.Controls.Add(this.rbPC);
			this.groupBox1.Location = new System.Drawing.Point(28, 26);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox1.Size = new System.Drawing.Size(293, 82);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Oyuncu Seç";
			// 
			// rbKisi
			// 
			this.rbKisi.AutoSize = true;
			this.rbKisi.Location = new System.Drawing.Point(29, 54);
			this.rbKisi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.rbKisi.Name = "rbKisi";
			this.rbKisi.Size = new System.Drawing.Size(106, 21);
			this.rbKisi.TabIndex = 1;
			this.rbKisi.TabStop = true;
			this.rbKisi.Text = "KİŞİ ile oyna";
			this.rbKisi.UseVisualStyleBackColor = true;
			// 
			// rbPC
			// 
			this.rbPC.AutoSize = true;
			this.rbPC.Location = new System.Drawing.Point(29, 25);
			this.rbPC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.rbPC.Name = "rbPC";
			this.rbPC.Size = new System.Drawing.Size(100, 21);
			this.rbPC.TabIndex = 0;
			this.rbPC.TabStop = true;
			this.rbPC.Text = "PC ile oyna";
			this.rbPC.UseVisualStyleBackColor = true;
			// 
			// btnButton
			// 
			this.btnButton.Location = new System.Drawing.Point(221, 132);
			this.btnButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnButton.Name = "btnButton";
			this.btnButton.Size = new System.Drawing.Size(100, 28);
			this.btnButton.TabIndex = 3;
			this.btnButton.Text = "Devam";
			this.btnButton.UseVisualStyleBackColor = true;
			this.btnButton.Click += new System.EventHandler(this.btnButton_Click);
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
			// 
			// AnaEkran
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(348, 182);
			this.Controls.Add(this.btnButton);
			this.Controls.Add(this.groupBox1);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "AnaEkran";
			this.Text = "Form1";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbKisi;
        private System.Windows.Forms.RadioButton rbPC;
        private System.Windows.Forms.Button btnButton;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
	}
}

