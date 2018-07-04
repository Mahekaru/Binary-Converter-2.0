using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Binary_Converter_2._0
{
    class CCP
    {
 
        public void Cut(RichTextBox RTB)
        {
            Clipboard.SetDataObject(RTB.SelectedText.ToString());
            RTB.SelectedText = "";
        }

        public void Copy(RichTextBox RTB)
        {
            Clipboard.SetDataObject(RTB.SelectedText.ToString());
        }

        public void paste(RichTextBox RTB)
        {
            RTB.Paste();
        }
    }
}
