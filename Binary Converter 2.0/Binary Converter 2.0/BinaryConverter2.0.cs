using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Binary_Converter_2._0
{
    public partial class frmBinaryConverter : Form
    {
        DragDrop sysDragDrop; 
        Conversion sysConvert;
        AnimationEngine AE;
        CCP CCPMenu;
        

        public int status;
        private bool blnDragDrop = false;
        private RichTextBox RTB;

        public frmBinaryConverter()
        {
            sysDragDrop = new DragDrop(this);
            AE = new AnimationEngine(this);
            sysConvert = new Conversion(this);
            CCPMenu = new CCP();

            AE.Monitors = SystemInformation.MonitorCount;
            AE.MonitorCount();

            AE.DrawCode = 3;//Default Value : 3
            status = 0;     //Default Value : 0
          
            int yAxis, xAxis;
            xAxis = Properties.Settings.Default.X;
            yAxis = Properties.Settings.Default.Y;
            new Point(xAxis, yAxis);
 
            InitializeComponent();
        }

        private void frmBinaryConverter_Load(object sender, EventArgs e)
        {
            lblErrorMessage.Text = "";
            txtText.Focus();
        }

        private void pnlOverlay_MouseDown(object sender, MouseEventArgs e)
        {
            sysDragDrop.findOffsets();//Finds The Difference Between The Curser And The Far Left Pixel
            blnDragDrop = true;
        }

        private void pnlOverlay_MouseUp(object sender, MouseEventArgs e)
        {
            blnDragDrop = false;
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            if (AE.DrawStatus == 0 & status == 0)//The close button is clicked AND the app is not minimized
            {
                AE.SaveLocation(0);
            }
            
            AE.DrawCode = 0;
        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            AE.DrawStatus = 1;//Sets Status To Minimized
            AE.SaveLocation(0);
            AE.DrawCode = 1;//Minimize Animation
        }

        private void tmrDragDrop_Tick(object sender, EventArgs e)
        {
            if (blnDragDrop == true)
            {
                this.Location = new Point(sysDragDrop.CalxPosition(), sysDragDrop.CalyPosition());
            }
        }

        private void tmrAnimation_Tick(object sender, EventArgs e)
        {
            AE.Animation(AE.DrawCode);//Sends Codes To The Animiation Engine
        }

        private void frmBinaryConverter_Activated(object sender, EventArgs e)
        {
            if (AE.DrawCode == 4)//Minimized
            {
                AE.DrawCode = 2;
            }

            if (AE.DrawCode == 5 & status == 1)//Icon Was Clicked From Taskbar, And The App Was Minimized
            {
                AE.DrawCode = 1;
            }
        }

        //const int WS_MINIMIZEBOX = 0x20000;
        ////const int CS_DBLCLKS = 0x8;
        //protected override CreateParams CreateParams
        //{
            
        //    get
        //    {
        //        CreateParams cp = base.CreateParams;
        //        cp.Style |= WS_MINIMIZEBOX;
        //        //cp.ClassStyle |= CS_DBLCLKS;
        //        return cp;
        //    }
        //}

        private void lblToBinary_Click(object sender, EventArgs e)
        {
            this.lblErrorMessage.Text = "";
            this.txtBinary.Text = sysConvert.ToBinary(txtText.Text);
        }

        private void lblToText_Click(object sender, EventArgs e)
        {
            this.txtText.Text = sysConvert.ToText(sysConvert.SanitizeInput(txtBinary.Text));
        }

        
        private void txtText_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                RTB = txtText;
                CallCCPMenu(RTB, e);
            }
        }
        
        private void txtBinary_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                RTB = txtBinary;
                CallCCPMenu(RTB, e);
            }
        }

        private void CallCCPMenu(RichTextBox r, MouseEventArgs e)
        {
            
                if (RTB.SelectedText.Length > 0)
                {
                    CutMSI.Enabled = true;
                    copyMSI.Enabled = true;
                }
                else
                {
                    CutMSI.Enabled = false;
                    copyMSI.Enabled = false;
                }

                cmsEdit.Show(Cursor.Position);
        }

        private void CutMSI_Click(object sender, EventArgs e)
        {
            CCPMenu.Cut(RTB);
        }

        private void copyMSI_Click(object sender, EventArgs e)
        {
            CCPMenu.Copy(RTB);
        }

        private void pasteMSI_Click(object sender, EventArgs e)
        {
            CCPMenu.paste(RTB);
        }

    }
}
