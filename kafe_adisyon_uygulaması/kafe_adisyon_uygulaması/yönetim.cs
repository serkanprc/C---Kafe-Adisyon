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
    public partial class yönetim : Form
    {
        private string baglantiCumlesi = "server=DESKTOP-SERKAN; Initial Catalog=kafe;Integrated Security=SSPI";
        public yönetim()
        {
            InitializeComponent();
        }


        // Ürün butonlarını oluştur
        public void UrunButonlariniOlustur()
        {
            using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
            {
                string sorgu = "SELECT UrunID, UrunAdi, Fiyat FROM Urunler";
                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    baglanti.Open();
                    SqlDataReader okuyucu = komut.ExecuteReader();
                    while (okuyucu.Read())
                    {
                        int urunId = Convert.ToInt32(okuyucu["UrunID"]);
                        string urunAdi = okuyucu["UrunAdi"].ToString();
                        decimal urunFiyati = Convert.ToDecimal(okuyucu["Fiyat"]);

                        // Buton oluştur
                        Button urunButonu = new Button();
                        urunButonu.Text = $"{urunAdi}"; // Ürün adı ve fiyatını buton metnine ekle
                        urunButonu.Tag = urunId; // Butonun Tag özelliğine ürün ID'sini ata
                        urunButonu.Click += UrunButonu_Click; // Butona tıklandığında UrunButonu_Click metodu çağrılsın
                        adisyonekleme adisyonekleme = new adisyonekleme();
                        // FlowLayoutPanel içerisine butonu ekle
                        adisyonekleme.flowLayoutPanel1.Controls.Add(urunButonu);
                    }
                    okuyucu.Close();
                }
            }
        }

        // Ürün butonuna tıklandığında
        private void UrunButonu_Click(object sender, EventArgs e)
        {
            Button urunButonu = (Button)sender;
            int urunId = (int)urunButonu.Tag;

            // Seçilen ürünü işleme geç
            SecilenUrunuIsle(urunId);
        }

        // Seçilen ürünü işleme geç
        private void SecilenUrunuIsle(int urunId)
        {
            // Seçilen ürünün işlemlerini burada yapabilirsiniz
            // Örneğin, sipariş ekleme işlemi yapılabilir
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

