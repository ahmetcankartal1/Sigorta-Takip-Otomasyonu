namespace SigortaTakipOtomasyonu
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
            this.btnMusteriIslemleri = new System.Windows.Forms.Button();
            this.btnPoliceIslemleri = new System.Windows.Forms.Button();
            this.btnHasarIslemleri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMusteriIslemleri
            // 
            this.btnMusteriIslemleri.Location = new System.Drawing.Point(99, 190);
            this.btnMusteriIslemleri.Name = "btnMusteriIslemleri";
            this.btnMusteriIslemleri.Size = new System.Drawing.Size(195, 76);
            this.btnMusteriIslemleri.TabIndex = 0;
            this.btnMusteriIslemleri.Text = "Müşteri İşlemeleri";
            this.btnMusteriIslemleri.UseVisualStyleBackColor = true;
            this.btnMusteriIslemleri.Click += new System.EventHandler(this.btnmusteriislemleri_Click);
            // 
            // btnPoliceIslemleri
            // 
            this.btnPoliceIslemleri.Location = new System.Drawing.Point(344, 190);
            this.btnPoliceIslemleri.Name = "btnPoliceIslemleri";
            this.btnPoliceIslemleri.Size = new System.Drawing.Size(187, 76);
            this.btnPoliceIslemleri.TabIndex = 1;
            this.btnPoliceIslemleri.Text = "Poliçe İşlemleri";
            this.btnPoliceIslemleri.UseVisualStyleBackColor = true;
            this.btnPoliceIslemleri.Click += new System.EventHandler(this.btnPoliceIslemleri_Click);
            // 
            // btnHasarIslemleri
            // 
            this.btnHasarIslemleri.Location = new System.Drawing.Point(597, 190);
            this.btnHasarIslemleri.Name = "btnHasarIslemleri";
            this.btnHasarIslemleri.Size = new System.Drawing.Size(189, 76);
            this.btnHasarIslemleri.TabIndex = 2;
            this.btnHasarIslemleri.Text = "Hasar İşlemleri";
            this.btnHasarIslemleri.UseVisualStyleBackColor = true;
            this.btnHasarIslemleri.Click += new System.EventHandler(this.btnHasarIslemleri_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 506);
            this.Controls.Add(this.btnHasarIslemleri);
            this.Controls.Add(this.btnPoliceIslemleri);
            this.Controls.Add(this.btnMusteriIslemleri);
            this.Name = "Form1";
            this.Text = "Sigorta Takip Otomasyonu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMusteriIslemleri;
        private System.Windows.Forms.Button btnPoliceIslemleri;
        private System.Windows.Forms.Button btnHasarIslemleri;
    }
}

