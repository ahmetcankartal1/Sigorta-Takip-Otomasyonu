using SigortaTakipOtomasyonu.PoliceModulu;
using System;
using System.Windows.Forms;

namespace SigortaTakipOtomasyonu
{
    public partial class FormPoliceIslemleri : Form
    {
        private int seciliId = -1;
        private readonly PoliceIslemleri islemler = new PoliceIslemleri();

        public FormPoliceIslemleri()
        {
            InitializeComponent();
            // Form açıldığında ve grid satır tıklanınca
            this.Load += FormPoliceIslemleri_Load;
            dgvPoliceler.AutoGenerateColumns = true;
            dgvPoliceler.CellClick += dgvPolice_CellClick;
        }

        private void FormPoliceIslemleri_Load(object sender, EventArgs e)
        {
            Listele();
        }

        /// <summary>
        /// Veritabanındaki tüm poliçeleri listeleyip DataGridView'e aktarır.
        /// </summary>
        private void Listele()
        {
            try
            {
                var tum = islemler.Listele();
                dgvPoliceler.DataSource = null;
                dgvPoliceler.Columns.Clear();
                dgvPoliceler.DataSource = tum;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı bağlantı hatası:\n" + ex.Message,
                                "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dgvPolice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvPoliceler.Rows[e.RowIndex];
            seciliId = Convert.ToInt32(row.Cells["Id"].Value);
            txtMusteriID.Text = row.Cells["MusteriID"].Value.ToString();
            txtPoliceNo.Text = row.Cells["PoliseNo"].Value.ToString();
            dtpBaslangic.Value = Convert.ToDateTime(row.Cells["BaslangicTarihi"].Value);
            dtpBitis.Value = Convert.ToDateTime(row.Cells["BitisTarihi"].Value);
            txtPrim.Text = row.Cells["Tutar"].Value.ToString();
        }

        private void dgvPoliceler_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnP_Ekle_Click_1(object sender, EventArgs e)
        {
            var p = new Police(
            id: 0,
            musteriID: int.Parse(txtMusteriID.Text.Trim()),
            poliseNo: txtPoliceNo.Text.Trim(),
            bas: dtpBaslangic.Value.Date,
            bit: dtpBitis.Value.Date,
            tutar: decimal.Parse(txtPrim.Text.Trim())
        );
            islemler.Ekle(p);
            MessageBox.Show("Poliçe eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();

        }

        private void btnP_Listele_Click_1(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnP_Ara_Click_1(object sender, EventArgs e)
        {
            var aranan = txtPoliceNo.Text.Trim();
            var sonuc = islemler.Ara(aranan);
            dgvPoliceler.DataSource = null;
            dgvPoliceler.Columns.Clear();
            dgvPoliceler.DataSource = sonuc;

        }

        private void btnP_Guncelle_Click_1(object sender, EventArgs e)
        {
            if (seciliId < 0)
            {
                MessageBox.Show("Lütfen güncellemek için bir poliçe seçin.", "Uyarı",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Bu poliçeyi güncellemek istediğinize emin misiniz?",
                                "Güncelleme Onayı",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var p = new Police(
                    id: seciliId,
                    musteriID: int.Parse(txtMusteriID.Text.Trim()),
                    poliseNo: txtPoliceNo.Text.Trim(),
                    bas: dtpBaslangic.Value.Date,
                    bit: dtpBitis.Value.Date,
                    tutar: decimal.Parse(txtPrim.Text.Trim())
                );
                islemler.Guncelle(p);
                MessageBox.Show("Poliçe güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
            }
        }

        private void btnP_Sil_Click_1(object sender, EventArgs e)
        {
            if (seciliId < 0)
            {
                MessageBox.Show("Lütfen silmek için bir poliçe seçin.", "Uyarı",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Bu poliçeyi silmek istediğinize emin misiniz?",
                                "Silme Onayı",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                islemler.Sil(seciliId);
                MessageBox.Show("Poliçe silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
            }

        }
    }
}
