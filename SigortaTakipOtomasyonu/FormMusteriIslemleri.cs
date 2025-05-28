using SigortaTakipOtomasyonu.MusteriModulu;
using System;
using System.Windows.Forms;

namespace SigortaTakipOtomasyonu
{
    public partial class FormMusteriIslemleri : Form
    {
        private int seciliId = -1;

        public FormMusteriIslemleri()
        {
            InitializeComponent();

            // Form açılır açılmaz veri gelsin
            this.Load += FormMusteriIslemleri_Load;

            // Grid'e manuel sütun eklemesi yoksa bunlar yeterli
            dgvMusteriler.AutoGenerateColumns = true;
            dgvMusteriler.CellClick += dgvMusteri_CellClick;
        }

        private void FormMusteriIslemleri_Load(object sender, EventArgs e)
        {
            Listele();
        }

        /// <summary>
        /// Veritabanından tüm müşterileri çekip DataGridView'e aktarır.
        /// </summary>
        private void Listele()
        {
            try
            {
                var islemler = new MusteriIslemleri();
                var tumMusteriler = islemler.Listele();

                dgvMusteriler.DataSource = null;
                dgvMusteriler.Columns.Clear();
                dgvMusteriler.DataSource = tumMusteriler;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı bağlantı hatası:\n" + ex.Message,
                                "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            var m = new Musteri(
                id: 0,
                ad: txtAd.Text.Trim(),
                soyad: txtSoyad.Text.Trim(),
                telefon: txtTelefon.Text.Trim()
            );

            new MusteriIslemleri().Ekle(m);
            MessageBox.Show("Müşteri eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (seciliId == -1)
            {
                MessageBox.Show("Lütfen silmek için bir müşteri seçin.",
                                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var cevap = MessageBox.Show("Bu müşteriyi silmek istediğinize emin misiniz?",
                                        "Silme Onayı",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question);

            if (cevap == DialogResult.Yes)
            {
                new MusteriIslemleri().Sil(seciliId);
                MessageBox.Show("Müşteri silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                seciliId = -1;
                Listele();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (seciliId == -1)
            {
                MessageBox.Show("Lütfen güncellemek için bir müşteri seçin.",
                                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var cevap = MessageBox.Show("Bu müşterinin bilgilerini güncellemek istediğinize emin misiniz?",
                                        "Güncelleme Onayı",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question);

            if (cevap == DialogResult.Yes)
            {
                var m = new Musteri(
                    id: seciliId,
                    ad: txtAd.Text.Trim(),
                    soyad: txtSoyad.Text.Trim(),
                    telefon: txtTelefon.Text.Trim()
                );

                new MusteriIslemleri().Guncelle(m);
                MessageBox.Show("Müşteri güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            var aranan = txtAd.Text.Trim();
            var sonuc = new MusteriIslemleri().Ara(aranan);

            dgvMusteriler.DataSource = null;
            dgvMusteriler.Columns.Clear();
            dgvMusteriler.DataSource = sonuc;
        }

        /// <summary>
        /// DataGridView'de bir satıra tıklandığında TextBox'lara veriyi basar.
        /// </summary>
        private void dgvMusteri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvMusteriler.Rows[e.RowIndex];
            seciliId = Convert.ToInt32(row.Cells["Id"].Value);
            txtAd.Text = row.Cells["Ad"].Value?.ToString() ?? "";
            txtSoyad.Text = row.Cells["Soyad"].Value?.ToString() ?? "";
            txtTelefon.Text = row.Cells["Telefon"].Value?.ToString() ?? "";
        }
    }
}
