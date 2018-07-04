using System;
using System.Drawing;
using System.Windows.Forms;

namespace Binary_Converter_2._0
{
    class AnimationEngine
    {
        private frmBinaryConverter MainForm;
        public int DrawCode;
        public int DrawStatus;
        public int Monitors;

        public AnimationEngine(frmBinaryConverter frmMainForm)
        {
            MainForm = frmMainForm;
        }

        public void SaveLocation(int Data)
        {
            int xAxis;
            int yAxis;

            if (Data == 0)
            {
                xAxis = MainForm.Location.X;
                yAxis = MainForm.Location.Y;
            }
            else
            {
                xAxis = Screen.PrimaryScreen.Bounds.Width / 2;
                yAxis = Screen.PrimaryScreen.Bounds.Height / 2;
            }
            Properties.Settings.Default.X = xAxis;
            Properties.Settings.Default.Y = yAxis;
            Properties.Settings.Default.Monitors = Monitors;

            Properties.Settings.Default.Save();
        }

        void Flatin()
        {
            MainForm.Size = new Size(MainForm.Width - 90, MainForm.Height);
        }

        void Stretch()
        {
            MainForm.Size = new Size(MainForm.Width + 90, MainForm.Height);
        }

        public void MonitorCount()
        {
            if (Monitors < Properties.Settings.Default.Monitors)
            {
                SaveLocation(1);
            }
        }

        void Shrinkit()
        {
            Flatin();
            if (MainForm.Width < 20)
            {
                MainForm.Location = new Point(MainForm.Location.X, MainForm.Location.Y + 120);
            }
        }

        void GrowIt()
        {
            if (MainForm.Location.Y != Properties.Settings.Default.Y)
            {
                MainForm.Location = new Point(Properties.Settings.Default.X, MainForm.Location.Y - 120);
            }
            else
            {
                if (MainForm.Width != 542)
                {
                    Stretch();
                }
            }
        }

        int FormulaV()
        {
            int srnHeight, FV,xAxis,yAxis;

            srnHeight = Screen.PrimaryScreen.Bounds.Height;
            xAxis = Properties.Settings.Default.X;
            yAxis = Properties.Settings.Default.Y;

            do
            {
                yAxis += 120;
            }
            while (yAxis < srnHeight);
            FV = yAxis;

            return FV;
        }
        private int Lvl = 0;
        public void Animation(int Animate)
        {
            switch (Animate)
            {
                case 0://Close
                    Shrinkit();
                    if (MainForm.Location.Y > Screen.PrimaryScreen.Bounds.Height)
                    {
                        Properties.Settings.Default.Save();
                        MainForm.Close();
                    }
                    break;
                case 1://Minimize
                    Shrinkit();
                    if (MainForm.Location.Y > Screen.PrimaryScreen.Bounds.Height)
                    {          
                        MainForm.WindowState = FormWindowState.Minimized;
                        DrawCode = 4;
                    }
                    break;
                case 2://Open From Taskbar
                    GrowIt();
                    DrawStatus = 0;
                    if (MainForm.Width == 542)
                    {
                        DrawCode = 5;
                    }
                    break;
                case 3://Open From Icon
                    if (Lvl == 0)
                    {
                        int FV;
                        MainForm.Visible = false;
                        MainForm.Width = 2;
                        FV = FormulaV();
                        MainForm.Location = new Point(Properties.Settings.Default.X, FV);
                        MainForm.Visible = true;
                        Lvl = 1;
                    }

                    if (Lvl == 1)
                    {
                        DrawCode = 2;
                        Lvl = 0;
                    }
                    break;
            }
        }
    }
}
