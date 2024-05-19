
namespace GWT
{
    partial class signUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signUpForm));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel = new Guna.UI2.WinForms.Guna2Panel();
            this.Header = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.userTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.UserLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.passLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.passTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.ConLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ConPassTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.loginLink = new System.Windows.Forms.LinkLabel();
            this.SignUpBtn = new Guna.UI2.WinForms.Guna2Button();
            this.skipLink = new System.Windows.Forms.LinkLabel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.loading = new System.Windows.Forms.PictureBox();
            this.conEye = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.passEye = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.closeBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loading)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.guna2CircleButton1);
            this.panel.Controls.Add(this.closeBtn);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.ShadowDecoration.Parent = this.panel;
            this.panel.Size = new System.Drawing.Size(500, 40);
            this.panel.TabIndex = 0;
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.Transparent;
            this.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.ForeColor = System.Drawing.Color.White;
            this.Header.Location = new System.Drawing.Point(123, 27);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(234, 31);
            this.Header.TabIndex = 1;
            this.Header.Text = "MAKE AN ACCOUNT";
            this.Header.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userTxt
            // 
            this.userTxt.BorderRadius = 10;
            this.userTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userTxt.DefaultText = "";
            this.userTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.userTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.userTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userTxt.DisabledState.Parent = this.userTxt;
            this.userTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userTxt.FocusedState.Parent = this.userTxt;
            this.userTxt.ForeColor = System.Drawing.Color.Black;
            this.userTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userTxt.HoverState.Parent = this.userTxt;
            this.userTxt.Location = new System.Drawing.Point(126, 99);
            this.userTxt.Name = "userTxt";
            this.userTxt.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.userTxt.PasswordChar = '\0';
            this.userTxt.PlaceholderText = "";
            this.userTxt.SelectedText = "";
            this.userTxt.ShadowDecoration.Parent = this.userTxt;
            this.userTxt.Size = new System.Drawing.Size(231, 35);
            this.userTxt.TabIndex = 2;
            // 
            // UserLbl
            // 
            this.UserLbl.BackColor = System.Drawing.Color.Transparent;
            this.UserLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLbl.ForeColor = System.Drawing.Color.White;
            this.UserLbl.Location = new System.Drawing.Point(126, 80);
            this.UserLbl.Name = "UserLbl";
            this.UserLbl.Size = new System.Drawing.Size(104, 15);
            this.UserLbl.TabIndex = 3;
            this.UserLbl.Text = "ENTER USERNAME";
            // 
            // passLbl
            // 
            this.passLbl.BackColor = System.Drawing.Color.Transparent;
            this.passLbl.ForeColor = System.Drawing.Color.White;
            this.passLbl.Location = new System.Drawing.Point(126, 140);
            this.passLbl.Name = "passLbl";
            this.passLbl.Size = new System.Drawing.Size(106, 15);
            this.passLbl.TabIndex = 5;
            this.passLbl.Text = "ENTER PASSWORD";
            // 
            // passTxt
            // 
            this.passTxt.BorderRadius = 10;
            this.passTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passTxt.DefaultText = "";
            this.passTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passTxt.DisabledState.Parent = this.passTxt;
            this.passTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passTxt.FocusedState.Parent = this.passTxt;
            this.passTxt.ForeColor = System.Drawing.Color.Black;
            this.passTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passTxt.HoverState.Parent = this.passTxt;
            this.passTxt.Location = new System.Drawing.Point(126, 160);
            this.passTxt.Name = "passTxt";
            this.passTxt.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.passTxt.PasswordChar = '•';
            this.passTxt.PlaceholderText = "";
            this.passTxt.SelectedText = "";
            this.passTxt.ShadowDecoration.Parent = this.passTxt;
            this.passTxt.Size = new System.Drawing.Size(231, 35);
            this.passTxt.TabIndex = 4;
            // 
            // ConLbl
            // 
            this.ConLbl.BackColor = System.Drawing.Color.Transparent;
            this.ConLbl.ForeColor = System.Drawing.Color.White;
            this.ConLbl.Location = new System.Drawing.Point(126, 205);
            this.ConLbl.Name = "ConLbl";
            this.ConLbl.Size = new System.Drawing.Size(118, 15);
            this.ConLbl.TabIndex = 7;
            this.ConLbl.Text = "CONFIRM PASSWORD";
            // 
            // ConPassTxt
            // 
            this.ConPassTxt.BorderRadius = 10;
            this.ConPassTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ConPassTxt.DefaultText = "";
            this.ConPassTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ConPassTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ConPassTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ConPassTxt.DisabledState.Parent = this.ConPassTxt;
            this.ConPassTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ConPassTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ConPassTxt.FocusedState.Parent = this.ConPassTxt;
            this.ConPassTxt.ForeColor = System.Drawing.Color.Black;
            this.ConPassTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ConPassTxt.HoverState.Parent = this.ConPassTxt;
            this.ConPassTxt.Location = new System.Drawing.Point(126, 225);
            this.ConPassTxt.Name = "ConPassTxt";
            this.ConPassTxt.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ConPassTxt.PasswordChar = '•';
            this.ConPassTxt.PlaceholderText = "";
            this.ConPassTxt.SelectedText = "";
            this.ConPassTxt.ShadowDecoration.Parent = this.ConPassTxt;
            this.ConPassTxt.Size = new System.Drawing.Size(231, 35);
            this.ConPassTxt.TabIndex = 6;
            // 
            // loginLink
            // 
            this.loginLink.AutoSize = true;
            this.loginLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.loginLink.LinkColor = System.Drawing.Color.White;
            this.loginLink.Location = new System.Drawing.Point(156, 273);
            this.loginLink.Name = "loginLink";
            this.loginLink.Size = new System.Drawing.Size(136, 13);
            this.loginLink.TabIndex = 8;
            this.loginLink.TabStop = true;
            this.loginLink.Text = "Already Have An Account?";
            this.loginLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.loginLink_LinkClicked);
            // 
            // SignUpBtn
            // 
            this.SignUpBtn.BorderRadius = 11;
            this.SignUpBtn.CheckedState.Parent = this.SignUpBtn;
            this.SignUpBtn.CustomImages.Parent = this.SignUpBtn;
            this.SignUpBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(105)))), ((int)(((byte)(114)))));
            this.SignUpBtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpBtn.ForeColor = System.Drawing.Color.White;
            this.SignUpBtn.HoverState.Parent = this.SignUpBtn;
            this.SignUpBtn.Location = new System.Drawing.Point(126, 300);
            this.SignUpBtn.Name = "SignUpBtn";
            this.SignUpBtn.ShadowDecoration.Parent = this.SignUpBtn;
            this.SignUpBtn.Size = new System.Drawing.Size(231, 45);
            this.SignUpBtn.TabIndex = 10;
            this.SignUpBtn.Text = "Sign Up";
            this.SignUpBtn.Click += new System.EventHandler(this.SignUpBtn_Click);
            // 
            // skipLink
            // 
            this.skipLink.AutoSize = true;
            this.skipLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.skipLink.LinkColor = System.Drawing.Color.White;
            this.skipLink.Location = new System.Drawing.Point(22, 332);
            this.skipLink.Name = "skipLink";
            this.skipLink.Size = new System.Drawing.Size(28, 13);
            this.skipLink.TabIndex = 11;
            this.skipLink.TabStop = true;
            this.skipLink.Text = "Skip";
            this.skipLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.skipLink_LinkClicked);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.panel;
            // 
            // timer
            // 
            this.timer.Interval = 2500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // loading
            // 
            this.loading.BackColor = System.Drawing.Color.Transparent;
            this.loading.Image = global::GWT.Properties.Resources.loadingAnimationGWT1;
            this.loading.Location = new System.Drawing.Point(501, 0);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(500, 370);
            this.loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loading.TabIndex = 14;
            this.loading.TabStop = false;
            this.loading.Visible = false;
            // 
            // conEye
            // 
            this.conEye.CheckedState.Image = global::GWT.Properties.Resources.eye_closed;
            this.conEye.CheckedState.Parent = this.conEye;
            this.conEye.HoverState.Parent = this.conEye;
            this.conEye.Image = global::GWT.Properties.Resources.eye_open;
            this.conEye.Location = new System.Drawing.Point(363, 231);
            this.conEye.Name = "conEye";
            this.conEye.PressedState.Parent = this.conEye;
            this.conEye.Size = new System.Drawing.Size(27, 23);
            this.conEye.TabIndex = 13;
            this.conEye.CheckedChanged += new System.EventHandler(this.conEye_CheckedChanged);
            // 
            // passEye
            // 
            this.passEye.CheckedState.Image = global::GWT.Properties.Resources.eye_closed;
            this.passEye.CheckedState.Parent = this.passEye;
            this.passEye.HoverState.Parent = this.passEye;
            this.passEye.Image = global::GWT.Properties.Resources.eye_open;
            this.passEye.Location = new System.Drawing.Point(363, 166);
            this.passEye.Name = "passEye";
            this.passEye.PressedState.Parent = this.passEye;
            this.passEye.Size = new System.Drawing.Size(27, 23);
            this.passEye.TabIndex = 12;
            this.passEye.CheckedChanged += new System.EventHandler(this.passEye_CheckedChanged);
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.CheckedState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.CustomImages.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.FillColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.HoverState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Image = global::GWT.Properties.Resources.minimizeRed;
            this.guna2CircleButton1.Location = new System.Drawing.Point(432, 8);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.ShadowDecoration.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Size = new System.Drawing.Size(25, 25);
            this.guna2CircleButton1.TabIndex = 2;
            this.guna2CircleButton1.Click += new System.EventHandler(this.guna2CircleButton1_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.CheckedState.Parent = this.closeBtn;
            this.closeBtn.HoverState.Parent = this.closeBtn;
            this.closeBtn.Image = global::GWT.Properties.Resources.closeBtn;
            this.closeBtn.Location = new System.Drawing.Point(463, 8);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.PressedState.Parent = this.closeBtn;
            this.closeBtn.Size = new System.Drawing.Size(25, 25);
            this.closeBtn.TabIndex = 1;
            this.closeBtn.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // signUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(500, 368);
            this.Controls.Add(this.loading);
            this.Controls.Add(this.conEye);
            this.Controls.Add(this.passEye);
            this.Controls.Add(this.skipLink);
            this.Controls.Add(this.SignUpBtn);
            this.Controls.Add(this.loginLink);
            this.Controls.Add(this.ConLbl);
            this.Controls.Add(this.ConPassTxt);
            this.Controls.Add(this.passLbl);
            this.Controls.Add(this.passTxt);
            this.Controls.Add(this.UserLbl);
            this.Controls.Add(this.userTxt);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "signUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "signUpForm";
            this.Load += new System.EventHandler(this.signUpForm_Load);
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.loading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2HtmlLabel Header;
        private Guna.UI2.WinForms.Guna2Panel panel;
        private Guna.UI2.WinForms.Guna2ImageButton closeBtn;
        private System.Windows.Forms.LinkLabel skipLink;
        private Guna.UI2.WinForms.Guna2Button SignUpBtn;
        private System.Windows.Forms.LinkLabel loginLink;
        private Guna.UI2.WinForms.Guna2HtmlLabel ConLbl;
        private Guna.UI2.WinForms.Guna2TextBox ConPassTxt;
        private Guna.UI2.WinForms.Guna2HtmlLabel passLbl;
        private Guna.UI2.WinForms.Guna2TextBox passTxt;
        private Guna.UI2.WinForms.Guna2HtmlLabel UserLbl;
        private Guna.UI2.WinForms.Guna2TextBox userTxt;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ImageCheckBox passEye;
        private Guna.UI2.WinForms.Guna2ImageCheckBox conEye;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox loading;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
    }
}