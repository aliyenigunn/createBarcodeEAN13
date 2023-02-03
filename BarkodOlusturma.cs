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
    public partial class BarkodOlusturma : Form
    {
        public BarkodOlusturma()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Pazarlama.Barcode.BarkodOlusturmaOto oto = new BarkodOlusturmaOto();
            oto.MdiParent = this;
            oto.StartPosition = FormStartPosition.CenterScreen;
            oto.Location = new Point((this.ClientSize.Width - oto.Width) / 2,
                       (this.ClientSize.Height - oto.Height) / 2);
            oto.Show();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Pazarlama.Barcode.BarkodOlusturmaMan man = new BarkodOlusturmaMan();
            man.MdiParent = this;
            man.StartPosition = FormStartPosition.CenterScreen;
            man.Location = new Point((this.ClientSize.Width - man.Width) / 2,
                       (this.ClientSize.Height - man.Height) / 2);
            man.Show();
        }
    }
}
