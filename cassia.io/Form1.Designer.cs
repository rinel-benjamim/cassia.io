namespace cassia.io
{
    partial class frmMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.blForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.pnlBackgroundForm1 = new System.Windows.Forms.Panel();
            this.pnlContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlContainerHeadarMain = new System.Windows.Forms.Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlHeaderControlBox = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.cboxMain = new Bunifu.UI.WinForms.BunifuFormControlBox();
            this.rsizeMain = new Guna.UI2.WinForms.Guna2ResizeForm(this.components);
            this.dragControlHeaderControlBox = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pnlBackgroundForm1.SuspendLayout();
            this.pnlContainerHeadarMain.SuspendLayout();
            this.pnlHeaderControlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // blForm1
            // 
            this.blForm1.AnimateWindow = true;
            this.blForm1.AnimationInterval = 600;
            this.blForm1.BorderRadius = 10;
            this.blForm1.ContainerControl = this;
            this.blForm1.DockIndicatorTransparencyValue = 0D;
            this.blForm1.DragEndTransparencyValue = 0.1D;
            this.blForm1.DragStartTransparencyValue = 0.1D;
            this.blForm1.TransparentWhileDrag = true;
            // 
            // pnlBackgroundForm1
            // 
            this.pnlBackgroundForm1.Controls.Add(this.pnlContainer);
            this.pnlBackgroundForm1.Controls.Add(this.pnlContainerHeadarMain);
            this.pnlBackgroundForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBackgroundForm1.Location = new System.Drawing.Point(0, 0);
            this.pnlBackgroundForm1.Name = "pnlBackgroundForm1";
            this.pnlBackgroundForm1.Size = new System.Drawing.Size(1112, 569);
            this.pnlBackgroundForm1.TabIndex = 0;
            // 
            // pnlContainer
            // 
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 69);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1112, 500);
            this.pnlContainer.TabIndex = 1;
            // 
            // pnlContainerHeadarMain
            // 
            this.pnlContainerHeadarMain.Controls.Add(this.guna2Panel2);
            this.pnlContainerHeadarMain.Controls.Add(this.pnlHeaderControlBox);
            this.pnlContainerHeadarMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlContainerHeadarMain.Location = new System.Drawing.Point(0, 0);
            this.pnlContainerHeadarMain.Name = "pnlContainerHeadarMain";
            this.pnlContainerHeadarMain.Size = new System.Drawing.Size(1112, 69);
            this.pnlContainerHeadarMain.TabIndex = 0;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderColor = System.Drawing.Color.Blue;
            this.guna2Panel2.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(25)))));
            this.guna2Panel2.Location = new System.Drawing.Point(0, 30);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1112, 39);
            this.guna2Panel2.TabIndex = 1;
            // 
            // pnlHeaderControlBox
            // 
            this.pnlHeaderControlBox.BorderColor = System.Drawing.Color.Blue;
            this.pnlHeaderControlBox.Controls.Add(this.guna2HtmlLabel1);
            this.pnlHeaderControlBox.Controls.Add(this.guna2PictureBox1);
            this.pnlHeaderControlBox.Controls.Add(this.cboxMain);
            this.pnlHeaderControlBox.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.pnlHeaderControlBox.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.pnlHeaderControlBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderControlBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(25)))));
            this.pnlHeaderControlBox.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderControlBox.Name = "pnlHeaderControlBox";
            this.pnlHeaderControlBox.Padding = new System.Windows.Forms.Padding(5, 0, 0, 1);
            this.pnlHeaderControlBox.Size = new System.Drawing.Size(1112, 30);
            this.pnlHeaderControlBox.TabIndex = 0;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(40, 7);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(47, 17);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "cassia.io";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2PictureBox1.Image = global::cassia.io.Properties.Resources.icons8_plant_60px_1;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(5, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(29, 29);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            // 
            // cboxMain
            // 
            this.cboxMain.BunifuFormDrag = null;
            this.cboxMain.CloseBoxOptions.BackColor = System.Drawing.Color.Transparent;
            this.cboxMain.CloseBoxOptions.BorderRadius = 0;
            this.cboxMain.CloseBoxOptions.Enabled = true;
            this.cboxMain.CloseBoxOptions.EnableDefaultAction = true;
            this.cboxMain.CloseBoxOptions.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.cboxMain.CloseBoxOptions.Icon = ((System.Drawing.Image)(resources.GetObject("cboxMain.CloseBoxOptions.Icon")));
            this.cboxMain.CloseBoxOptions.IconAlt = null;
            this.cboxMain.CloseBoxOptions.IconColor = System.Drawing.Color.White;
            this.cboxMain.CloseBoxOptions.IconHoverColor = System.Drawing.Color.White;
            this.cboxMain.CloseBoxOptions.IconPressedColor = System.Drawing.Color.White;
            this.cboxMain.CloseBoxOptions.IconSize = new System.Drawing.Size(18, 18);
            this.cboxMain.CloseBoxOptions.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.cboxMain.Dock = System.Windows.Forms.DockStyle.Right;
            this.cboxMain.ForeColor = System.Drawing.Color.White;
            this.cboxMain.HelpBox = false;
            this.cboxMain.HelpBoxOptions.BackColor = System.Drawing.Color.Transparent;
            this.cboxMain.HelpBoxOptions.BorderRadius = 0;
            this.cboxMain.HelpBoxOptions.Enabled = true;
            this.cboxMain.HelpBoxOptions.EnableDefaultAction = true;
            this.cboxMain.HelpBoxOptions.HoverColor = System.Drawing.Color.LightGray;
            this.cboxMain.HelpBoxOptions.Icon = ((System.Drawing.Image)(resources.GetObject("cboxMain.HelpBoxOptions.Icon")));
            this.cboxMain.HelpBoxOptions.IconAlt = null;
            this.cboxMain.HelpBoxOptions.IconColor = System.Drawing.Color.White;
            this.cboxMain.HelpBoxOptions.IconHoverColor = System.Drawing.Color.Black;
            this.cboxMain.HelpBoxOptions.IconPressedColor = System.Drawing.Color.Black;
            this.cboxMain.HelpBoxOptions.IconSize = new System.Drawing.Size(22, 22);
            this.cboxMain.HelpBoxOptions.PressedColor = System.Drawing.Color.Silver;
            this.cboxMain.Location = new System.Drawing.Point(981, 0);
            this.cboxMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboxMain.MaximizeBox = false;
            this.cboxMain.MaximizeBoxOptions.BackColor = System.Drawing.Color.Transparent;
            this.cboxMain.MaximizeBoxOptions.BorderRadius = 0;
            this.cboxMain.MaximizeBoxOptions.Enabled = true;
            this.cboxMain.MaximizeBoxOptions.EnableDefaultAction = true;
            this.cboxMain.MaximizeBoxOptions.HoverColor = System.Drawing.Color.LightGray;
            this.cboxMain.MaximizeBoxOptions.Icon = ((System.Drawing.Image)(resources.GetObject("cboxMain.MaximizeBoxOptions.Icon")));
            this.cboxMain.MaximizeBoxOptions.IconAlt = ((System.Drawing.Image)(resources.GetObject("cboxMain.MaximizeBoxOptions.IconAlt")));
            this.cboxMain.MaximizeBoxOptions.IconColor = System.Drawing.Color.White;
            this.cboxMain.MaximizeBoxOptions.IconHoverColor = System.Drawing.Color.Black;
            this.cboxMain.MaximizeBoxOptions.IconPressedColor = System.Drawing.Color.Black;
            this.cboxMain.MaximizeBoxOptions.IconSize = new System.Drawing.Size(16, 16);
            this.cboxMain.MaximizeBoxOptions.PressedColor = System.Drawing.Color.Silver;
            this.cboxMain.MinimizeBox = true;
            this.cboxMain.MinimizeBoxOptions.BackColor = System.Drawing.Color.Transparent;
            this.cboxMain.MinimizeBoxOptions.BorderRadius = 0;
            this.cboxMain.MinimizeBoxOptions.Enabled = true;
            this.cboxMain.MinimizeBoxOptions.EnableDefaultAction = true;
            this.cboxMain.MinimizeBoxOptions.HoverColor = System.Drawing.Color.LightGray;
            this.cboxMain.MinimizeBoxOptions.Icon = ((System.Drawing.Image)(resources.GetObject("cboxMain.MinimizeBoxOptions.Icon")));
            this.cboxMain.MinimizeBoxOptions.IconAlt = null;
            this.cboxMain.MinimizeBoxOptions.IconColor = System.Drawing.Color.White;
            this.cboxMain.MinimizeBoxOptions.IconHoverColor = System.Drawing.Color.Black;
            this.cboxMain.MinimizeBoxOptions.IconPressedColor = System.Drawing.Color.Black;
            this.cboxMain.MinimizeBoxOptions.IconSize = new System.Drawing.Size(14, 14);
            this.cboxMain.MinimizeBoxOptions.PressedColor = System.Drawing.Color.Silver;
            this.cboxMain.Name = "cboxMain";
            this.cboxMain.ShowDesignBorders = false;
            this.cboxMain.Size = new System.Drawing.Size(131, 29);
            this.cboxMain.TabIndex = 0;
            this.cboxMain.MaximizeRestoreClicked += new System.EventHandler<Bunifu.UI.WinForms.BunifuFormControlBox.MaximizeRestoreClickedEventArgs>(this.cboxMain_MaximizeRestoreClicked);
            // 
            // rsizeMain
            // 
            this.rsizeMain.TargetForm = this;
            // 
            // dragControlHeaderControlBox
            // 
            this.dragControlHeaderControlBox.DockIndicatorTransparencyValue = 0.6D;
            this.dragControlHeaderControlBox.TargetControl = this.pnlHeaderControlBox;
            this.dragControlHeaderControlBox.UseTransparentDrag = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1112, 569);
            this.Controls.Add(this.pnlBackgroundForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlBackgroundForm1.ResumeLayout(false);
            this.pnlContainerHeadarMain.ResumeLayout(false);
            this.pnlHeaderControlBox.ResumeLayout(false);
            this.pnlHeaderControlBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm blForm1;
        private System.Windows.Forms.Panel pnlBackgroundForm1;
        private System.Windows.Forms.Panel pnlContainerHeadarMain;
        private Guna.UI2.WinForms.Guna2Panel pnlHeaderControlBox;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Bunifu.UI.WinForms.BunifuFormControlBox cboxMain;
        private Guna.UI2.WinForms.Guna2ResizeForm rsizeMain;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2DragControl dragControlHeaderControlBox;
        private Guna.UI2.WinForms.Guna2Panel pnlContainer;
    }
}

