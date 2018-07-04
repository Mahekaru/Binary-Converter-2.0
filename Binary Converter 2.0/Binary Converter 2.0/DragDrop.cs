using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Binary_Converter_2._0
{
    class DragDrop
    {
        private frmBinaryConverter MainForm;
        private int xAxisOffset;
        private int yAxisOffset;

        public DragDrop(frmBinaryConverter frmMainForm)
        {
            MainForm = frmMainForm;
           
        }

        public void findOffsets()
        {
            int x1, x2, xOffset;
            int y1, y2, yOffset;

            x1 = Control.MousePosition.X;
            x2 = MainForm.Location.X;

            y1 = Control.MousePosition.Y;
            y2 = MainForm.Location.Y;

            xOffset = (x1 - x2);
            xAxisOffset = xOffset;

            yOffset = (y1 - y2);
            yAxisOffset = yOffset;
        }

        public int CalxPosition()
        {
            int xOffset;
            xOffset = Control.MousePosition.X - xAxisOffset;
            return xOffset;
        }

        public int CalyPosition()
        {
            int yOffset;
            yOffset = Control.MousePosition.Y - yAxisOffset;
            return yOffset;
        }
    }
}
