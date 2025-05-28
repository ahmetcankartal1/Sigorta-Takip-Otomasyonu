namespace SigortaTakipOtomasyonu
{
    partial class FormHasarIslemleri
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
            this.lblPoliceId = new System.Windows.Forms.Label();
            this.txtPoliceId = new System.Windows.Forms.TextBox();
            this.dtpHasarTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblHasarTarihi = new System.Windows.Forms.Label();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.lblHasarTutar = new System.Windows.Forms.Label();
            this.txtHasarTutar = new System.Windows.Forms.TextBox();
            this.dgvHasarlar = new System.Windows.Forms.DataGridView();
            this.btnH_Ekle = new System.Windows.Forms.Button();
            this.btnH_Listele = new System.Windows.Forms.Button();
            this.btnH_Ara = new System.Windows.Forms.Button();
            this.btnH_Sil = new System.Windows.Forms.Button();
            this.btnH_Güncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHasarlar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPoliceId
            // 
            this.lblPoliceId.AutoSize = true;
            this.lblPoliceId.Location = new System.Drawing.Point(143, 36);
            this.lblPoliceId.Name = "lblPoliceId";
            this.lblPoliceId.Size = new System.Drawing.Size(67, 16);
            this.lblPoliceId.TabIndex = 0;
            this.lblPoliceId.Text = "Poliçe ID: ";
            // 
            // txtPoliceId
            // 
            this.txtPoliceId.Location = new System.Drawing.Point(216, 30);
            this.txtPoliceId.Name = "txtPoliceId";
            this.txtPoliceId.Size = new System.Drawing.Size(116, 22);
            this.txtPoliceId.TabIndex = 1;
            // 
            // dtpHasarTarihi
            // 
            this.dtpHasarTarihi.Location = new System.Drawing.Point(216, 88);
            this.dtpHasarTarihi.Name = "dtpHasarTarihi";
            this.dtpHasarTarihi.Size = new System.Drawing.Size(200, 22);
            this.dtpHasarTarihi.TabIndex = 2;
            // 
            // lblHasarTarihi
            // 
            this.lblHasarTarihi.AutoSize = true;
            this.lblHasarTarihi.Location = new System.Drawing.Point(126, 93);
            this.lblHasarTarihi.Name = "lblHasarTarihi";
            this.lblHasarTarihi.Size = new System.Drawing.Size(84, 16);
            this.lblHasarTarihi.TabIndex = 3;
            this.lblHasarTarihi.Text = "Hasar Tarihi:";
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Location = new System.Drawing.Point(141, 178);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(69, 16);
            this.lblAciklama.TabIndex = 4;
            this.lblAciklama.Text = "Açıklama :";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(216, 178);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(205, 163);
            this.txtAciklama.TabIndex = 5;
            // 
            // lblHasarTutar
            // 
            this.lblHasarTutar.AutoSize = true;
            this.lblHasarTutar.Location = new System.Drawing.Point(126, 144);
            this.lblHasarTutar.Name = "lblHasarTutar";
            this.lblHasarTutar.Size = new System.Drawing.Size(84, 16);
            this.lblHasarTutar.TabIndex = 6;
            this.lblHasarTutar.Text = "Hasar Tutarı:";
            // 
            // txtHasarTutar
            // 
            this.txtHasarTutar.Location = new System.Drawing.Point(216, 138);
            this.txtHasarTutar.Name = "txtHasarTutar";
            this.txtHasarTutar.Size = new System.Drawing.Size(196, 22);
            this.txtHasarTutar.TabIndex = 7;
            // 
            // dgvHasarlar
            // 
            this.dgvHasarlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHasarlar.Location = new System.Drawing.Point(464, 30);
            this.dgvHasarlar.Name = "dgvHasarlar";
            this.dgvHasarlar.RowHeadersWidth = 51;
            this.dgvHasarlar.RowTemplate.Height = 24;
            this.dgvHasarlar.Size = new System.Drawing.Size(447, 311);
            this.dgvHasarlar.TabIndex = 8;
            this.dgvHasarlar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHasarlar_CellContentClick);
            // 
            // btnH_Ekle
            // 
            this.btnH_Ekle.Location = new System.Drawing.Point(78, 395);
            this.btnH_Ekle.Name = "btnH_Ekle";
            this.btnH_Ekle.Size = new System.Drawing.Size(114, 54);
            this.btnH_Ekle.TabIndex = 9;
            this.btnH_Ekle.Text = "Ekle";
            this.btnH_Ekle.UseVisualStyleBackColor = true;
            // 
            // btnH_Listele
            // 
            this.btnH_Listele.Location = new System.Drawing.Point(218, 395);
            this.btnH_Listele.Name = "btnH_Listele";
            this.btnH_Listele.Size = new System.Drawing.Size(114, 54);
            this.btnH_Listele.TabIndex = 10;
            this.btnH_Listele.Text = "Listele";
            this.btnH_Listele.UseVisualStyleBackColor = true;
            // 
            // btnH_Ara
            // 
            this.btnH_Ara.Location = new System.Drawing.Point(352, 395);
            this.btnH_Ara.Name = "btnH_Ara";
            this.btnH_Ara.Size = new System.Drawing.Size(114, 54);
            this.btnH_Ara.TabIndex = 11;
            this.btnH_Ara.Text = "Ara";
            this.btnH_Ara.UseVisualStyleBackColor = true;
            this.btnH_Ara.Click += new System.EventHandler(this.btnH_Ara_Click_1);
            // 
            // btnH_Sil
            // 
            this.btnH_Sil.Location = new System.Drawing.Point(633, 395);
            this.btnH_Sil.Name = "btnH_Sil";
            this.btnH_Sil.Size = new System.Drawing.Size(114, 54);
            this.btnH_Sil.TabIndex = 13;
            this.btnH_Sil.Text = "Sil";
            this.btnH_Sil.UseVisualStyleBackColor = true;
            // 
            // btnH_Güncelle
            // 
            this.btnH_Güncelle.Location = new System.Drawing.Point(489, 395);
            this.btnH_Güncelle.Name = "btnH_Güncelle";
            this.btnH_Güncelle.Size = new System.Drawing.Size(114, 54);
            this.btnH_Güncelle.TabIndex = 14;
            this.btnH_Güncelle.Text = "Güncelle";
            this.btnH_Güncelle.UseVisualStyleBackColor = true;
            this.btnH_Güncelle.Click += new System.EventHandler(this.btnH_Güncelle_Click_1);
            // 
            // FormHasarIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 553);
            this.Controls.Add(this.btnH_Güncelle);
            this.Controls.Add(this.btnH_Sil);
            this.Controls.Add(this.btnH_Ara);
            this.Controls.Add(this.btnH_Listele);
            this.Controls.Add(this.btnH_Ekle);
            this.Controls.Add(this.dgvHasarlar);
            this.Controls.Add(this.txtHasarTutar);
            this.Controls.Add(this.lblHasarTutar);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.lblHasarTarihi);
            this.Controls.Add(this.dtpHasarTarihi);
            this.Controls.Add(this.txtPoliceId);
            this.Controls.Add(this.lblPoliceId);
            this.Name = "FormHasarIslemleri";
            this.Text = "Hasar Takip İşlemleri";
            this.Load += new System.EventHandler(this.FormHasarIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHasarlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPoliceId;
        private System.Windows.Forms.TextBox txtPoliceId;
        private System.Windows.Forms.DateTimePicker dtpHasarTarihi;
        private System.Windows.Forms.Label lblHasarTarihi;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label lblHasarTutar;
        private System.Windows.Forms.TextBox txtHasarTutar;
        private System.Windows.Forms.DataGridView dgvHasarlar;
        private System.Windows.Forms.Button btnH_Ekle;
        private System.Windows.Forms.Button btnH_Listele;
        private System.Windows.Forms.Button btnH_Ara;
        private System.Windows.Forms.Button btnH_Sil;
        private System.Windows.Forms.Button btnH_Güncelle;
    }
}