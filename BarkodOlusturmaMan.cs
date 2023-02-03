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
    public partial class BarkodOlusturmaMan : Form
    {
        logoDbDataContext con = new logoDbDataContext();
        public BarkodOlusturmaMan()
        {
            InitializeComponent();
        }
        string Barrcode;
        string Check12Digits;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            labelControl4.Text = EAN13Class.Barcode13Digits.ToString(); ;
            labelControl5.Text = EAN13Class.EAN13(textBox1.Text);

            con = new logoDbDataContext();
            var q = con.PAZ_DEPOBAZLISTOKFIYATs.Where(x => x.BARCODE.Contains(labelControl4.Text)).Select(x => x.NAME).FirstOrDefault();
            //MessageBox.Show(q);
            if(q != null)
            {
                labelControl6.ForeColor = Color.Red;
                labelControl6.Text = "Oluşturduğunuz barkod "+ q+ " adlı ürüne aittir" ;
            }
            else
            {
                labelControl6.ForeColor = Color.Green;
                labelControl6.Text = "Barkod kullanılabilir durumdadır";
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            labelControl6.Text = "";
            labelControl7.Text = "";
            if (textBox1.Text !="")
            {
                Check12Digits = textBox1.Text.PadRight(12,'0');
                Barrcode = EAN13Class.EAN13(Check12Digits);
                
                if(!String.Equals(EAN13Class.Barcode13Digits,"") || (EAN13Class.Barcode13Digits !=""))
                {
                   richTextBox1.Text = EAN13Class.Barcode13Digits.ToString();
                    Int32 intStart = Convert.ToInt32(richTextBox1.TextLength - 1);
                    ChangeTextColor.ChangeColor(richTextBox1, intStart);
                }
            }

        }

        private void BarkodOlusturmaMan_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (labelControl4.Text.Length>0)
            {
                Clipboard.SetText(labelControl4.Text);
                labelControl7.ForeColor = Color.Green;
                labelControl7.Text = "Kopyalandı";
                
            }
        }
    }
}
