using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace kafe_adisyon_uygulaması
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            
            ApplicationConfiguration.Initialize();
            Application.Run(new giris_sayfasi());
        }
    }
   

}