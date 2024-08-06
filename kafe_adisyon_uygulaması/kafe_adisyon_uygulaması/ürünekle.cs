using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kafe_adisyon_uygulaması
{
    public partial class ürünekle : Form
    {
        private string baglantiCumlesi = "server=DESKTOP-SERKAN; Initial Catalog=kafe;Integrated Security=SSPI";
        public ürünekle()
        {
            InitializeComponent();
        }

        private void ürünekle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string urunAdi = textBox1.Text;
            int kategoriID = Convert.ToInt32(textBox2.Text);
            decimal urunFiyati = Convert.ToDecimal(textBox4.Text);
            int stokMiktari = Convert.ToInt32(textBox3.Text);

            if (string.IsNullOrWhiteSpace(urunAdi))
            {
                MessageBox.Show("Lütfen ürün adını girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ürünü veritabanına ekle
            UrunEkle(urunAdi, kategoriID, urunFiyati, stokMiktari);

            // Formu kapat
            this.Close();
        }

        private void UrunEkle(string urunAdi, int kategoriID, decimal urunFiyati, int stokMiktari)
        {
            using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
            {
                string sorgu = "INSERT INTO Urunler (UrunAdi, KategoriID, Fiyat, StokMiktari) VALUES (@UrunAdi, @KategoriID, @Fiyat, @StokMiktari)";
                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    komut.Parameters.AddWithValue("@UrunAdi", urunAdi);
                    komut.Parameters.AddWithValue("@KategoriID", kategoriID);
                    komut.Parameters.AddWithValue("@Fiyat", urunFiyati);
                    komut.Parameters.AddWithValue("@StokMiktari", stokMiktari);

                    try
                    {
                        baglanti.Open();
                        komut.ExecuteNonQuery();                        
                        MessageBox.Show("Ürün başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        yönetim yönetim = new yönetim();
                        yönetim.UrunButonlariniOlustur();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Ürün eklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
