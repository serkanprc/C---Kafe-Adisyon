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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kafe_adisyon_uygulaması
{
    public partial class admin_panel : Form
    {
        public admin_panel()
        {
            InitializeComponent();
        }

        private void admin_panel_Load(object sender, EventArgs e)
        {


            SqlConnection con;
            void griddoldur()
            {
                try
                {

                    con = new SqlConnection("server=DESKTOP-SERKAN; Initial Catalog=kafe;Integrated Security=SSPI");

                    con.Open();
                    SqlCommand cmd = new SqlCommand("Select * from Siparisler", con);
                    SqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {

                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }




            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            masalar frm = new masalar();
            frm.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ürünekle ürünekle = new ürünekle();
            ürünekle.Show();
        }
    }
}
