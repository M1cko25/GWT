
namespace GWT
{
    partial class Login
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.skipLink = new System.Windows.Forms.LinkLabel();
            this.loginBtn = new Guna.UI2.WinForms.Guna2Button();
            this.signUpLink = new System.Windows.Forms.LinkLabel();
            this.passLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.passTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.UserLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.userTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.Header = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.forgotpass = new System.Windows.Forms.LinkLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.loading = new System.Windows.Forms.PictureBox();
            this.passEye = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.closeBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loading)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // skipLink
            // 
            this.skipLink.AutoSize = true;
            this.skipLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.skipLink.LinkColor = System.Drawing.Color.White;
            this.skipLink.Location = new System.Drawing.Point(22, 344);
            this.skipLink.Name = "skipLink";
            this.skipLink.Size = new System.Drawing.Size(28, 13);
            this.skipLink.TabIndex = 21;
            this.skipLink.TabStop = true;
            this.skipLink.Text = "Skip";
            this.skipLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.skipLink_LinkClicked);
            // 
            // loginBtn
            // 
            this.loginBtn.BorderRadius = 11;
            this.loginBtn.CheckedState.Parent = this.loginBtn;
            this.loginBtn.CustomImages.Parent = this.loginBtn;
            this.loginBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(105)))), ((int)(((byte)(114)))));
            this.loginBtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.HoverState.Parent = this.loginBtn;
            this.loginBtn.Location = new System.Drawing.Point(126, 256);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.ShadowDecoration.Parent = this.loginBtn;
            this.loginBtn.Size = new System.Drawing.Size(231, 45);
            this.loginBtn.TabIndex = 20;
            this.loginBtn.Text = "Log In";
            this.loginBtn.Click += new System.EventHandler(this.SignUpBtn_Click);
            // 
            // signUpLink
            // 
            this.signUpLink.AutoSize = true;
            this.signUpLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.signUpLink.LinkColor = System.Drawing.Color.White;
            this.signUpLink.Location = new System.Drawing.Point(156, 229);
            this.signUpLink.Name = "signUpLink";
            this.signUpLink.Size = new System.Drawing.Size(126, 13);
            this.signUpLink.TabIndex = 19;
            this.signUpLink.TabStop = true;
            this.signUpLink.Text = "Don\'t Have An Account?";
            this.signUpLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signUpLink_LinkClicked);
            // 
            // passLbl
            // 
            this.passLbl.BackColor = System.Drawing.Color.Transparent;
            this.passLbl.ForeColor = System.Drawing.Color.White;
            this.passLbl.Location = new System.Drawing.Point(126, 152);
            this.passLbl.Name = "passLbl";
            this.passLbl.Size = new System.Drawing.Size(106, 15);
            this.passLbl.TabIndex = 18;
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
            this.passTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passTxt.HoverState.Parent = this.passTxt;
            this.passTxt.Location = new System.Drawing.Point(126, 172);
            this.passTxt.Name = "passTxt";
            this.passTxt.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.passTxt.PasswordChar = '•';
            this.passTxt.PlaceholderText = "";
            this.passTxt.SelectedText = "";
            this.passTxt.ShadowDecoration.Parent = this.passTxt;
            this.passTxt.Size = new System.Drawing.Size(231, 35);
            this.passTxt.TabIndex = 17;
            // 
            // UserLbl
            // 
            this.UserLbl.BackColor = System.Drawing.Color.Transparent;
            this.UserLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLbl.ForeColor = System.Drawing.Color.White;
            this.UserLbl.Location = new System.Drawing.Point(126, 92);
            this.UserLbl.Name = "UserLbl";
            this.UserLbl.Size = new System.Drawing.Size(104, 15);
            this.UserLbl.TabIndex = 16;
            this.UserLbl.Text = "ENTER USERNAME";
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
            this.userTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userTxt.HoverState.Parent = this.userTxt;
            this.userTxt.Location = new System.Drawing.Point(126, 111);
            this.userTxt.Name = "userTxt";
            this.userTxt.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.userTxt.PasswordChar = '\0';
            this.userTxt.PlaceholderText = "";
            this.userTxt.SelectedText = "";
            this.userTxt.ShadowDecoration.Parent = this.userTxt;
            this.userTxt.Size = new System.Drawing.Size(231, 35);
            this.userTxt.TabIndex = 15;
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.Transparent;
            this.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.ForeColor = System.Drawing.Color.White;
            this.Header.Location = new System.Drawing.Point(123, 39);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(236, 31);
            this.Header.TabIndex = 14;
            this.Header.Text = "OPEN AN ACCOUNT";
            this.Header.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.Header.Click += new System.EventHandler(this.Header_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.closeBtn);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.ShadowDecoration.Parent = this.panel;
            this.panel.Size = new System.Drawing.Size(500, 40);
            this.panel.TabIndex = 13;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.panel;
            // 
            // forgotpass
            // 
            this.forgotpass.AutoSize = true;
            this.forgotpass.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.forgotpass.LinkColor = System.Drawing.Color.White;
            this.forgotpass.Location = new System.Drawing.Point(209, 304);
            this.forgotpass.Name = "forgotpass";
            this.forgotpass.Size = new System.Drawing.Size(92, 13);
            this.forgotpass.TabIndex = 23;
            this.forgotpass.TabStop = true;
            this.forgotpass.Text = "Forgot Password?";
            this.forgotpass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgotpass_LinkClicked);
            // 
            // timer
            // 
            this.timer.Interval = 3000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // loading
            // 
            this.loading.BackColor = System.Drawing.Color.Transparent;
            this.loading.Image = global::GWT.Properties.Resources.loadingAnimationGWT1;
            this.loading.Location = new System.Drawing.Point(500, 0);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(500, 367);
            this.loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loading.TabIndex = 25;
            this.loading.TabStop = false;
            this.loading.Visible = false;
            // 
            // passEye
            // 
            this.passEye.CheckedState.Image = global::GWT.Properties.Resources.eye_closed;
            this.passEye.CheckedState.Parent = this.passEye;
            this.passEye.HoverState.Parent = this.passEye;
            this.passEye.Image = global::GWT.Properties.Resources.eye_open;
            this.passEye.Location = new System.Drawing.Point(363, 178);
            this.passEye.Name = "passEye";
            this.passEye.PressedState.Parent = this.passEye;
            this.passEye.Size = new System.Drawing.Size(27, 23);
            this.passEye.TabIndex = 22;
            this.passEye.CheckedChanged += new System.EventHandler(this.passEye_CheckedChanged);
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
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(500, 368);
            this.Controls.Add(this.loading);
            this.Controls.Add(this.forgotpass);
            this.Controls.Add(this.passEye);
            this.Controls.Add(this.skipLink);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.signUpLink);
            this.Controls.Add(this.passLbl);
            this.Controls.Add(this.passTxt);
            this.Controls.Add(this.UserLbl);
            this.Controls.Add(this.userTxt);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.loading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ImageCheckBox passEye;
        private System.Windows.Forms.LinkLabel skipLink;
        private Guna.UI2.WinForms.Guna2Button loginBtn;
        private System.Windows.Forms.LinkLabel signUpLink;
        private Guna.UI2.WinForms.Guna2HtmlLabel passLbl;
        private Guna.UI2.WinForms.Guna2TextBox passTxt;
        private Guna.UI2.WinForms.Guna2HtmlLabel UserLbl;
        private Guna.UI2.WinForms.Guna2TextBox userTxt;
        private Guna.UI2.WinForms.Guna2HtmlLabel Header;
        private Guna.UI2.WinForms.Guna2Panel panel;
        private Guna.UI2.WinForms.Guna2ImageButton closeBtn;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.LinkLabel forgotpass;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox loading;
    }
}