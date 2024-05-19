
namespace GWT
{
    partial class LandingForm
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
            Guna.UI2.AnimatorNS.Animation animation3 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LandingForm));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.headerLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.mainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnNext = new Guna.UI2.WinForms.Guna2ImageButton();
            this.BtnBack = new Guna.UI2.WinForms.Guna2ImageButton();
            this.femaleBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.maleBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.femaleLbl = new System.Windows.Forms.Label();
            this.maleLbl = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.transition = new Guna.UI2.WinForms.Guna2Transition();
            this.loadingScr = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadingScr)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.guna2CircleButton1);
            this.panel1.Controls.Add(this.guna2ImageButton1);
            this.transition.SetDecoration(this.panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1102, 40);
            this.panel1.TabIndex = 0;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.transition.SetDecoration(this.guna2PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox1.Image = global::GWT.Properties.Resources.MJL_CombinationMark_removebg_preview;
            this.guna2PictureBox1.Location = new System.Drawing.Point(15, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(60, 60);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 3;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.CheckedState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.CustomImages.Parent = this.guna2CircleButton1;
            this.transition.SetDecoration(this.guna2CircleButton1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2CircleButton1.FillColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.HoverState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Image = global::GWT.Properties.Resources.minimizeRed;
            this.guna2CircleButton1.Location = new System.Drawing.Point(1011, 7);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.ShadowDecoration.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Size = new System.Drawing.Size(25, 25);
            this.guna2CircleButton1.TabIndex = 2;
            this.guna2CircleButton1.Click += new System.EventHandler(this.guna2CircleButton1_Click);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.Parent = this.guna2ImageButton1;
            this.transition.SetDecoration(this.guna2ImageButton1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2ImageButton1.HoverState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Image = global::GWT.Properties.Resources.closeBtn;
            this.guna2ImageButton1.Location = new System.Drawing.Point(1054, 7);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Size = new System.Drawing.Size(25, 25);
            this.guna2ImageButton1.TabIndex = 0;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.panel1;
            // 
            // headerLbl
            // 
            this.headerLbl.BackColor = System.Drawing.Color.Transparent;
            this.transition.SetDecoration(this.headerLbl, Guna.UI2.AnimatorNS.DecorationType.None);
            this.headerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 29.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLbl.ForeColor = System.Drawing.Color.White;
            this.headerLbl.Location = new System.Drawing.Point(309, 40);
            this.headerLbl.Name = "headerLbl";
            this.headerLbl.Size = new System.Drawing.Size(504, 46);
            this.headerLbl.TabIndex = 2;
            this.headerLbl.Text = "WHAT IS YOUR GENDER?";
            this.headerLbl.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Transparent;
            this.mainPanel.Controls.Add(this.BtnNext);
            this.mainPanel.Controls.Add(this.BtnBack);
            this.mainPanel.Controls.Add(this.femaleBtn);
            this.mainPanel.Controls.Add(this.maleBtn);
            this.mainPanel.Controls.Add(this.femaleLbl);
            this.mainPanel.Controls.Add(this.maleLbl);
            this.mainPanel.Controls.Add(this.headerLbl);
            this.transition.SetDecoration(this.mainPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.mainPanel.Location = new System.Drawing.Point(0, 38);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.ShadowDecoration.Parent = this.mainPanel;
            this.mainPanel.Size = new System.Drawing.Size(1102, 575);
            this.mainPanel.TabIndex = 3;
            // 
            // BtnNext
            // 
            this.BtnNext.CheckedState.Parent = this.BtnNext;
            this.BtnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition.SetDecoration(this.BtnNext, Guna.UI2.AnimatorNS.DecorationType.None);
            this.BtnNext.HoverState.ImageSize = new System.Drawing.Size(48, 48);
            this.BtnNext.HoverState.Parent = this.BtnNext;
            this.BtnNext.Image = global::GWT.Properties.Resources.carbon_next_outline1;
            this.BtnNext.ImageSize = new System.Drawing.Size(48, 48);
            this.BtnNext.Location = new System.Drawing.Point(1042, 504);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.PressedState.ImageSize = new System.Drawing.Size(48, 48);
            this.BtnNext.PressedState.Parent = this.BtnNext;
            this.BtnNext.Size = new System.Drawing.Size(48, 48);
            this.BtnNext.TabIndex = 14;
            this.BtnNext.Visible = false;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.CheckedState.Parent = this.BtnBack;
            this.BtnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition.SetDecoration(this.BtnBack, Guna.UI2.AnimatorNS.DecorationType.None);
            this.BtnBack.HoverState.ImageSize = new System.Drawing.Size(48, 48);
            this.BtnBack.HoverState.Parent = this.BtnBack;
            this.BtnBack.Image = global::GWT.Properties.Resources.mingcute_back_fill;
            this.BtnBack.ImageSize = new System.Drawing.Size(48, 48);
            this.BtnBack.Location = new System.Drawing.Point(23, 504);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.PressedState.ImageSize = new System.Drawing.Size(48, 48);
            this.BtnBack.PressedState.Parent = this.BtnBack;
            this.BtnBack.Size = new System.Drawing.Size(48, 48);
            this.BtnBack.TabIndex = 13;
            this.BtnBack.Visible = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // femaleBtn
            // 
            this.femaleBtn.BackgroundImage = global::GWT.Properties.Resources.femaleGWT;
            this.femaleBtn.CheckedState.ImageSize = new System.Drawing.Size(260, 419);
            this.femaleBtn.CheckedState.Parent = this.femaleBtn;
            this.femaleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition.SetDecoration(this.femaleBtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.femaleBtn.HoverState.ImageSize = new System.Drawing.Size(260, 419);
            this.femaleBtn.HoverState.Parent = this.femaleBtn;
            this.femaleBtn.ImageSize = new System.Drawing.Size(260, 419);
            this.femaleBtn.Location = new System.Drawing.Point(656, 153);
            this.femaleBtn.Name = "femaleBtn";
            this.femaleBtn.PressedState.ImageSize = new System.Drawing.Size(260, 419);
            this.femaleBtn.PressedState.Parent = this.femaleBtn;
            this.femaleBtn.Size = new System.Drawing.Size(260, 419);
            this.femaleBtn.TabIndex = 6;
            this.femaleBtn.Click += new System.EventHandler(this.femaleBtn_Click);
            // 
            // maleBtn
            // 
            this.maleBtn.BackgroundImage = global::GWT.Properties.Resources.maleGWT;
            this.maleBtn.CheckedState.ImageSize = new System.Drawing.Size(260, 419);
            this.maleBtn.CheckedState.Parent = this.maleBtn;
            this.maleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition.SetDecoration(this.maleBtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.maleBtn.HoverState.ImageSize = new System.Drawing.Size(260, 419);
            this.maleBtn.HoverState.Parent = this.maleBtn;
            this.maleBtn.ImageSize = new System.Drawing.Size(260, 419);
            this.maleBtn.Location = new System.Drawing.Point(205, 153);
            this.maleBtn.Name = "maleBtn";
            this.maleBtn.PressedState.ImageSize = new System.Drawing.Size(260, 419);
            this.maleBtn.PressedState.Parent = this.maleBtn;
            this.maleBtn.Size = new System.Drawing.Size(260, 419);
            this.maleBtn.TabIndex = 5;
            this.maleBtn.Click += new System.EventHandler(this.maleBtn_Click);
            // 
            // femaleLbl
            // 
            this.femaleLbl.AutoSize = true;
            this.transition.SetDecoration(this.femaleLbl, Guna.UI2.AnimatorNS.DecorationType.None);
            this.femaleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femaleLbl.ForeColor = System.Drawing.Color.White;
            this.femaleLbl.Location = new System.Drawing.Point(739, 125);
            this.femaleLbl.Name = "femaleLbl";
            this.femaleLbl.Size = new System.Drawing.Size(103, 25);
            this.femaleLbl.TabIndex = 4;
            this.femaleLbl.Text = "FEMALE";
            // 
            // maleLbl
            // 
            this.maleLbl.AutoSize = true;
            this.transition.SetDecoration(this.maleLbl, Guna.UI2.AnimatorNS.DecorationType.None);
            this.maleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maleLbl.ForeColor = System.Drawing.Color.White;
            this.maleLbl.Location = new System.Drawing.Point(276, 125);
            this.maleLbl.Name = "maleLbl";
            this.maleLbl.Size = new System.Drawing.Size(74, 25);
            this.maleLbl.TabIndex = 3;
            this.maleLbl.Text = "MALE";
            // 
            // timer
            // 
            this.timer.Interval = 50;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // transition
            // 
            this.transition.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Scale;
            this.transition.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.transition.DefaultAnimation = animation3;
            this.transition.MaxAnimationTime = 1000;
            // 
            // loadingScr
            // 
            this.loadingScr.BackColor = System.Drawing.Color.Transparent;
            this.transition.SetDecoration(this.loadingScr, Guna.UI2.AnimatorNS.DecorationType.None);
            this.loadingScr.Image = global::GWT.Properties.Resources.loadingAnimationGWT2;
            this.loadingScr.Location = new System.Drawing.Point(1150, 0);
            this.loadingScr.Name = "loadingScr";
            this.loadingScr.Size = new System.Drawing.Size(1102, 611);
            this.loadingScr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loadingScr.TabIndex = 15;
            this.loadingScr.TabStop = false;
            this.loadingScr.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LandingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.BackgroundImage = global::GWT.Properties.Resources.blurred_bg;
            this.ClientSize = new System.Drawing.Size(1102, 612);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.loadingScr);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel1);
            this.transition.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LandingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LandingForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadingScr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2HtmlLabel headerLbl;
        private Guna.UI2.WinForms.Guna2Panel mainPanel;
        private System.Windows.Forms.Label maleLbl;
        private Guna.UI2.WinForms.Guna2ImageButton femaleBtn;
        private Guna.UI2.WinForms.Guna2ImageButton maleBtn;
        private System.Windows.Forms.Label femaleLbl;
        private System.Windows.Forms.Timer timer;
        private Guna.UI2.WinForms.Guna2Transition transition;
        private Guna.UI2.WinForms.Guna2ImageButton BtnNext;
        private Guna.UI2.WinForms.Guna2ImageButton BtnBack;
        private System.Windows.Forms.PictureBox loadingScr;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}

