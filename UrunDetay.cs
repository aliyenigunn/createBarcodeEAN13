using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Ecka.EMS.Desktop.Pazarlama.Barcode
{
    public partial class UrunDetay : Form
    {
        public static string stokKod { get; set; }
        public static string stokAd { get; set; }
        public static string birim { get; set; }
        public static string barkod { get; set; }
        
        public UrunDetay()
        {
            InitializeComponent();
        }

        private void UrunDetay_Load(object sender, EventArgs e)
        {
            string Barrcode;
            string Check12Digits;

            
                Check12Digits = barkod.Substring(0, 12);
                Barrcode = EAN13Class.EAN13(Check12Digits);
                labelControl1.Text = Barrcode;
                labelControl2.Text = stokKod;
                labelControl3.Text = stokAd;
                labelControl4.Text = birim; 
        }
        
    }
}
