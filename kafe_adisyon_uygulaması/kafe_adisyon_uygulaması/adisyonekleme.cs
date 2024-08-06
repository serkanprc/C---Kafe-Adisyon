using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static kafe_adisyon_uygulaması.adisyonekleme;

namespace kafe_adisyon_uygulaması
{

    public partial class adisyonekleme : Form
    {
        public string SecilenMasaAdi { get; internal set; }

        public adisyonekleme()
        {
            InitializeComponent();

        }
        private void UrunEkle(int adet, string urunAdi, double fiyat)
        {
            string[] satir = { 1.ToString(), urunAdi, fiyat.ToString() };
            var urunItem = new ListViewItem(satir);
            adisyon.Items.Add(urunItem);


        }

        private void ButonaTiklandigindaUrunEkle(string urunAdi)
        {
            // SqlConnection nesnesini oluştur
            using (SqlConnection connection = new SqlConnection("server=DESKTOP-SERKAN; Initial Catalog=kafe;Integrated Security=SSPI"))
            {
                // Bağlantıyı aç
                connection.Open();

                // Ürünün fiyatını sorgulamak için SQL sorgusunu hazırla
                string query = "SELECT Fiyat FROM Urunler WHERE UrunAdi = @UrunAdi";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UrunAdi", urunAdi);

                // Sorguyu çalıştır ve fiyat bilgisini al
                object result = command.ExecuteScalar();

                if (result != null)
                {
                    double fiyat = Convert.ToDouble(result);

                    // ListView'e yeni bir satır ekle
                    ListViewItem item = new ListViewItem();
                    item.Text = "1"; // Adet
                    item.SubItems.Add(urunAdi); // Ürün Adı
                    item.SubItems.Add(fiyat.ToString()); // Fiyat

                    // ListView'e eklenen satırı göster
                    adisyon.Items.Add(item);
                }
                else
                {
                    MessageBox.Show("Ürün fiyatı bulunamadı.");
                }
            }
        }


