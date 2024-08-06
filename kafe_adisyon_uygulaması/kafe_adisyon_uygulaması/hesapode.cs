using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace kafe_adisyon_uygulaması
{
    public partial class hesapode : Form
    {
        public hesapode()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            listView1 = new ListView();
            adet = new ColumnHeader();
            urunadi = new ColumnHeader();
            fiyat = new ColumnHeader();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Activation = ItemActivation.OneClick;
            listView1.Columns.AddRange(new ColumnHeader[] { adet, urunadi, fiyat });
            listView1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView1.Location = new Point(341, 141);
            listView1.Name = "listView1";
            listView1.Size = new Size(447, 597);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // adet
            // 
            adet.Text = "Adet";
            adet.Width = 150;
            // 
            // urunadi
            // 
            urunadi.Text = "Ürün Adı";
            urunadi.Width = 150;
            // 
            // fiyat
            // 
            fiyat.Text = "Fiyat";
            fiyat.Width = 120;
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(852, 205);
            button1.Name = "button1";
            button1.Size = new Size(245, 131);
            button1.TabIndex = 1;
            button1.Text = "NAKİT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DeepSkyBlue;
            button2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.Location = new Point(852, 382);
            button2.Name = "button2";
            button2.Size = new Size(245, 131);
            button2.TabIndex = 2;
            button2.Text = "KREDİ KARTI";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DeepSkyBlue;
            button3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button3.Location = new Point(852, 550);
            button3.Name = "button3";
            button3.Size = new Size(245, 131);
            button3.TabIndex = 3;
            button3.Text = "YEMEK KARTI";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 34F);
            label1.Location = new Point(1350, 38);
            label1.Name = "label1";
            label1.Size = new Size(0, 62);
            label1.TabIndex = 4;
            // 
            // hesapode
            // 
            ClientSize = new Size(1924, 1061);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listView1);
            Name = "hesapode";
            Load += hesapode_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private ColumnHeader adet;
        private ColumnHeader urunadi;
        private ColumnHeader fiyat;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        public ListView listView1;
        public int masaID;
        public string SecilenMasaAdi;

        private void hesapode_Load(object sender, EventArgs e)
        {
            //ListViewDoldur();
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Seçili ürünlerin toplam fiyatını hesaplayın
            decimal toplamFiyat = 0;

            foreach (ListViewItem item in listView1.SelectedItems)
            {
                int adet = Convert.ToInt16(item.SubItems[0].Text);
                decimal fiyat = Convert.ToDecimal(item.SubItems[2].Text);
                toplamFiyat += adet * fiyat;
            }

            // Toplam fiyatı Label'a yazdırın
            label1.Text = "Toplam Fiyat: " + toplamFiyat.ToString("C");
        }
        adisyonekleme adisyon = new adisyonekleme();
  
        private void OdemeYap()
        {
            adisyonekleme adisyon = new adisyonekleme();
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Lütfen ödeme yapmak için ürün seçin.");
                return;
            }

            List<int> urunIDleri = new List<int>();

            foreach (ListViewItem item in listView1.SelectedItems)
            {
                int urunID = adisyon.GetUrunID(item.SubItems[1].Text); // Ürün adından Ürün ID'yi alın
                urunIDleri.Add(urunID);
            }
            // Seçilen ürünü ve masayı kontrol et
            if (listView1.SelectedItems.Count > 0)
            {
                // Seçilen masanın ID'sini al
                int masaID = adisyon.GetMasaID(SecilenMasaAdi);

                // Seçilen her bir ürünü işle
                foreach (ListViewItem selectedItem in listView1.SelectedItems)
                {
                 
                    int adet = Convert.ToInt32(selectedItem.SubItems[0].Text);
                    int urunID = adisyon.GetSelectedUrunID(selectedItem.SubItems[1].Text);

                    // Siparişi veritabanından sil
                    adisyon.DeleteOrderItem(masaID, urunID, adet);

                    // ListView'den seçilen ürünü kaldır
                    selectedItem.Remove();
                ;
                }
                //UrunleriSil(urunIDleri, masaID);
                //ListViewSeciliUrunleriSil();

                MessageBox.Show("Seçili ürünler başarıyla ödendi ve silindi.");
                if (listView1.Items.Count == 0)
                {
                    this.Close();
                }
            }
        }
        private void UrunleriSil(List<int> urunIDleri, int masaID)
        {
            string connectionString = "server=DESKTOP-SERKAN; Initial Catalog=kafe;Integrated Security=SSPI";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                foreach (int urunID in urunIDleri)
                {
                    string query = "DELETE FROM Siparisler WHERE UrunID = @UrunID AND MasaID = @MasaID";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@UrunID", urunID);
                        cmd.Parameters.AddWithValue("@MasaID", masaID);
                        cmd.ExecuteNonQuery();
                    }
                }

                con.Close();
            }
        }
        private void ListViewSeciliUrunleriSil()
        {
            adisyonekleme adisyon = new adisyonekleme();
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                listView1.Items.Remove(item);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OdemeYap();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OdemeYap();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OdemeYap();
        }
    }
}
