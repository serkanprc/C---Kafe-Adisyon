using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kafe_adisyon_uygulaması
{
    public partial class masalar : Form
    {
        public masalar()
        {
            InitializeComponent();

        }


        private int GetMasaID(string masaAdi)
        {
            int masaID = -1; // Varsayılan olarak -1, böylece bir hata durumunda geri dönebiliriz
            SqlConnection con = new SqlConnection("server=DESKTOP-SERKAN; Initial Catalog=kafe;Integrated Security=SSPI");

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT MasaID FROM Masa WHERE MasaAdi = @MasaAdi", con);
                cmd.Parameters.AddWithValue("@MasaAdi", masaAdi);
                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    masaID = Convert.ToInt32(rdr["MasaID"]);
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda burada işlenebilir
                MessageBox.Show("Masa ID'si alınırken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

            return masaID;
        }
        private List<Siparis> GetMasaninSiparisleri(string masaAdi)
        {
            List<Siparis> siparisler = new List<Siparis>();
            adisyonekleme adisyoneklemeForm = new adisyonekleme();
            adisyoneklemeForm.MasaninSiparisleriniGoster(GetMasaID(masaAdi));
            return siparisler;
        }
        public string SecilenMasaAdi { get; set; }
        public EventHandler MasaButon_Click { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {
            Button masaButton = (Button)sender;
            string secilenMasaAdi = masaButton.Text;
            adisyonekleme adisyoneklemeForm = new adisyonekleme();
            adisyoneklemeForm.SecilenMasaAdi = secilenMasaAdi;
            secilenMasaButonu = masaButton;
            adisyoneklemeForm.MasaninSiparisleriniGoster(GetMasaID(secilenMasaAdi));
            adisyoneklemeForm.Show();


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Button masaButton = (Button)sender;
            string secilenMasaAdi = masaButton.Text;
            secilenMasaButonu = masaButton;
            adisyonekleme adisyoneklemeForm = new adisyonekleme();
            adisyoneklemeForm.SecilenMasaAdi = secilenMasaAdi;
            adisyoneklemeForm.MasaninSiparisleriniGoster(GetMasaID(secilenMasaAdi));
            adisyoneklemeForm.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button masaButton = (Button)sender;
            string secilenMasaAdi = masaButton.Text;
            secilenMasaButonu = masaButton;
            adisyonekleme adisyoneklemeForm = new adisyonekleme();
            adisyoneklemeForm.SecilenMasaAdi = secilenMasaAdi;
            adisyoneklemeForm.MasaninSiparisleriniGoster(GetMasaID(secilenMasaAdi));
            adisyoneklemeForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Button masaButton = (Button)sender;
            string secilenMasaAdi = masaButton.Text;
            secilenMasaButonu = masaButton;
            adisyonekleme adisyoneklemeForm = new adisyonekleme();
            adisyoneklemeForm.SecilenMasaAdi = secilenMasaAdi;
            adisyoneklemeForm.MasaninSiparisleriniGoster(GetMasaID(secilenMasaAdi));
            adisyoneklemeForm.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {

            Button masaButton = (Button)sender;
            string secilenMasaAdi = masaButton.Text;
            secilenMasaButonu = masaButton;
            adisyonekleme adisyoneklemeForm = new adisyonekleme();
            adisyoneklemeForm.SecilenMasaAdi = secilenMasaAdi;
            adisyoneklemeForm.MasaninSiparisleriniGoster(GetMasaID(secilenMasaAdi));
            adisyoneklemeForm.Show();

        }

        private void button27_Click(object sender, EventArgs e)
        {

            Button masaButton = (Button)sender;
            string secilenMasaAdi = masaButton.Text;
            secilenMasaButonu = masaButton;
            adisyonekleme adisyoneklemeForm = new adisyonekleme();
            adisyoneklemeForm.SecilenMasaAdi = secilenMasaAdi;
            adisyoneklemeForm.MasaninSiparisleriniGoster(GetMasaID(secilenMasaAdi));
            adisyoneklemeForm.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {

            Button masaButton = (Button)sender;
            string secilenMasaAdi = masaButton.Text;
            secilenMasaButonu = masaButton;
            adisyonekleme adisyoneklemeForm = new adisyonekleme();
            adisyoneklemeForm.SecilenMasaAdi = secilenMasaAdi;
            adisyoneklemeForm.MasaninSiparisleriniGoster(GetMasaID(secilenMasaAdi));
            adisyoneklemeForm.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {

            Button masaButton = (Button)sender;
            string secilenMasaAdi = masaButton.Text;
            secilenMasaButonu = masaButton;
            adisyonekleme adisyoneklemeForm = new adisyonekleme();
            adisyoneklemeForm.SecilenMasaAdi = secilenMasaAdi;
            adisyoneklemeForm.MasaninSiparisleriniGoster(GetMasaID(secilenMasaAdi));
            adisyoneklemeForm.Show();

        }

        private void button9_Click(object sender, EventArgs e)
        {

            Button masaButton = (Button)sender;
            string secilenMasaAdi = masaButton.Text;
            secilenMasaButonu = masaButton;
            adisyonekleme adisyoneklemeForm = new adisyonekleme();
            adisyoneklemeForm.SecilenMasaAdi = secilenMasaAdi;
            adisyoneklemeForm.MasaninSiparisleriniGoster(GetMasaID(secilenMasaAdi));
            adisyoneklemeForm.Show();

        }

        private void button8_Click(object sender, EventArgs e)
        {

            Button masaButton = (Button)sender;
            string secilenMasaAdi = masaButton.Text;
            secilenMasaButonu = masaButton;
            adisyonekleme adisyoneklemeForm = new adisyonekleme();
            adisyoneklemeForm.SecilenMasaAdi = secilenMasaAdi;
            adisyoneklemeForm.MasaninSiparisleriniGoster(GetMasaID(secilenMasaAdi));
            adisyoneklemeForm.Show();

        }

        private void button10_Click(object sender, EventArgs e)
        {

            Button masaButton = (Button)sender;
            string secilenMasaAdi = masaButton.Text;
            secilenMasaButonu = masaButton;
            adisyonekleme adisyoneklemeForm = new adisyonekleme();
            adisyoneklemeForm.SecilenMasaAdi = secilenMasaAdi;
            adisyoneklemeForm.MasaninSiparisleriniGoster(GetMasaID(secilenMasaAdi));
            adisyoneklemeForm.Show();

        }

        private void button26_Click(object sender, EventArgs e)
        {

            Button masaButton = (Button)sender;
            secilenMasaButonu = masaButton;
            string secilenMasaAdi = masaButton.Text;
            adisyonekleme adisyoneklemeForm = new adisyonekleme();
            adisyoneklemeForm.SecilenMasaAdi = secilenMasaAdi;
            adisyoneklemeForm.MasaninSiparisleriniGoster(GetMasaID(secilenMasaAdi));
            adisyoneklemeForm.Show();

        }

        private void button11_Click(object sender, EventArgs e)
        {

            Button masaButton = (Button)sender;
            secilenMasaButonu = masaButton;
            string secilenMasaAdi = masaButton.Text;
            adisyonekleme adisyoneklemeForm = new adisyonekleme();
            adisyoneklemeForm.SecilenMasaAdi = secilenMasaAdi;
            adisyoneklemeForm.MasaninSiparisleriniGoster(GetMasaID(secilenMasaAdi));
            adisyoneklemeForm.Show();

        }

        private void button13_Click(object sender, EventArgs e)
        {

            Button masaButton = (Button)sender;
            secilenMasaButonu = masaButton;
            string secilenMasaAdi = masaButton.Text;
            adisyonekleme adisyoneklemeForm = new adisyonekleme();
            adisyoneklemeForm.SecilenMasaAdi = secilenMasaAdi;
            adisyoneklemeForm.MasaninSiparisleriniGoster(GetMasaID(secilenMasaAdi));
            adisyoneklemeForm.Show();

        }

        private void button12_Click(object sender, EventArgs e)
        {

            Button masaButton = (Button)sender;
            secilenMasaButonu = masaButton;
            string secilenMasaAdi = masaButton.Text;
            adisyonekleme adisyoneklemeForm = new adisyonekleme();
            adisyoneklemeForm.SecilenMasaAdi = secilenMasaAdi;
            adisyoneklemeForm.MasaninSiparisleriniGoster(GetMasaID(secilenMasaAdi));
            adisyoneklemeForm.Show();

        }

        private void button19_Click(object sender, EventArgs e)
        {

            Button masaButton = (Button)sender;
            secilenMasaButonu = masaButton;
            string secilenMasaAdi = masaButton.Text;
            adisyonekleme adisyoneklemeForm = new adisyonekleme();
            adisyoneklemeForm.SecilenMasaAdi = secilenMasaAdi;
            adisyoneklemeForm.MasaninSiparisleriniGoster(GetMasaID(secilenMasaAdi));
            adisyoneklemeForm.Show();

        }

        private void button20_Click(object sender, EventArgs e)
        {

            Button masaButton = (Button)sender;
            secilenMasaButonu = masaButton;
            string secilenMasaAdi = masaButton.Text;
            adisyonekleme adisyoneklemeForm = new adisyonekleme();
            adisyoneklemeForm.SecilenMasaAdi = secilenMasaAdi;
            adisyoneklemeForm.MasaninSiparisleriniGoster(GetMasaID(secilenMasaAdi));
            adisyoneklemeForm.Show();

        }

        private void button25_Click(object sender, EventArgs e)
        {

            Button masaButton = (Button)sender;
            secilenMasaButonu = masaButton;
            string secilenMasaAdi = masaButton.Text;
            adisyonekleme adisyoneklemeForm = new adisyonekleme();
            adisyoneklemeForm.SecilenMasaAdi = secilenMasaAdi;
            adisyoneklemeForm.MasaninSiparisleriniGoster(GetMasaID(secilenMasaAdi));
            adisyoneklemeForm.Show();

        }

        private void button14_Click(object sender, EventArgs e)
        {

            Button masaButton = (Button)sender;
            secilenMasaButonu = masaButton;
            string secilenMasaAdi = masaButton.Text;
            adisyonekleme adisyoneklemeForm = new adisyonekleme();
            adisyoneklemeForm.SecilenMasaAdi = secilenMasaAdi;
            adisyoneklemeForm.MasaninSiparisleriniGoster(GetMasaID(secilenMasaAdi));
            adisyoneklemeForm.Show();

        }

        private void button15_Click(object sender, EventArgs e)
        {

            Button masaButton = (Button)sender;
            secilenMasaButonu = masaButton;
            string secilenMasaAdi = masaButton.Text;
            adisyonekleme adisyoneklemeForm = new adisyonekleme();
            adisyoneklemeForm.SecilenMasaAdi = secilenMasaAdi;
            adisyoneklemeForm.MasaninSiparisleriniGoster(GetMasaID(secilenMasaAdi));
            adisyoneklemeForm.Show();

        }

        private void button16_Click(object sender, EventArgs e)
        {

            Button masaButton = (Button)sender;
            secilenMasaButonu = masaButton;
            string secilenMasaAdi = masaButton.Text;
            adisyonekleme adisyoneklemeForm = new adisyonekleme();
            adisyoneklemeForm.SecilenMasaAdi = secilenMasaAdi;
            adisyoneklemeForm.MasaninSiparisleriniGoster(GetMasaID(secilenMasaAdi));
            adisyoneklemeForm.Show();

        }

        private void button17_Click(object sender, EventArgs e)
        {

            Button masaButton = (Button)sender;
            secilenMasaButonu = masaButton;
            string secilenMasaAdi = masaButton.Text;
            adisyonekleme adisyoneklemeForm = new adisyonekleme();
            adisyoneklemeForm.SecilenMasaAdi = secilenMasaAdi;
            adisyoneklemeForm.MasaninSiparisleriniGoster(GetMasaID(secilenMasaAdi));
            adisyoneklemeForm.Show();

        }

        private void button18_Click(object sender, EventArgs e)
        {

            Button masaButton = (Button)sender;
            secilenMasaButonu = masaButton;
            string secilenMasaAdi = masaButton.Text;
            adisyonekleme adisyoneklemeForm = new adisyonekleme();
            adisyoneklemeForm.SecilenMasaAdi = secilenMasaAdi;
            adisyoneklemeForm.MasaninSiparisleriniGoster(GetMasaID(secilenMasaAdi));
            adisyoneklemeForm.Show();

        }

        private void button24_Click(object sender, EventArgs e)
        {

            Button masaButton = (Button)sender;
            secilenMasaButonu = masaButton;
            string secilenMasaAdi = masaButton.Text;
            adisyonekleme adisyoneklemeForm = new adisyonekleme();
            adisyoneklemeForm.SecilenMasaAdi = secilenMasaAdi;
            adisyoneklemeForm.MasaninSiparisleriniGoster(GetMasaID(secilenMasaAdi));
            adisyoneklemeForm.Show();

        }

        private void button31_Click(object sender, EventArgs e)
        {

            Button masaButton = (Button)sender;
            secilenMasaButonu = masaButton;
            string secilenMasaAdi = masaButton.Text;
            adisyonekleme adisyoneklemeForm = new adisyonekleme();
            adisyoneklemeForm.SecilenMasaAdi = secilenMasaAdi;
            adisyoneklemeForm.MasaninSiparisleriniGoster(GetMasaID(secilenMasaAdi));
            adisyoneklemeForm.Show();

        }

        private void button30_Click(object sender, EventArgs e)
        {

            Button masaButton = (Button)sender;
            secilenMasaButonu = masaButton;
            string secilenMasaAdi = masaButton.Text;
            adisyonekleme adisyoneklemeForm = new adisyonekleme();
            adisyoneklemeForm.SecilenMasaAdi = secilenMasaAdi;
            adisyoneklemeForm.MasaninSiparisleriniGoster(GetMasaID(secilenMasaAdi));
            adisyoneklemeForm.Show();

        }

        private void button23_Click(object sender, EventArgs e)
        {

            Button masaButton = (Button)sender;
            secilenMasaButonu = masaButton;
            string secilenMasaAdi = masaButton.Text;
            adisyonekleme adisyoneklemeForm = new adisyonekleme();
            adisyoneklemeForm.SecilenMasaAdi = secilenMasaAdi;
            adisyoneklemeForm.MasaninSiparisleriniGoster(GetMasaID(secilenMasaAdi));
            adisyoneklemeForm.Show();

        }

        private void button22_Click(object sender, EventArgs e)
        {

            Button masaButton = (Button)sender;
            secilenMasaButonu = masaButton;
            string secilenMasaAdi = masaButton.Text;
            adisyonekleme adisyoneklemeForm = new adisyonekleme();
            adisyoneklemeForm.SecilenMasaAdi = secilenMasaAdi;
            adisyoneklemeForm.MasaninSiparisleriniGoster(GetMasaID(secilenMasaAdi));
            adisyoneklemeForm.Show();

        }

        private void button21_Click(object sender, EventArgs e)
        {

            Button masaButton = (Button)sender;
            secilenMasaButonu = masaButton;
            string secilenMasaAdi = masaButton.Text;
            adisyonekleme adisyoneklemeForm = new adisyonekleme();
            adisyoneklemeForm.SecilenMasaAdi = secilenMasaAdi;
            adisyoneklemeForm.MasaninSiparisleriniGoster(GetMasaID(secilenMasaAdi));
            adisyoneklemeForm.Show();

        }

        private void button29_Click(object sender, EventArgs e)
        {

            Button masaButton = (Button)sender;
            secilenMasaButonu = masaButton;
            string secilenMasaAdi = masaButton.Text;
            adisyonekleme adisyoneklemeForm = new adisyonekleme();
            adisyoneklemeForm.SecilenMasaAdi = secilenMasaAdi;
            adisyoneklemeForm.MasaninSiparisleriniGoster(GetMasaID(secilenMasaAdi));
            adisyoneklemeForm.Show();

        }

        private void masalar_Load(object sender, EventArgs e)
        {
            masaButonlari = new Button[] { B1, B2, B3, B4, B5, B6, B7, B8, B9,
                B10, B11, B12, B13, B14, B15, B16, B17, B18, B19, B20, B21,
                B22, B23, B24, B25, B26, B27, B28, B29, B30 }; // Masalarınızı temsil eden butonları ekleyin.
            CheckMasaSiparisDurumu();

            SqlConnection con = new SqlConnection("server=DESKTOP-SERKAN; Initial Catalog=kafe;Integrated Security=SSPI");
            SqlCommand cmd = new SqlCommand("SELECT MasaAdi FROM Masa", con);

            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                string masaAdi = rdr["MasaAdi"].ToString();

            }
            con.Close();
            con.Open();

            foreach (Control control in this.Controls)
            {
                if (control is Button button && button.Name.StartsWith("button"))
                {
                    string masaAdi = button.Text;
                    int masaID = GetMasaID(masaAdi);

                    if (masaID != -1)
                    {
                        // MasaID'ye göre sipariş sayısını kontrol et
                        SqlCommand cmd1 = new SqlCommand("SELECT COUNT(*) FROM Siparisler WHERE MasaID = @MasaID", con);
                        cmd1.Parameters.AddWithValue("@MasaID", masaID);

                        int siparisSayisi = (int)cmd1.ExecuteScalar();

                        if (siparisSayisi > 0)
                        {
                            button.BackColor = Color.Orange;
                        }
                        else
                        {
                            button.BackColor = SystemColors.Control;
                        }
                    }
                }
            }
            con.Close();

        }

        public Button secilenMasaButonu;
        public void SecilenMasaButonununRenginiDegistir()
        {
            if (secilenMasaButonu != null)
            {
                secilenMasaButonu.BackColor = Color.Orange;
            }
        }
        private Button[] masaButonlari;




        public void CheckMasaSiparisDurumu()
        {
            string connectionString = "server=DESKTOP-SERKAN; Initial Catalog=kafe;Integrated Security=SSPI"; // Veritabanı bağlantı dizesi
            string query = "SELECT DISTINCT MasaID FROM Siparisler";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    // Sipariş olan masaları listeye ekle
                    List<int> siparisOlanMasalar = new List<int>();
                    while (reader.Read())
                    {
                        siparisOlanMasalar.Add(Convert.ToInt32(reader["MasaID"]));
                    }
                    reader.Close();

                    // Her masayı kontrol et ve renklerini ayarla
                    for (int i = 0; i < masaButonlari.Length; i++)
                    {
                        int masaID = i + 1; // MasaID'lerin 1'den başladığını varsayıyoruz.
                        if (siparisOlanMasalar.Contains(masaID))
                        {
                            masaButonlari[i].BackColor = Color.Orange;
                        }
                        else
                        {
                            masaButonlari[i].BackColor = Color.White;
                        }

                    }
                    connection.Close();
                }
            }
        }
        public void MasaSiparisiKontrolEtVeRenkGuncelle(int masaID)
        {
            using (SqlConnection con = new SqlConnection("server=DESKTOP-SERKAN; Initial Catalog=kafe;Integrated Security=SSPI"))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Siparisler WHERE MasaID = @MasaID", con);
                cmd.Parameters.AddWithValue("@MasaID", masaID);

                int siparisSayisi = (int)cmd.ExecuteScalar();

                foreach (Control control in this.Controls)
                {
                    if (control is Button button && button.Text == GetMasaAdi(masaID))
                    {
                        if (siparisSayisi > 0)
                        {
                            button.BackColor = Color.Orange;
                        }
                        else
                        {
                            button.BackColor = SystemColors.Control;
                        }
                        break;
                    }
                }
                con.Close();
            }
        }

        private string GetMasaAdi(int masaID)
        {
            using (SqlConnection con = new SqlConnection("server=DESKTOP-SERKAN; Initial Catalog=kafe;Integrated Security=SSPI"))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT MasaAdi FROM Masa WHERE MasaID = @MasaID", con);
                cmd.Parameters.AddWithValue("@MasaID", masaID);

                return (string)cmd.ExecuteScalar();
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            CheckMasaSiparisDurumu();
            LoadMasalar();

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            masaekle_sil masaekle_Sil = new masaekle_sil();
            masaekle_Sil.Show();
        }

        private void LoadMasalar()
        {
            string query = "SELECT MasaID, MasaAdi FROM Masa";

            using (SqlConnection connection = new SqlConnection("server=DESKTOP-SERKAN; Initial Catalog=kafe;Integrated Security=SSPI"))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Button btn = new Button();
                        btn.Text = reader["MasaAdi"].ToString();
                        btn.Tag = (int)reader["MasaID"];
                        btn.Width = 150;
                        btn.Height = 50;
                        btn.Click += MasaButon_Click;
                        flowLayoutPanel1.Controls.Add(btn);
                    }
                    connection.Close();
                }
            }
        }

    }

}


// Ürün sınıfı tanımı
public class Urun
{
    public string Ad { get; set; }
    public double Fiyat { get; set; }
}

// Masa sınıfı tanımı
public class Masa
{
    public int MasaNo { get; set; }
    public List<Urun> Adisyon { get; set; }

    public Masa(int masaNo)
    {
        MasaNo = masaNo;
        Adisyon = new List<Urun>();
    }

    // Ürün ekleme metodu
    public void UrunEkle(Urun urun)
    {
        Adisyon.Add(urun);
        Console.WriteLine($"{urun.Ad} adlı ürün masaya eklendi.");
    }
}