        private void button10_Click(object sender, EventArgs e)
        {

            SqlConnection con;
            con = new SqlConnection("server=DESKTOP-SERKAN; Initial Catalog=kafe;Integrated Security=SSPI");

            con.Open();

            SqlCommand cmd = new SqlCommand("Select * from Urunler where KategoriID=1", con);


            SqlDataReader rdr = cmd.ExecuteReader();

            int buttonIndex = 0;

            while (rdr.Read())
            {

                switch (buttonIndex)
                {
                    case 0:
                        button6.Text = rdr["UrunAdi"].ToString();
                        break;
                    case 1:
                        button14.Text = rdr["UrunAdi"].ToString();
                        break;
                    case 2:
                        button15.Text = rdr["UrunAdi"].ToString();
                        break;
                    case 3:
                        button16.Text = rdr["UrunAdi"].ToString();
                        break;
                    case 4:
                        button17.Text = rdr["UrunAdi"].ToString();
                        break;
                    case 5:
                        button18.Text = rdr["UrunAdi"].ToString();
                        break;
                    case 6:
                        button19.Text = rdr["UrunAdi"].ToString();
                        break;
                    case 7:
                        button20.Text = rdr["UrunAdi"].ToString();
                        break;

                }

                buttonIndex++;
            }

            con.Close();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            ButonaTiklandigindaUrunEkle(button6.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //string[] ikinciUrunler = { "Et Döner", "Yaprak Döner", "Pilav Üstü Döner", "İskender", "Tombik Döner", "Tavuk Döner", "Beyti Döner", "Paşa Döner" };
            //double[] ikinciFiyatlar = { 130, 100, 110, 120, 140, 100, 130, 150 };
            //UrunVeFiyatBelirle(ikinciUrunler, ikinciFiyatlar);

            SqlConnection con;
            con = new SqlConnection("server=DESKTOP-SERKAN; Initial Catalog=kafe;Integrated Security=SSPI");

            con.Open();

            SqlCommand cmd = new SqlCommand("Select * from Urunler where KategoriID=2", con);


            SqlDataReader rdr = cmd.ExecuteReader();

            int buttonIndex = 0;

            while (rdr.Read())
            {
                // Butonun metin özelliğine ürün adını atayın
                switch (buttonIndex)
                {
                    case 0:
                        button6.Text = rdr["UrunAdi"].ToString();
                        break;
                    case 1:
                        button14.Text = rdr["UrunAdi"].ToString();
                        break;
                    case 2:
                        button15.Text = rdr["UrunAdi"].ToString();
                        break;
                    case 3:
                        button16.Text = rdr["UrunAdi"].ToString();
                        break;
                    case 4:
                        button17.Text = rdr["UrunAdi"].ToString();
                        break;
                    case 5:
                        button18.Text = rdr["UrunAdi"].ToString();
                        break;
                    case 6:
                        button19.Text = rdr["UrunAdi"].ToString();
                        break;
                    case 7:
                        button20.Text = rdr["UrunAdi"].ToString();
                        break;

                }

                buttonIndex++;
            }

            con.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {


            SqlConnection con;
            con = new SqlConnection("server=DESKTOP-SERKAN; Initial Catalog=kafe;Integrated Security=SSPI");

            con.Open();

            SqlCommand cmd = new SqlCommand("Select * from Urunler where KategoriID=3", con);


            SqlDataReader rdr = cmd.ExecuteReader();

            int buttonIndex = 0;

            while (rdr.Read())
            {
                // Butonun metin özelliğine ürün adını atayın
                switch (buttonIndex)
                {
                    case 0:
                        button6.Text = rdr["UrunAdi"].ToString();
                        break;
                    case 1:
                        button14.Text = rdr["UrunAdi"].ToString();
                        break;
                    case 2:
                        button15.Text = rdr["UrunAdi"].ToString();
                        break;
                    case 3:
                        button16.Text = rdr["UrunAdi"].ToString();
                        break;
                    case 4:
                        button17.Text = rdr["UrunAdi"].ToString();
                        break;
                    case 5:
                        button18.Text = rdr["UrunAdi"].ToString();
                        break;
                    case 6:
                        button19.Text = rdr["UrunAdi"].ToString();
                        break;
                    case 7:
                        button20.Text = rdr["UrunAdi"].ToString();
                        break;

                }

                buttonIndex++;
            }

            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (adisyon.SelectedItems.Count > 0)
            {
                ListViewItem selected = adisyon.SelectedItems[0];
                int adet = int.Parse(selected.SubItems[0].Text);
                adet++;
                selected.SubItems[0].Text = adet.ToString();
            }

        }

        private void adisyonekleme_Load(object sender, EventArgs e)
        {
            this.Controls.Add(flowLayoutPanel1);
            SqlConnection con;
            con = new SqlConnection("server=DESKTOP-SERKAN; Initial Catalog=kafe;Integrated Security=SSPI");

            con.Open();

            SqlCommand cmd1 = new SqlCommand("SELECT KategoriAdi FROM Kategori", con);

            SqlDataReader rdr1 = cmd1.ExecuteReader();

            System.Windows.Forms.Button[] buttons = { button10, button7, button8, button9, button11, button13 };

            int buttonIndex1 = 0;

            while (rdr1.Read() && buttonIndex1 < buttons.Length)
            {
                buttons[buttonIndex1].Text = rdr1["KategoriAdi"].ToString();
                buttonIndex1++;
            }
            con.Close();
            con.Open();



            SqlCommand cmd = new SqlCommand("Select * from Urunler where KategoriID=1", con);


            SqlDataReader rdr = cmd.ExecuteReader();

            int buttonIndex = 0;

            while (rdr.Read())
            {
                switch (buttonIndex)
                {
                    case 0:
                        button6.Text = rdr["UrunAdi"].ToString();
                        break;
                    case 1:
                        button14.Text = rdr["UrunAdi"].ToString();
                        break;
                    case 2:
                        button15.Text = rdr["UrunAdi"].ToString();
                        break;
                    case 3:
                        button16.Text = rdr["UrunAdi"].ToString();
                        break;
                    case 4:
                        button17.Text = rdr["UrunAdi"].ToString();
                        break;
                    case 5:
                        button18.Text = rdr["UrunAdi"].ToString();
                        break;
                    case 6:
                        button19.Text = rdr["UrunAdi"].ToString();
                        break;
                    case 7:
                        button20.Text = rdr["UrunAdi"].ToString();
                        break;

                }

                buttonIndex++;
            }

            con.Close();

        }


        private void button9_Click(object sender, EventArgs e)
        {
            SqlConnection con;
            con = new SqlConnection("server=DESKTOP-SERKAN; Initial Catalog=kafe;Integrated Security=SSPI");

            con.Open();

            SqlCommand cmd = new SqlCommand("Select * from Urunler where KategoriID=4", con);


            SqlDataReader rdr = cmd.ExecuteReader();

            int buttonIndex = 0;

            while (rdr.Read())
            {
                // Butonun metin özelliğine ürün adını atayın
                switch (buttonIndex)
                {
                    case 0:
                        button6.Text = rdr["UrunAdi"].ToString();
                        break;
                    case 1:
                        button14.Text = rdr["UrunAdi"].ToString();
                        break;
                    case 2:
                        button15.Text = rdr["UrunAdi"].ToString();
                        break;
                    case 3:
                        button16.Text = rdr["UrunAdi"].ToString();
                        break;
                    case 4:
                        button17.Text = rdr["UrunAdi"].ToString();
                        break;
                    case 5:
                        button18.Text = rdr["UrunAdi"].ToString();
                        break;
                    case 6:
                        button19.Text = rdr["UrunAdi"].ToString();
                        break;
                    case 7:
                        button20.Text = rdr["UrunAdi"].ToString();
                        break;

                }

                buttonIndex++;
            }

            con.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            SqlConnection con;
            con = new SqlConnection("server=DESKTOP-SERKAN; Initial Catalog=kafe;Integrated Security=SSPI");

            con.Open();

            SqlCommand cmd = new SqlCommand("Select * from Urunler where KategoriID=5", con);


            SqlDataReader rdr = cmd.ExecuteReader();

            int buttonIndex = 0;

            while (rdr.Read())
            {
                // Butonun metin özelliğine ürün adını atayın
                switch (buttonIndex)
                {
                    case 0:
                        button6.Text = rdr["UrunAdi"].ToString();
                        break;
                    case 1:
                        button14.Text = rdr["UrunAdi"].ToString();
                        break;
                    case 2:
                        button15.Text = rdr["UrunAdi"].ToString();
                        break;
                    case 3:
                        button16.Text = rdr["UrunAdi"].ToString();
                        break;
                    case 4:
                        button17.Text = rdr["UrunAdi"].ToString();
                        break;
                    case 5:
                        button18.Text = rdr["UrunAdi"].ToString();
                        break;
                    case 6:
                        button19.Text = rdr["UrunAdi"].ToString();
                        break;
                    case 7:
                        button20.Text = rdr["UrunAdi"].ToString();
                        break;

                }

                buttonIndex++;
            }

            con.Close();
        }
        public int GetMasaID(string masaAdi)
        {
            int masaID = -1;
            SqlConnection con = new SqlConnection("server=DESKTOP-SERKAN; Initial Catalog=kafe;Integrated Security=SSPI");

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT MasaID FROM Masa WHERE MasaAdi = @MasaAdi", con);
                cmd.Parameters.AddWithValue("@MasaAdi", masaAdi); // Parametre değerini doğru bir şekilde ekleyin
                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    masaID = Convert.ToInt32(rdr["MasaID"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Masa ID'si alınırken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

            return masaID;
        }
        public string SMasaAdi { get; set; } // Seçilen masa adını tutar
        public int SecilenMasaID { get; set; } // Seçilen masa ID'sini tutar
        public int GetUrunID(string urunAdi)
        {
            int urunID = -1;
            using (SqlConnection con = new SqlConnection("server=DESKTOP-SERKAN; Initial Catalog=kafe;Integrated Security=SSPI"))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT UrunID FROM Urunler WHERE UrunAdi = @UrunAdi", con))
                {
                    cmd.Parameters.AddWithValue("@UrunAdi", urunAdi);
                    con.Open();
                    urunID = (int)cmd.ExecuteScalar();
                }
            }
            return urunID;
        }

        private void button13_Click(object sender, EventArgs e)
        {

            SqlConnection con;
            con = new SqlConnection("server=DESKTOP-SERKAN; Initial Catalog=kafe;Integrated Security=SSPI");

            con.Open();

            SqlCommand cmd = new SqlCommand("Select * from Urunler where KategoriID=6", con);


            SqlDataReader rdr = cmd.ExecuteReader();

            int buttonIndex = 0;

            while (rdr.Read())
            {
                // Butonun metin özelliğine ürün adını atayın
                switch (buttonIndex)
                {
                    case 0:
                        button6.Text = rdr["UrunAdi"].ToString();
                        break;
                    case 1:
                        button14.Text = rdr["UrunAdi"].ToString();
                        break;
                    case 2:
                        button15.Text = rdr["UrunAdi"].ToString();
                        break;
                    case 3:
                        button16.Text = rdr["UrunAdi"].ToString();
                        break;
                    case 4:
                        button17.Text = rdr["UrunAdi"].ToString();
                        break;
                    case 5:
                        button18.Text = rdr["UrunAdi"].ToString();
                        break;
                    case 6:
                        button19.Text = rdr["UrunAdi"].ToString();
                        break;
                    case 7:
                        button20.Text = rdr["UrunAdi"].ToString();
                        break;

                }

                buttonIndex++;
            }

            con.Close();
        }


        private void button19_Click(object sender, EventArgs e)
        {

            ButonaTiklandigindaUrunEkle(button19.Text);

        }

        private void button18_Click(object sender, EventArgs e)
        {
            ButonaTiklandigindaUrunEkle(button18.Text);

        }

        private void button17_Click(object sender, EventArgs e)
        {

            ButonaTiklandigindaUrunEkle(button17.Text);

        }

        private void button15_Click(object sender, EventArgs e)
        {
            ButonaTiklandigindaUrunEkle(button15.Text);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            ButonaTiklandigindaUrunEkle(button16.Text);

        }

        private void button20_Click(object sender, EventArgs e)
        {

            ButonaTiklandigindaUrunEkle(button20.Text);

        }


        private void button14_Click(object sender, EventArgs e)
        {
            ButonaTiklandigindaUrunEkle(button14.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Seçilen ürünü ve masayı kontrol et
            if (adisyon.SelectedItems.Count > 0)
            {
                // Seçilen masanın ID'sini al
                int masaID = GetMasaID(SecilenMasaAdi);

                // Seçilen her bir ürünü işle
                foreach (ListViewItem selectedItem in adisyon.SelectedItems)
                {
                    int adet = Convert.ToInt32(selectedItem.SubItems[0].Text);
                    int urunID = GetSelectedUrunID(selectedItem.SubItems[1].Text);

                    // Siparişi veritabanından sil
                    DeleteOrderItem(masaID, urunID, adet);

                    // ListView'den seçilen ürünü kaldır
                    selectedItem.Remove();

                }
            }
            else
            {
                MessageBox.Show("Lütfen silinecek ürünü ve masayı seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void DeleteOrderItem(int masaID, int urunID, int Adet)
        {
            string query = "DELETE FROM Siparisler WHERE MasaID = @MasaID AND UrunID = @UrunID AND Adet = @Adet AND SiparisID = @SiparisID ";

            using (SqlConnection connection = new SqlConnection("server=DESKTOP-SERKAN; Initial Catalog=kafe;Integrated Security=SSPI"))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MasaID", masaID);
                    command.Parameters.AddWithValue("@UrunID", urunID);
                    command.Parameters.AddWithValue("@Adet", Adet);
                    command.Parameters.AddWithValue("@SiparisID", GetSiparisID(masaID, urunID, Adet));

                    connection.Open();
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Ürün siparişten silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Ürün siparişten silinemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    connection.Close();
                }
            }
        }
        public int GetSiparisID(int masaID, int urunID, int adet)
        {
            int siparisID = -1; // Varsayılan olarak -1, böylece bir hata durumunda geri dönebiliriz
            string connectionString = "server=DESKTOP-SERKAN; Initial Catalog=kafe;Integrated Security=SSPI";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT SiparisID FROM Siparisler WHERE MasaID = @MasaID AND UrunID = @UrunID AND Adet = @Adet";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@MasaID", masaID);
                        cmd.Parameters.AddWithValue("@UrunID", urunID);
                        cmd.Parameters.AddWithValue("@Adet", adet);

                        SqlDataReader rdr = cmd.ExecuteReader();

                        if (rdr.Read())
                        {
                            siparisID = Convert.ToInt32(rdr["SiparisID"]);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Hata durumunda burada işlenebilir
                    MessageBox.Show("Sipariş ID'si alınırken bir hata oluştu: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }

            return siparisID;
        }

        public int GetSelectedUrunID(string urunAdi)
        {
            int urunID = -1;
            string query = "SELECT UrunID FROM Urunler WHERE UrunAdi = @UrunAdi";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UrunAdi", urunAdi);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        urunID = Convert.ToInt32(reader["UrunID"]);
                    }

                    reader.Close();
                }
            }

            return urunID;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            masatasi masatasi = new masatasi();
            masatasi.Show();
            MessageBox.Show("Değiştirmek istediğiniz masayı seçin!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (adisyon.SelectedItems.Count > 0)
            {
                ListViewItem selected = adisyon.SelectedItems[0];
                int adet = int.Parse(selected.SubItems[0].Text);
                if (adet > 1)
                {
                    adet--;
                    selected.SubItems[0].Text = adet.ToString();
                }
                else
                {
                    MessageBox.Show("Ürünü adet 0 olamaz.Ürünü iptal etmeniz gerekiyor...");
                }
            }
        }
        List<Siparis> masaninSiparisleri = new List<Siparis>();
        private string connectionString = "server=DESKTOP-SERKAN; Initial Catalog=kafe;Integrated Security=SSPI";
        private void button12_Click(object sender, EventArgs e)
        {
            SiparisiKaydet(GetMasaID(SecilenMasaAdi));
            MasaninSiparisleriniGoster(GetMasaID(SecilenMasaAdi));


        }

        public void MasaninSiparisleriniGoster(int masaID)
        {
            adisyon.Items.Clear(); // ListView'i temizle

            using (SqlConnection con = new SqlConnection("server=DESKTOP-SERKAN; Initial Catalog=kafe;Integrated Security=SSPI"))
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("SELECT UrunID, Adet FROM Siparisler WHERE MasaID = @MasaID", con);
                    cmd.Parameters.AddWithValue("@MasaID", masaID);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        int urunID = Convert.ToInt32(reader["UrunID"]);
                        string urunAdi = GetUrunAdi(urunID);// Ürün ID'sine göre adı al

                        int adet = Convert.ToInt32(reader["Adet"]);
                        decimal urunfiyat = GetUrunFiyati(urunID) * adet;

                        ListViewItem listViewItem = new ListViewItem(adet.ToString());
                        listViewItem.SubItems.Add(urunAdi.ToString());
                        listViewItem.SubItems.Add(urunfiyat.ToString());

                        adisyon.Items.Add(listViewItem);
                    }

                    reader.Close();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Siparişler çekilirken bir hata oluştu: " + ex.Message);
                }
            }
        }
        // Ürün ID'ye göre ürün fiyatını döndüren fonksiyon
        public decimal GetUrunFiyati(int urunID)
        {
            decimal fiyat = 0; // Eğer ürün bulunamazsa 0 döndürülecek

            using (SqlConnection con = new SqlConnection("server=DESKTOP-SERKAN; Initial Catalog=kafe;Integrated Security=SSPI"))
            {
                string query = "SELECT Fiyat FROM Urunler WHERE UrunID = @UrunID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@UrunID", urunID);

                    con.Open();
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        fiyat = Convert.ToDecimal(result);
                    }
                }
            }

