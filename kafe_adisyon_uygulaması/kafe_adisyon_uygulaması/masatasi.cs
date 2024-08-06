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
    public partial class masatasi : Form
    {
        public masatasi()
        {
            InitializeComponent();
            LoadMasalar();
        }

        private void masatasi_Load(object sender, EventArgs e)
        {

        }
        private void LoadMasalar()
        {
            using (SqlConnection con = new SqlConnection("server=DESKTOP-SERKAN; Initial Catalog=kafe;Integrated Security=SSPI"))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT MasaID, MasaAdi FROM Masa", con))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int masaID = reader.GetInt32(0);
                                string masaAdi = reader.GetString(1);

                                cmbKaynakMasa.Items.Add(new ComboBoxItem(masaID, masaAdi));
                                cmbHedefMasa.Items.Add(new ComboBoxItem(masaID, masaAdi));
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Masalar yüklenirken bir hata oluştu: " + ex.Message);
                }
                con.Close();
            }
        }

        private void btnMasayiTasi_Click(object sender, EventArgs e)
        {
            if (cmbKaynakMasa.SelectedItem != null && cmbHedefMasa.SelectedItem != null)
            {
                ComboBoxItem kaynakItem = (ComboBoxItem)cmbKaynakMasa.SelectedItem;
                ComboBoxItem hedefItem = (ComboBoxItem)cmbHedefMasa.SelectedItem;

                MasayiTasi(kaynakItem.Id, hedefItem.Id);
            }
            else
            {
                MessageBox.Show("Lütfen kaynak ve hedef masaları seçiniz.");
            }
        }
        private void MasayiTasi(int kaynakMasaID, int hedefMasaID)
        {
            using (SqlConnection con = new SqlConnection("server=DESKTOP-SERKAN; Initial Catalog=kafe;Integrated Security=SSPI"))
            {
                try
                {
                    con.Open();

                    using (SqlTransaction transaction = con.BeginTransaction())
                    {
                        try
                        {
                            using (SqlCommand cmd = new SqlCommand("UPDATE Siparisler SET MasaID = @HedefMasaID WHERE MasaID = @KaynakMasaID", con, transaction))
                            {
                                cmd.Parameters.AddWithValue("@HedefMasaID", hedefMasaID);
                                cmd.Parameters.AddWithValue("@KaynakMasaID", kaynakMasaID);

                                int affectedRows = cmd.ExecuteNonQuery();
                                if (affectedRows > 0)
                                {
                                    transaction.Commit();
                                    MessageBox.Show("Masa başarıyla taşındı.");
                                    this.Close();
                                }
                                else
                                {
                                    transaction.Rollback();
                                    MessageBox.Show("Taşıma işlemi sırasında bir hata oluştu. İşlem geri alındı.");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Hata: " + ex.Message + "\n" + ex.StackTrace);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bağlantı açma sırasında bir hata oluştu: " + ex.Message + "\n" + ex.StackTrace);
                }
            }
        }
    
    }
    public class ComboBoxItem
    {
        public int Id { get; }
        public string Name { get; }

        public ComboBoxItem(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}


