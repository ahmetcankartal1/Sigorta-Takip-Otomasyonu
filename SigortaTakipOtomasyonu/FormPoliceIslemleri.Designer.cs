namespace SigortaTakipOtomasyonu
{
    partial class FormPoliceIslemleri
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMusteriID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPoliceNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpBitis = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrim = new System.Windows.Forms.TextBox();
            this.btnP_Ekle = new System.Windows.Forms.Button();
            this.btnP_Listele = new System.Windows.Forms.Button();
            this.btnP_Ara = new System.Windows.Forms.Button();
            this.btnH_Guncelle = new System.Windows.Forms.Button();
            this.btnP_Sil = new System.Windows.Forms.Button();
            this.dgvPoliceler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoliceler)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri ID:";
            // 
            // txtMusteriID
            // 
            this.txtMusteriID.Location = new System.Drawing.Point(174, 48);
            this.txtMusteriID.Multiline = true;
            this.txtMusteriID.Name = "txtMusteriID";
            this.txtMusteriID.Size = new System.Drawing.Size(137, 34);
            this.txtMusteriID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Poliçe No:";
            // 
            // txtPoliceNo
            // 
            this.txtPoliceNo.Location = new System.Drawing.Point(174, 102);
            this.txtPoliceNo.Multiline = true;
            this.txtPoliceNo.Name = "txtPoliceNo";
            this.txtPoliceNo.Size = new System.Drawing.Size(137, 34);
            this.txtPoliceNo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Başlangıç Tarihi:\n\n";
            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.Location = new System.Drawing.Point(174, 159);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Size = new System.Drawing.Size(200, 22);
            this.dtpBaslangic.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Bitiş Tarihi:";
            // 
            // dtpBitis
            // 
            this.dtpBitis.Location = new System.Drawing.Point(174, 216);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Size = new System.Drawing.Size(200, 22);
            this.dtpBitis.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(121, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Prim:";
            // 
            // txtPrim
            // 
            this.txtPrim.Location = new System.Drawing.Point(174, 265);
            this.txtPrim.Multiline = true;
            this.txtPrim.Name = "txtPrim";
            this.txtPrim.Size = new System.Drawing.Size(137, 26);
            this.txtPrim.TabIndex = 9;
            // 
            // btnP_Ekle
            // 
            this.btnP_Ekle.Location = new System.Drawing.Point(34, 356);
            this.btnP_Ekle.Name = "btnP_Ekle";
            this.btnP_Ekle.Size = new System.Drawing.Size(132, 39);
            this.btnP_Ekle.TabIndex = 10;
            this.btnP_Ekle.Text = "Ekle";
            this.btnP_Ekle.UseVisualStyleBackColor = true;
            this.btnP_Ekle.Click += new System.EventHandler(this.btnP_Ekle_Click_1);
            // 
            // btnP_Listele
            // 
            this.btnP_Listele.Location = new System.Drawing.Point(172, 356);
            this.btnP_Listele.Name = "btnP_Listele";
            this.btnP_Listele.Size = new System.Drawing.Size(132, 39);
            this.btnP_Listele.TabIndex = 11;
            this.btnP_Listele.Text = "Listele";
            this.btnP_Listele.UseVisualStyleBackColor = true;
            this.btnP_Listele.Click += new System.EventHandler(this.btnP_Listele_Click_1);
            // 
            // btnP_Ara
            // 
            this.btnP_Ara.Location = new System.Drawing.Point(310, 356);
            this.btnP_Ara.Name = "btnP_Ara";
            this.btnP_Ara.Size = new System.Drawing.Size(132, 39);
            this.btnP_Ara.TabIndex = 12;
            this.btnP_Ara.Text = "Ara";
            this.btnP_Ara.UseVisualStyleBackColor = true;
            this.btnP_Ara.Click += new System.EventHandler(this.btnP_Ara_Click_1);
            // 
            // btnH_Guncelle
            // 
            this.btnH_Guncelle.Location = new System.Drawing.Point(448, 356);
            this.btnH_Guncelle.Name = "btnH_Guncelle";
            this.btnH_Guncelle.Size = new System.Drawing.Size(132, 39);
            this.btnH_Guncelle.TabIndex = 13;
            this.btnH_Guncelle.Text = "Güncelle";
            this.btnH_Guncelle.UseVisualStyleBackColor = true;
            this.btnH_Guncelle.Click += new System.EventHandler(this.btnP_Guncelle_Click_1);
            // 
            // btnP_Sil
            // 
            this.btnP_Sil.Location = new System.Drawing.Point(586, 356);
            this.btnP_Sil.Name = "btnP_Sil";
            this.btnP_Sil.Size = new System.Drawing.Size(132, 39);
            this.btnP_Sil.TabIndex = 14;
            this.btnP_Sil.Text = "Sil";
            this.btnP_Sil.UseVisualStyleBackColor = true;
            this.btnP_Sil.Click += new System.EventHandler(this.btnP_Sil_Click_1);
            // 
            // dgvPoliceler
            // 
            this.dgvPoliceler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPoliceler.Location = new System.Drawing.Point(586, 48);
            this.dgvPoliceler.Name = "dgvPoliceler";
            this.dgvPoliceler.RowHeadersWidth = 51;
            this.dgvPoliceler.RowTemplate.Height = 24;
            this.dgvPoliceler.Size = new System.Drawing.Size(411, 273);
            this.dgvPoliceler.TabIndex = 15;
            this.dgvPoliceler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPoliceler_CellClick);
            // 
            // FormPoliceIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 583);
            this.Controls.Add(this.dgvPoliceler);
            this.Controls.Add(this.btnP_Sil);
            this.Controls.Add(this.btnH_Guncelle);
            this.Controls.Add(this.btnP_Ara);
            this.Controls.Add(this.btnP_Listele);
            this.Controls.Add(this.btnP_Ekle);
            this.Controls.Add(this.txtPrim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpBitis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpBaslangic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPoliceNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMusteriID);
            this.Controls.Add(this.label1);
            this.Name = "FormPoliceIslemleri";
            this.Text = "Poliçe İşlemleri";
            this.Load += new System.EventHandler(this.FormPoliceIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoliceler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMusteriID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPoliceNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpBaslangic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpBitis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrim;
        private System.Windows.Forms.Button btnP_Ekle;
        private System.Windows.Forms.Button btnP_Listele;
        private System.Windows.Forms.Button btnP_Ara;
        private System.Windows.Forms.Button btnH_Guncelle;
        private System.Windows.Forms.Button btnP_Sil;
        private System.Windows.Forms.DataGridView dgvPoliceler;
    }
}