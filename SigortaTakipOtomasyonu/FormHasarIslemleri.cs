using SigortaTakipOtomasyonu.HasarModulu;
using System;
using System.Windows.Forms;
using SigortaTakipOtomasyonu.PoliceModulu;
namespace SigortaTakipOtomasyonu
{
    public partial class FormHasarIslemleri : Form
    {
        private int seciliHasarId = -1;
       
        private readonly HasarIslemleri islemler = new HasarIslemleri();

        public FormHasarIslemleri()
        {
            InitializeComponent();
            this.Load += FormHasarIslemleri_Load;
            dgvHasarlar.AutoGenerateColumns = true;
            dgvHasarlar.CellClick += DgvHasarlar_CellClick;
            btnH_Ekle.Click += btnH_Ekle_Click;
            btnH_Listele.Click += btnH_Listele_Click;
            btnH_Ara.Click += btnH_Ara_Click;
            btnH_Güncelle.Click += btnH_Güncelle_Click;
            btnH_Sil.Click += btnH_Sil_Click;
        }

        private void FormHasarIslemleri_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnH_Ekle_Click(object sender, EventArgs e)
        {
            if (!BilgilerGecerliMi()) return;

            var h = new Hasar(
                id: 0,
                poliseId: int.Parse(txtPoliceId.Text.Trim()),
                hasarTarihi: dtpHasarTarihi.Value.Date,
                aciklama: txtAciklama.Text.Trim(),
                tutar: decimal.Parse(txtHasarTutar.Text.Trim())
            );

            islemler.Ekle(h);
            MessageBox.Show("Hasar kaydı başarıyla eklendi.",
                            "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Temizle();
            Listele();
        }

        private void btnH_Listele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnH_Ara_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtPoliceId.Text.Trim(), out int pid))
            {
                MessageBox.Show("Geçerli bir Poliçe ID girin.",
                                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPoliceId.Focus();
                return;
            }

            var sonuc = islemler.Ara(pid);
            dgvHasarlar.DataSource = null;
            dgvHasarlar.Columns.Clear();
            dgvHasarlar.DataSource = sonuc;
        }

        private void btnH_Guncelle_Click(object sender, EventArgs e)
        {
            if (seciliHasarId < 0)
            {
                MessageBox.Show("Lütfen güncellemek için bir hasar kaydı seçin.",
                                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!BilgilerGecerliMi()) return;

            if (MessageBox.Show("Bu hasar kaydını güncellemek istediğinize emin misiniz?",
                                "Güncelleme Onayı",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.No)
                return;

            var h = new Hasar(
                id: seciliHasarId,
                poliseId: int.Parse(txtPoliceId.Text.Trim()),
                hasarTarihi: dtpHasarTarihi.Value.Date,
                aciklama: txtAciklama.Text.Trim(),
                tutar: decimal.Parse(txtHasarTutar.Text.Trim())
            );

            islemler.Guncelle(h);
            MessageBox.Show("Hasar kaydı başarıyla güncellendi.",
                            "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Temizle();
            Listele();
        }

        private void btnH_Sil_Click(object sender, EventArgs e)
        {
            if (seciliHasarId < 0)
            {
                MessageBox.Show("Lütfen silmek için bir hasar kaydı seçin.",
                                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Bu hasar kaydını silmek istediğinize emin misiniz?",
                                "Silme Onayı",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning) == DialogResult.No)
                return;

            islemler.Sil(seciliHasarId);
            MessageBox.Show("Hasar kaydı silindi.",
                            "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Temizle();
            Listele();
        }

        private void DgvHasarlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvHasarlar.Rows[e.RowIndex];
            seciliHasarId = Convert.ToInt32(row.Cells["Id"].Value);
            txtPoliceId.Text = row.Cells["PoliceId"].Value.ToString();
            dtpHasarTarihi.Value = Convert.ToDateTime(row.Cells["HasarTarihi"].Value);
            txtAciklama.Text = row.Cells["Aciklama"].Value.ToString();
            txtHasarTutar.Text = row.Cells["Tutar"].Value.ToString();
        }

        // ———————————————————————————————
        // Yardımcı Metotlar
        // ———————————————————————————————

        /// <summary>
        /// DataGridView'i temizler ve veritabanından yeni listeyi çeker.
        /// </summary>
        private void Listele()
        {
            try
            {
                var liste = islemler.Listele();
                dgvHasarlar.DataSource = null;
                dgvHasarlar.Columns.Clear();
                dgvHasarlar.DataSource = liste;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Hata:\n" + ex.Message +
                    (ex.InnerException != null
                        ? "\nInner exception:\n" + ex.InnerException.Message
                        : ""),
                    "Veritabanı Hatası",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        /// <summary>
        /// Formdaki bütün giriş alanlarını varsayılan hale çevirir.
        /// </summary>
        private void Temizle()
        {
            txtPoliceId.Clear();
            dtpHasarTarihi.Value = DateTime.Today;
            txtAciklama.Clear();
            txtHasarTutar.Clear();
            seciliHasarId = -1;
        }

        /// <summary>
        /// Kullanıcıdan gelen değerlerin geçerli olup olmadığını kontrol eder.
        /// </summary>
        private bool BilgilerGecerliMi()
        {
            if (!int.TryParse(txtPoliceId.Text.Trim(), out _))
            {
                MessageBox.Show("Geçerli bir Poliçe ID girin.",
                                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPoliceId.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtAciklama.Text))
            {
                MessageBox.Show("Açıklama boş bırakılamaz.",
                                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAciklama.Focus();
                return false;
            }
            if (!decimal.TryParse(txtHasarTutar.Text.Trim(), out _))
            {
                MessageBox.Show("Geçerli bir hasar tutarı girin.",
                                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHasarTutar.Focus();
                return false;
            }
            return true;
        }

        private void btnH_Güncelle_Click(object sender, EventArgs e)
        {

        }

        private void dgvHasarlar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnH_Ara_Click_1(object sender, EventArgs e)
        {
          
        }

        private void btnH_Güncelle_Click_1(object sender, EventArgs e)
        {

        }
    }
}