            return fiyat;
        }
        // Ürün ID'ye göre ürün adını döndüren fonksiyon
        public string GetUrunAdi(int urunID)
        {
            string urunAdi = null; // Eğer ürün bulunamazsa null döndürülecek

            using (SqlConnection con = new SqlConnection("server=DESKTOP-SERKAN; Initial Catalog=kafe;Integrated Security=SSPI"))
            {
                string query = "SELECT UrunAdi FROM Urunler WHERE UrunID = @UrunID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@UrunID", urunID);

                    con.Open();
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        urunAdi = result.ToString();
                    }
                }
            }

            return urunAdi;
        }

        private void SiparisiKaydet(int masaID)
        {
            SqlConnection con = new SqlConnection("server=DESKTOP-SERKAN; Initial Catalog=kafe;Integrated Security=SSPI");
            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    foreach (ListViewItem item in adisyon.Items)
                    {
                        string urunAdi = item.SubItems[1].Text; // Ürün adını al
                        int adet = Convert.ToInt32(item.SubItems[0].Text); // Adeti al

                        using (SqlCommand cmd = new SqlCommand("INSERT INTO Siparisler (MasaID, UrunID, Adet, SiparisTarihi, SiparisDurumu, OdemeDurumu, ToplamFiyat) VALUES (@MasaID, @UrunID, @Adet, @SiparisTarihi, @SiparisDurumu, @OdemeDurumu, @ToplamFiyat)", con))
                        {
                            cmd.Parameters.AddWithValue("@MasaID", masaID);
                            cmd.Parameters.AddWithValue("@UrunID", GetUrunID(urunAdi)); // Ürün adına göre ID al
                            cmd.Parameters.AddWithValue("@Adet", adet);
                            cmd.Parameters.AddWithValue("@SiparisTarihi", DateTime.Now);
                            cmd.Parameters.AddWithValue("@SiparisDurumu", "Hazırlanıyor");
                            cmd.Parameters.AddWithValue("@OdemeDurumu", "Beklemede");
                            cmd.Parameters.AddWithValue("@ToplamFiyat", ToplamFiyatiHesapla()); // Toplam fiyatı hesapla

                            cmd.ExecuteNonQuery();
                        }
                    }

                    if (Application.OpenForms["masalar"] != null)
                    {
                        masalar anaForm = (masalar)Application.OpenForms["masalar"];
                        anaForm.MasaSiparisiKontrolEtVeRenkGuncelle(GetMasaID(SecilenMasaAdi));
                    }

                    MessageBox.Show("Sipariş başarıyla kaydedildi.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Bağlantı açılmadı. Lütfen bağlantı ayarlarını kontrol edin.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sipariş kaydedilirken bir hata oluştu: " + ex.Message + "\n" + ex.StackTrace);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Bağlantı zaten kapalı.");
                }
            }
        }
        private void UrunIptal(int siparisID, int urunID)
        {
            using (SqlConnection con = new SqlConnection("server=DESKTOP-SERKAN; Initial Catalog=kafe;Integrated Security=SSPI"))
            {
                try
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("DELETE FROM Siparisler WHERE SiparisID = @SiparisID AND UrunID = @UrunID", con))
                    {
                        cmd.Parameters.AddWithValue("@SiparisID", siparisID);
                        cmd.Parameters.AddWithValue("@UrunID", urunID);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Ürün siparişten başarıyla iptal edildi.");
                        }
                        else
                        {
                            MessageBox.Show("İptal edilecek ürün bulunamadı.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ürün iptal edilirken bir hata oluştu: " + ex.Message);
                }
            }
        }
        private int GetMasaIDFromSiparisID(int siparisID)
        {
            using (SqlConnection con = new SqlConnection("server=DESKTOP-SERKAN; Initial Catalog=kafe;Integrated Security=SSPI"))
            {
                try
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT MasaID FROM Siparisler WHERE SiparisID = @SiparisID", con))
                    {
                        cmd.Parameters.AddWithValue("@SiparisID", siparisID);

                        object result = cmd.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int masaID))
                        {
                            return masaID;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }

            return -1; // MasaID bulunamadı
        }
        private decimal ToplamFiyatiHesapla()
        {
            // Toplam fiyat hesaplama mantığını burada uygulayın.
            // Bu, ürünlerin adetleri ve fiyatları üzerinden hesaplanabilir.
            decimal toplamFiyat = 0;

            foreach (ListViewItem item in adisyon.Items)
            {
                int adet = Convert.ToInt32(item.SubItems[0].Text);
                decimal fiyat = Convert.ToDecimal(item.SubItems[2].Text); // Ürün fiyatını al
                toplamFiyat += adet * fiyat;
            }

            return toplamFiyat;
        }
        public void MasaninSiparisleriniListVieweEkle()
        {
            // ListView'i temizle
            adisyon.Items.Clear();

            foreach (Siparis siparis in masaninSiparisleri)
            {
                ListViewItem item = new ListViewItem(siparis.Adet.ToString());
                item.SubItems.Add(siparis.UrunAdi.ToString());
                item.SubItems.Add(siparis.Fiyat.ToString());
                adisyon.Items.Add(item);
            }
        }
        public class Siparis
        {
            public int UrunID { get; set; }
            public int Adet { get; set; }
            public int SiparisID { get; set; }
            public decimal ToplamFiyat { get; set; }
            public decimal Fiyat { get; set; }
            public string UrunAdi { get; set; }

        }

        private void adisyon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {


            // Seçilen masanın ID'sini al
            int masaID = GetMasaID(SecilenMasaAdi);


            // Hesap ödeme formunu oluştur
            hesapode hesapode = new hesapode();
            hesapode.masaID = masaID;
            hesapode.SecilenMasaAdi = SecilenMasaAdi;

            // Seçilen masaya ait siparişleri al
            List<Siparis> siparisler = GetSiparislerByMasaID(GetMasaID(SecilenMasaAdi)); // Bu metodun gerçek implementasyonu sizin veritabanından siparişleri çekmenizi sağlamalı

            // Hesap ödeme formundaki ListView'e siparişleri ekle
            foreach (var siparis in siparisler)
            {
                ListViewItem item = new ListViewItem(siparis.Adet.ToString());
                item.SubItems.Add(siparis.UrunAdi.ToString());
                item.SubItems.Add(siparis.Fiyat.ToString()); // Para birimi formatıyla fiyatı göstermek için
                item.Tag = siparis; // Sipariş nesnesini ListViewItem'a iliştirebilirsiniz
                hesapode.listView1.Items.Add(item);
            }

            // Hesap ödeme formunu göster
            hesapode.ShowDialog();

        }


        // MasaID'sine göre siparişleri getiren metod
        public List<Siparis> GetSiparislerByMasaID(int masaID)
        {
            List<Siparis> siparisler = new List<Siparis>();

            // Veritabanına bağlanma ve sorgu işlemleri gerçekleştirilir
            using (SqlConnection con = new SqlConnection("server=DESKTOP-SERKAN; Initial Catalog=kafe;Integrated Security=SSPI")) // Bağlantı dizgesi uygun şekilde değiştirilmelidir
            {
                con.Open();

                // Veritabanından siparişleri çeken sorgu
                string query = "SELECT UrunID, Adet, ToplamFiyat FROM Siparisler WHERE MasaID = @MasaID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@MasaID", masaID);

                // Sorguyu çalıştır ve verileri oku
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Verileri okuyarak Siparis nesnelerini oluştur ve listeye ekle
                        Siparis siparis = new Siparis
                        {
                            Adet = Convert.ToInt32(reader["Adet"]),
                            UrunAdi = GetUrunAdi(Convert.ToInt16(reader["UrunID"])),

                            Fiyat = Convert.ToInt32(reader["Adet"])
                            * GetUrunFiyati(Convert.ToInt16(reader["UrunID"])),
                        };
                        siparisler.Add(siparis);
                    }
                }
            }

            return siparisler;
        }
        public class Urun
        {
            public int UrunID { get; set; }
            public string UrunAdi { get; set; }
            public decimal Fiyat { get; set; }
        }

        public class UrunService
        {
            private string connectionString;

            public UrunService(string connectionString)
            {
                this.connectionString = connectionString;
            }


        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

