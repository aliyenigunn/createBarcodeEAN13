using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecka.EMS.Desktop.Pazarlama.Barcode
{
    public partial class Barkod : Form
    {
        logoDbDataContext con = new logoDbDataContext();
        public Barkod()
        {
            InitializeComponent();
        }
        private void Barkod_Load(object sender, EventArgs e)
        {
            con = new logoDbDataContext();
            var q = con.PAZ_DEPOBAZLISTOKFIYATs.Select(x => new { x.CODE, x.NAME, x.BIRIM, x.BARCODE, x.GATEMSTOK, x.KÜSGETSTOK, x.TOPLAMSTOK }).ToList();
            gridControl1.DataSource = q;
        }
        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            con = new logoDbDataContext();
            var q = con.PAZ_DEPOBAZLISTOKFIYATs.Select(x => new { x.CODE, x.NAME, x.BIRIM, x.BARCODE }).ToList();

            UrunDetay.stokKod = gridView1.GetRowCellDisplayText(gridView1.FocusedRowHandle, "CODE").ToString();
            UrunDetay.stokAd = gridView1.GetRowCellDisplayText(gridView1.FocusedRowHandle, "NAME").ToString();
            UrunDetay.birim = gridView1.GetRowCellDisplayText(gridView1.FocusedRowHandle, "BIRIM").ToString();
            UrunDetay.barkod = gridView1.GetRowCellDisplayText(gridView1.FocusedRowHandle, "BARCODE").ToString();
            if (gridView1.GetRowCellDisplayText(gridView1.FocusedRowHandle, "BARCODE").ToString() != "")
            {
                Pazarlama.Barcode.UrunDetay urun = new UrunDetay();
                urun.ShowDialog();
            }
            else
                MessageBox.Show("Seçtiğiniz ürünün barkodu bulunmamaktadır.");
        }
       
        private void btnOlustur_Click(object sender, EventArgs e)
        {
            Pazarlama.Barcode.BarkodOlusturma brk = new BarkodOlusturma();
            brk.ShowDialog();
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Çok yakında...");
            //try
            //{
            //    string str = Application.StartupPath + "\\Barcode.Permanent.exe";
            //    Process process = new Process();
            //    process.StartInfo.FileName = str;
            //    process.Start();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Hata: " + ex.Message);
            //}
        }

    }
}
