using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Ecka.EMS.Desktop.Pazarlama.Barcode
{
    class ChangeTextColor
    {
        public static void ChangeColor(RichTextBox rtb, int Start, byte Length = 1)
        {
            rtb.SelectionAlignment = HorizontalAlignment.Left;
            rtb.SelectionStart = Start;
            rtb.SelectionLength = Length;
            rtb.SelectionColor = Color.Crimson;
        }
    }
}
