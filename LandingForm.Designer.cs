
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.headerLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.mainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.maleLbl = new System.Windows.Forms.Label();
            this.femaleLbl = new System.Windows.Forms.Label();
            this.maleBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.femaleBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.panel1.SuspendLayout();
            this.mainPanel.SuspendLayout();
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
            this.panel1.Controls.Add(this.guna2ImageButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1102, 40);
            this.panel1.TabIndex = 0;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.Parent = this.guna2ImageButton1;
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
            this.headerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 29.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLbl.ForeColor = System.Drawing.Color.White;
            this.headerLbl.Location = new System.Drawing.Point(309, 40);
            this.headerLbl.Name = "headerLbl";
            this.headerLbl.Size = new System.Drawing.Size(504, 46);
            this.headerLbl.TabIndex = 2;
            this.headerLbl.Text = "WHAT IS YOUR GENDER?";
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Transparent;
            this.mainPanel.Controls.Add(this.femaleBtn);
            this.mainPanel.Controls.Add(this.maleBtn);
            this.mainPanel.Controls.Add(this.femaleLbl);
            this.mainPanel.Controls.Add(this.maleLbl);
            this.mainPanel.Controls.Add(this.headerLbl);
            this.mainPanel.Location = new System.Drawing.Point(0, 38);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.ShadowDecoration.Parent = this.mainPanel;
            this.mainPanel.Size = new System.Drawing.Size(1102, 575);
            this.mainPanel.TabIndex = 3;
            // 
            // maleLbl
            // 
            this.maleLbl.AutoSize = true;
            this.maleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maleLbl.ForeColor = System.Drawing.Color.White;
            this.maleLbl.Location = new System.Drawing.Point(276, 125);
            this.maleLbl.Name = "maleLbl";
            this.maleLbl.Size = new System.Drawing.Size(74, 25);
            this.maleLbl.TabIndex = 3;
            this.maleLbl.Text = "MALE";
            // 
            // femaleLbl
            // 
            this.femaleLbl.AutoSize = true;
            this.femaleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femaleLbl.ForeColor = System.Drawing.Color.White;
            this.femaleLbl.Location = new System.Drawing.Point(739, 125);
            this.femaleLbl.Name = "femaleLbl";
            this.femaleLbl.Size = new System.Drawing.Size(103, 25);
            this.femaleLbl.TabIndex = 4;
            this.femaleLbl.Text = "FEMALE";
            // 
            // maleBtn
            // 
            this.maleBtn.CheckedState.ImageSize = new System.Drawing.Size(260, 419);
            this.maleBtn.CheckedState.Parent = this.maleBtn;
            this.maleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maleBtn.HoverState.ImageSize = new System.Drawing.Size(260, 419);
            this.maleBtn.HoverState.Parent = this.maleBtn;
            this.maleBtn.Image = global::GWT.Properties.Resources.maleGWT;
            this.maleBtn.ImageSize = new System.Drawing.Size(260, 419);
            this.maleBtn.Location = new System.Drawing.Point(205, 153);
            this.maleBtn.Name = "maleBtn";
            this.maleBtn.PressedState.Parent = this.maleBtn;
            this.maleBtn.Size = new System.Drawing.Size(260, 419);
            this.maleBtn.TabIndex = 5;
            // 
            // femaleBtn
            // 
            this.femaleBtn.CheckedState.ImageSize = new System.Drawing.Size(260, 419);
            this.femaleBtn.CheckedState.Parent = this.femaleBtn;
            this.femaleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.femaleBtn.HoverState.ImageSize = new System.Drawing.Size(260, 419);
            this.femaleBtn.HoverState.Parent = this.femaleBtn;
            this.femaleBtn.Image = global::GWT.Properties.Resources.femaleGWT;
            this.femaleBtn.ImageSize = new System.Drawing.Size(260, 419);
            this.femaleBtn.Location = new System.Drawing.Point(656, 153);
            this.femaleBtn.Name = "femaleBtn";
            this.femaleBtn.PressedState.Parent = this.femaleBtn;
            this.femaleBtn.Size = new System.Drawing.Size(260, 419);
            this.femaleBtn.TabIndex = 6;
            // 
            // LandingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GWT.Properties.Resources.blurred_bg;
            this.ClientSize = new System.Drawing.Size(1102, 612);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LandingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LandingForm_Load);
            this.panel1.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2HtmlLabel headerLbl;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Panel mainPanel;
        private System.Windows.Forms.Label maleLbl;
        private Guna.UI2.WinForms.Guna2ImageButton femaleBtn;
        private Guna.UI2.WinForms.Guna2ImageButton maleBtn;
        private System.Windows.Forms.Label femaleLbl;
    }
}

