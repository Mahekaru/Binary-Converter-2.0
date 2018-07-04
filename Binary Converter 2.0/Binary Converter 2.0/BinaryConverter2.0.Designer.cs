namespace Binary_Converter_2._0
{
    partial class frmBinaryConverter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbBinary = new System.Windows.Forms.GroupBox();
            this.txtBinary = new System.Windows.Forms.RichTextBox();
            this.gbText = new System.Windows.Forms.GroupBox();
            this.txtText = new System.Windows.Forms.RichTextBox();
            this.btnToBinary = new System.Windows.Forms.Panel();
            this.lblToBinary = new System.Windows.Forms.Label();
            this.btnToText = new System.Windows.Forms.Panel();
            this.lblToText = new System.Windows.Forms.Label();
            this.tmrDragDrop = new System.Windows.Forms.Timer(this.components);
            this.tmrAnimation = new System.Windows.Forms.Timer(this.components);
            this.pnlOverlay = new System.Windows.Forms.Panel();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMinimize = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblClose = new System.Windows.Forms.Label();
            this.cmsEdit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CutMSI = new System.Windows.Forms.ToolStripMenuItem();
            this.copyMSI = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteMSI = new System.Windows.Forms.ToolStripMenuItem();
            this.gbBinary.SuspendLayout();
            this.gbText.SuspendLayout();
            this.btnToBinary.SuspendLayout();
            this.btnToText.SuspendLayout();
            this.pnlOverlay.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.cmsEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbBinary
            // 
            this.gbBinary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gbBinary.BackColor = System.Drawing.Color.Black;
            this.gbBinary.Controls.Add(this.txtBinary);
            this.gbBinary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBinary.ForeColor = System.Drawing.Color.White;
            this.gbBinary.Location = new System.Drawing.Point(272, 23);
            this.gbBinary.Name = "gbBinary";
            this.gbBinary.Size = new System.Drawing.Size(265, 180);
            this.gbBinary.TabIndex = 3;
            this.gbBinary.TabStop = false;
            this.gbBinary.Text = "Binary";
            // 
            // txtBinary
            // 
            this.txtBinary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBinary.BackColor = System.Drawing.Color.Black;
            this.txtBinary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBinary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBinary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBinary.ForeColor = System.Drawing.Color.White;
            this.txtBinary.Location = new System.Drawing.Point(6, 18);
            this.txtBinary.Name = "txtBinary";
            this.txtBinary.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtBinary.Size = new System.Drawing.Size(253, 158);
            this.txtBinary.TabIndex = 2;
            this.txtBinary.Text = "";
            this.txtBinary.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtBinary_MouseDown);
            // 
            // gbText
            // 
            this.gbText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gbText.BackColor = System.Drawing.Color.Black;
            this.gbText.Controls.Add(this.txtText);
            this.gbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbText.ForeColor = System.Drawing.Color.White;
            this.gbText.Location = new System.Drawing.Point(3, 23);
            this.gbText.Name = "gbText";
            this.gbText.Size = new System.Drawing.Size(269, 180);
            this.gbText.TabIndex = 4;
            this.gbText.TabStop = false;
            this.gbText.Text = "Text";
            // 
            // txtText
            // 
            this.txtText.BackColor = System.Drawing.Color.Black;
            this.txtText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtText.ForeColor = System.Drawing.Color.White;
            this.txtText.Location = new System.Drawing.Point(6, 16);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(260, 158);
            this.txtText.TabIndex = 1;
            this.txtText.Text = "";
            this.txtText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtText_MouseDown);
            // 
            // btnToBinary
            // 
            this.btnToBinary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnToBinary.Controls.Add(this.lblToBinary);
            this.btnToBinary.Location = new System.Drawing.Point(201, 205);
            this.btnToBinary.Name = "btnToBinary";
            this.btnToBinary.Size = new System.Drawing.Size(70, 28);
            this.btnToBinary.TabIndex = 5;
            // 
            // lblToBinary
            // 
            this.lblToBinary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToBinary.Location = new System.Drawing.Point(1, -2);
            this.lblToBinary.Name = "lblToBinary";
            this.lblToBinary.Size = new System.Drawing.Size(66, 30);
            this.lblToBinary.TabIndex = 0;
            this.lblToBinary.Text = "To Binary";
            this.lblToBinary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblToBinary.Click += new System.EventHandler(this.lblToBinary_Click);
            // 
            // btnToText
            // 
            this.btnToText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnToText.Controls.Add(this.lblToText);
            this.btnToText.Location = new System.Drawing.Point(278, 205);
            this.btnToText.Name = "btnToText";
            this.btnToText.Size = new System.Drawing.Size(70, 28);
            this.btnToText.TabIndex = 6;
            // 
            // lblToText
            // 
            this.lblToText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToText.Location = new System.Drawing.Point(2, -1);
            this.lblToText.Name = "lblToText";
            this.lblToText.Size = new System.Drawing.Size(64, 28);
            this.lblToText.TabIndex = 0;
            this.lblToText.Text = "To Text";
            this.lblToText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblToText.Click += new System.EventHandler(this.lblToText_Click);
            // 
            // tmrDragDrop
            // 
            this.tmrDragDrop.Enabled = true;
            this.tmrDragDrop.Interval = 10;
            this.tmrDragDrop.Tick += new System.EventHandler(this.tmrDragDrop_Tick);
            // 
            // tmrAnimation
            // 
            this.tmrAnimation.Enabled = true;
            this.tmrAnimation.Interval = 15;
            this.tmrAnimation.Tick += new System.EventHandler(this.tmrAnimation_Tick);
            // 
            // pnlOverlay
            // 
            this.pnlOverlay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOverlay.Controls.Add(this.lblErrorMessage);
            this.pnlOverlay.Controls.Add(this.panel2);
            this.pnlOverlay.Controls.Add(this.btnToBinary);
            this.pnlOverlay.Controls.Add(this.panel1);
            this.pnlOverlay.Controls.Add(this.btnToText);
            this.pnlOverlay.Controls.Add(this.gbText);
            this.pnlOverlay.Controls.Add(this.gbBinary);
            this.pnlOverlay.Location = new System.Drawing.Point(0, 0);
            this.pnlOverlay.Name = "pnlOverlay";
            this.pnlOverlay.Size = new System.Drawing.Size(542, 236);
            this.pnlOverlay.TabIndex = 7;
            this.pnlOverlay.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlOverlay_MouseDown);
            this.pnlOverlay.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlOverlay_MouseUp);
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMessage.Location = new System.Drawing.Point(6, 8);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(97, 16);
            this.lblErrorMessage.TabIndex = 7;
            this.lblErrorMessage.Text = "Error Message";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblMinimize);
            this.panel2.Location = new System.Drawing.Point(502, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(20, 20);
            this.panel2.TabIndex = 4;
            // 
            // lblMinimize
            // 
            this.lblMinimize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMinimize.AutoSize = true;
            this.lblMinimize.BackColor = System.Drawing.Color.Black;
            this.lblMinimize.ForeColor = System.Drawing.Color.White;
            this.lblMinimize.Location = new System.Drawing.Point(3, 2);
            this.lblMinimize.Name = "lblMinimize";
            this.lblMinimize.Size = new System.Drawing.Size(13, 13);
            this.lblMinimize.TabIndex = 1;
            this.lblMinimize.Text = "_";
            this.lblMinimize.Click += new System.EventHandler(this.lblMinimize_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblClose);
            this.panel1.Location = new System.Drawing.Point(521, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(20, 20);
            this.panel1.TabIndex = 3;
            // 
            // lblClose
            // 
            this.lblClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClose.AutoSize = true;
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(2, 2);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(14, 13);
            this.lblClose.TabIndex = 1;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // cmsEdit
            // 
            this.cmsEdit.BackColor = System.Drawing.Color.Black;
            this.cmsEdit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CutMSI,
            this.copyMSI,
            this.pasteMSI});
            this.cmsEdit.Name = "cmsEdit";
            this.cmsEdit.Size = new System.Drawing.Size(153, 92);
            // 
            // CutMSI
            // 
            this.CutMSI.AutoToolTip = true;
            this.CutMSI.ForeColor = System.Drawing.Color.White;
            this.CutMSI.Name = "CutMSI";
            this.CutMSI.Size = new System.Drawing.Size(152, 22);
            this.CutMSI.Text = "Cut";
            this.CutMSI.Click += new System.EventHandler(this.CutMSI_Click);
            // 
            // copyMSI
            // 
            this.copyMSI.AutoToolTip = true;
            this.copyMSI.ForeColor = System.Drawing.Color.White;
            this.copyMSI.Name = "copyMSI";
            this.copyMSI.Size = new System.Drawing.Size(152, 22);
            this.copyMSI.Text = "Copy";
            this.copyMSI.Click += new System.EventHandler(this.copyMSI_Click);
            // 
            // pasteMSI
            // 
            this.pasteMSI.AutoToolTip = true;
            this.pasteMSI.ForeColor = System.Drawing.Color.White;
            this.pasteMSI.Name = "pasteMSI";
            this.pasteMSI.Size = new System.Drawing.Size(152, 22);
            this.pasteMSI.Text = "Paste";
            this.pasteMSI.Click += new System.EventHandler(this.pasteMSI_Click);
            // 
            // frmBinaryConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(543, 236);
            this.ControlBox = false;
            this.Controls.Add(this.pnlOverlay);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, -1280);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBinaryConverter";
            this.ShowIcon = false;
            this.Text = "Binary Converter2.0";
            this.Activated += new System.EventHandler(this.frmBinaryConverter_Activated);
            this.Load += new System.EventHandler(this.frmBinaryConverter_Load);
            this.gbBinary.ResumeLayout(false);
            this.gbText.ResumeLayout(false);
            this.btnToBinary.ResumeLayout(false);
            this.btnToText.ResumeLayout(false);
            this.pnlOverlay.ResumeLayout(false);
            this.pnlOverlay.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.cmsEdit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBinary;
        private System.Windows.Forms.GroupBox gbText;
        private System.Windows.Forms.Panel btnToBinary;
        private System.Windows.Forms.Label lblToBinary;
        private System.Windows.Forms.Panel btnToText;
        private System.Windows.Forms.Label lblToText;
        private System.Windows.Forms.Timer tmrDragDrop;
        public System.Windows.Forms.Timer tmrAnimation;
        private System.Windows.Forms.Panel pnlOverlay;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblMinimize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblClose;
        public System.Windows.Forms.RichTextBox txtBinary;
        public System.Windows.Forms.RichTextBox txtText;
        public System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.ToolStripMenuItem CutMSI;
        private System.Windows.Forms.ToolStripMenuItem copyMSI;
        private System.Windows.Forms.ToolStripMenuItem pasteMSI;
        public System.Windows.Forms.ContextMenuStrip cmsEdit;
    }
}

