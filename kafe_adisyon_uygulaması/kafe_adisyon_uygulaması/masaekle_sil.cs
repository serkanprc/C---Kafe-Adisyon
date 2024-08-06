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
    public partial class masaekle_sil : Form
    {
        public masaekle_sil()
        {
            InitializeComponent();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            string masaAdi = txtmasaadı.Text;
            int masaID;

            if (!int.TryParse(txtmasaid.Text, out masaID))
            {
                MessageBox.Show("Lütfen geçerli bir Masa ID'si girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MasaEkleVeritabani(masaAdi, masaID);
            masalar masalar =new masalar();
            Button btn = new Button();
            btn.Text = masaAdi;
            btn.Tag = masaID;
            btn.Width = 150;
            btn.Height = 50;
            btn.Click += MasaButon_Click;
            masalar.flowLayoutPanel1.Controls.Add(btn);

            MessageBox.Show("Masa başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
        }
        private void MasaEkleVeritabani(string masaAdi, int masaID)
        {
            string query = "INSERT INTO Masa (MasaID, MasaAdi, Durum) VALUES (@MasaID, @MasaAdi, 'BOŞ')";

            using (SqlConnection connection = new SqlConnection("server=DESKTOP-SERKAN; Initial Catalog=kafe;Integrated Security=SSPI"))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MasaID", masaID);
                    command.Parameters.AddWithValue("@MasaAdi", masaAdi);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        private void MasaButon_Click(object sender, EventArgs e)
        {
            // Tıklanan butonu al
            Button masaButton = (Button)sender;

            // Seçilen masa adını ve ID'sini butondan al
            string secilenMasaAdi = masaButton.Text;
            int secilenMasaID = (int)masaButton.Tag;

            // Adisyon ekleme formunu oluştur
            adisyonekleme adisyoneklemeForm = new adisyonekleme();
            adisyoneklemeForm.SMasaAdi = secilenMasaAdi; // Masa adını form özelliğine ata
            adisyoneklemeForm.SecilenMasaID = secilenMasaID; // Masa ID'sini form özelliğine ata

            // Masanın siparişlerini göster
            adisyoneklemeForm.MasaninSiparisleriniGoster(secilenMasaID);

            // Adisyon ekleme formunu göster
            adisyoneklemeForm.Show();
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
        private void MasaEklemeFormu_Load(object sender, EventArgs e)
        {
            LoadMasalar();
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
                        masalar masalar = new masalar();
                        Button btn = new Button();
                        btn.Text = reader["MasaAdi"].ToString();
                        btn.Tag = (int)reader["MasaID"];
                        btn.Width = 150;
                        btn.Height = 50;
                        btn.Click += MasaButon_Click;
                        masalar.flowLayoutPanel1.Controls.Add(btn);
                    }
                    connection.Close();
                }
            }
        }
    }
}
