
namespace GWT
{
    partial class BMI
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
            this.BmiContent = new Guna.UI2.WinForms.Guna2Panel();
            this.BmiPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnKg = new Guna.UI2.WinForms.Guna2Button();
            this.btnLb = new Guna.UI2.WinForms.Guna2Button();
            this.btnM = new Guna.UI2.WinForms.Guna2Button();
            this.btnFt = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWeight = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtHeight = new Guna.UI2.WinForms.Guna2TextBox();
            this.headerLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Resultpanel = new Guna.UI2.WinForms.Guna2Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.Bmilabel = new System.Windows.Forms.Label();
            this.Commentlabel = new System.Windows.Forms.Label();
            this.BmiContent.SuspendLayout();
            this.BmiPanel.SuspendLayout();
            this.Resultpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BmiContent
            // 
            this.BmiContent.Controls.Add(this.label4);
            this.BmiContent.Controls.Add(this.Resultpanel);
            this.BmiContent.Controls.Add(this.BmiPanel);
            this.BmiContent.Controls.Add(this.btnKg);
            this.BmiContent.Controls.Add(this.btnLb);
            this.BmiContent.Controls.Add(this.btnM);
            this.BmiContent.Controls.Add(this.btnFt);
            this.BmiContent.Controls.Add(this.label2);
            this.BmiContent.Controls.Add(this.label1);
            this.BmiContent.Controls.Add(this.txtWeight);
            this.BmiContent.Controls.Add(this.txtHeight);
            this.BmiContent.Controls.Add(this.headerLbl);
            this.BmiContent.Location = new System.Drawing.Point(0, 0);
            this.BmiContent.Name = "BmiContent";
            this.BmiContent.ShadowDecoration.Parent = this.BmiContent;
            this.BmiContent.Size = new System.Drawing.Size(1099, 577);
            this.BmiContent.TabIndex = 1;
            this.BmiContent.Paint += new System.Windows.Forms.PaintEventHandler(this.BmiContent_Paint);
            // 
            // BmiPanel
            // 
            this.BmiPanel.BackColor = System.Drawing.Color.Transparent;
            this.BmiPanel.BorderRadius = 15;
            this.BmiPanel.Controls.Add(this.label3);
            this.BmiPanel.FillColor = System.Drawing.Color.White;
            this.BmiPanel.Location = new System.Drawing.Point(443, 336);
            this.BmiPanel.Name = "BmiPanel";
            this.BmiPanel.ShadowDecoration.Parent = this.BmiPanel;
            this.BmiPanel.Size = new System.Drawing.Size(201, 32);
            this.BmiPanel.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "YOUR CURRENT BMI";
            // 
            // btnKg
            // 
            this.btnKg.BackColor = System.Drawing.Color.Transparent;
            this.btnKg.BorderColor = System.Drawing.Color.White;
            this.btnKg.BorderRadius = 12;
            this.btnKg.BorderThickness = 1;
            this.btnKg.CheckedState.Parent = this.btnKg;
            this.btnKg.CustomImages.Parent = this.btnKg;
            this.btnKg.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(105)))), ((int)(((byte)(114)))));
            this.btnKg.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnKg.ForeColor = System.Drawing.Color.White;
            this.btnKg.HoverState.Parent = this.btnKg;
            this.btnKg.Location = new System.Drawing.Point(658, 280);
            this.btnKg.Name = "btnKg";
            this.btnKg.ShadowDecoration.Parent = this.btnKg;
            this.btnKg.Size = new System.Drawing.Size(47, 26);
            this.btnKg.TabIndex = 21;
            this.btnKg.Text = "kg";
            this.btnKg.UseTransparentBackground = true;
            this.btnKg.Click += new System.EventHandler(this.kgBtn_Click);
            // 
            // btnLb
            // 
            this.btnLb.BackColor = System.Drawing.Color.Transparent;
            this.btnLb.BorderColor = System.Drawing.Color.White;
            this.btnLb.BorderRadius = 12;
            this.btnLb.CheckedState.Parent = this.btnLb;
            this.btnLb.CustomImages.Parent = this.btnLb;
            this.btnLb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(44)))), ((int)(((byte)(87)))));
            this.btnLb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLb.ForeColor = System.Drawing.Color.White;
            this.btnLb.HoverState.Parent = this.btnLb;
            this.btnLb.Location = new System.Drawing.Point(693, 280);
            this.btnLb.Name = "btnLb";
            this.btnLb.ShadowDecoration.Parent = this.btnLb;
            this.btnLb.Size = new System.Drawing.Size(47, 26);
            this.btnLb.TabIndex = 22;
            this.btnLb.Text = "lbs";
            this.btnLb.UseTransparentBackground = true;
            this.btnLb.Click += new System.EventHandler(this.lbsBtn_Click);
            // 
            // btnM
            // 
            this.btnM.BackColor = System.Drawing.Color.Transparent;
            this.btnM.BorderColor = System.Drawing.Color.White;
            this.btnM.BorderRadius = 12;
            this.btnM.BorderThickness = 1;
            this.btnM.CheckedState.Parent = this.btnM;
            this.btnM.CustomImages.Parent = this.btnM;
            this.btnM.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(105)))), ((int)(((byte)(114)))));
            this.btnM.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnM.ForeColor = System.Drawing.Color.White;
            this.btnM.HoverState.Parent = this.btnM;
            this.btnM.Location = new System.Drawing.Point(328, 280);
            this.btnM.Name = "btnM";
            this.btnM.ShadowDecoration.Parent = this.btnM;
            this.btnM.Size = new System.Drawing.Size(47, 26);
            this.btnM.TabIndex = 19;
            this.btnM.Text = "m";
            this.btnM.UseTransparentBackground = true;
            this.btnM.Click += new System.EventHandler(this.cmBtn_Click);
            // 
            // btnFt
            // 
            this.btnFt.BackColor = System.Drawing.Color.Transparent;
            this.btnFt.BorderColor = System.Drawing.Color.White;
            this.btnFt.BorderRadius = 12;
            this.btnFt.CheckedState.Parent = this.btnFt;
            this.btnFt.CustomImages.Parent = this.btnFt;
            this.btnFt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(44)))), ((int)(((byte)(87)))));
            this.btnFt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFt.ForeColor = System.Drawing.Color.White;
            this.btnFt.HoverState.Parent = this.btnFt;
            this.btnFt.Location = new System.Drawing.Point(363, 280);
            this.btnFt.Name = "btnFt";
            this.btnFt.ShadowDecoration.Parent = this.btnFt;
            this.btnFt.Size = new System.Drawing.Size(47, 26);
            this.btnFt.TabIndex = 20;
            this.btnFt.Text = "ft";
            this.btnFt.UseTransparentBackground = true;
            this.btnFt.Click += new System.EventHandler(this.ftBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(624, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "WEIGHT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(304, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "HEIGHT (m)";
            // 
            // txtWeight
            // 
            this.txtWeight.BorderRadius = 10;
            this.txtWeight.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtWeight.DefaultText = "";
            this.txtWeight.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtWeight.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtWeight.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtWeight.DisabledState.Parent = this.txtWeight;
            this.txtWeight.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtWeight.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtWeight.FocusedState.Parent = this.txtWeight;
            this.txtWeight.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtWeight.HoverState.Parent = this.txtWeight;
            this.txtWeight.Location = new System.Drawing.Point(618, 212);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.PasswordChar = '\0';
            this.txtWeight.PlaceholderText = "";
            this.txtWeight.SelectedText = "";
            this.txtWeight.ShadowDecoration.Parent = this.txtWeight;
            this.txtWeight.Size = new System.Drawing.Size(167, 51);
            this.txtWeight.TabIndex = 16;
            this.txtWeight.TextChanged += new System.EventHandler(this.txtWeight_TextChanged);
            this.txtWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.weightTxt_KeyPress);
            // 
            // txtHeight
            // 
            this.txtHeight.BorderRadius = 10;
            this.txtHeight.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHeight.DefaultText = "";
            this.txtHeight.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHeight.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHeight.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHeight.DisabledState.Parent = this.txtHeight;
            this.txtHeight.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHeight.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHeight.FocusedState.Parent = this.txtHeight;
            this.txtHeight.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHeight.HoverState.Parent = this.txtHeight;
            this.txtHeight.Location = new System.Drawing.Point(297, 212);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.PasswordChar = '\0';
            this.txtHeight.PlaceholderText = "";
            this.txtHeight.SelectedText = "";
            this.txtHeight.ShadowDecoration.Parent = this.txtHeight;
            this.txtHeight.Size = new System.Drawing.Size(167, 51);
            this.txtHeight.TabIndex = 15;
            this.txtHeight.TextChanged += new System.EventHandler(this.txtHeight_TextChanged);
            this.txtHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.heightTxt_KeyPress);
            // 
            // headerLbl
            // 
            this.headerLbl.AutoSize = false;
            this.headerLbl.BackColor = System.Drawing.Color.Transparent;
            this.headerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 29.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLbl.ForeColor = System.Drawing.Color.White;
            this.headerLbl.Location = new System.Drawing.Point(321, 40);
            this.headerLbl.Name = "headerLbl";
            this.headerLbl.Size = new System.Drawing.Size(454, 93);
            this.headerLbl.TabIndex = 3;
            this.headerLbl.Text = "WHAT’S YOUR HEIGHT AND WEIGHT?";
            this.headerLbl.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Resultpanel
            // 
            this.Resultpanel.BorderRadius = 20;
            this.Resultpanel.Controls.Add(this.Commentlabel);
            this.Resultpanel.Controls.Add(this.Bmilabel);
            this.Resultpanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(85)))), ((int)(((byte)(44)))), ((int)(((byte)(87)))));
            this.Resultpanel.Location = new System.Drawing.Point(443, 395);
            this.Resultpanel.Name = "Resultpanel";
            this.Resultpanel.ShadowDecoration.Parent = this.Resultpanel;
            this.Resultpanel.Size = new System.Drawing.Size(200, 70);
            this.Resultpanel.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "label4";
            // 
            // Bmilabel
            // 
            this.Bmilabel.AutoSize = true;
            this.Bmilabel.BackColor = System.Drawing.Color.Transparent;
            this.Bmilabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bmilabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(105)))), ((int)(((byte)(114)))));
            this.Bmilabel.Location = new System.Drawing.Point(14, 19);
            this.Bmilabel.Name = "Bmilabel";
            this.Bmilabel.Size = new System.Drawing.Size(63, 32);
            this.Bmilabel.TabIndex = 0;
            this.Bmilabel.Text = "22.1";
            this.Bmilabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Bmilabel.Visible = false;
            // 
            // Commentlabel
            // 
            this.Commentlabel.BackColor = System.Drawing.Color.Transparent;
            this.Commentlabel.CausesValidation = false;
            this.Commentlabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Commentlabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Commentlabel.ForeColor = System.Drawing.Color.White;
            this.Commentlabel.Location = new System.Drawing.Point(72, 0);
            this.Commentlabel.Name = "Commentlabel";
            this.Commentlabel.Size = new System.Drawing.Size(129, 70);
            this.Commentlabel.TabIndex = 1;
            this.Commentlabel.Text = "You gor a great figure";
            this.Commentlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Commentlabel.Visible = false;
            this.Commentlabel.TextChanged += new System.EventHandler(this.Commentlabel_TextChanged);
            // 
            // BMI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1102, 612);
            this.Controls.Add(this.BmiContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BMI";
            this.Text = "BMI";
            this.Load += new System.EventHandler(this.BMI_Load);
            this.BmiContent.ResumeLayout(false);
            this.BmiContent.PerformLayout();
            this.BmiPanel.ResumeLayout(false);
            this.BmiPanel.PerformLayout();
            this.Resultpanel.ResumeLayout(false);
            this.Resultpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2Panel BmiContent;
        private Guna.UI2.WinForms.Guna2HtmlLabel headerLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtWeight;
        private Guna.UI2.WinForms.Guna2TextBox txtHeight;
        private Guna.UI2.WinForms.Guna2Button btnM;
        private Guna.UI2.WinForms.Guna2Button btnFt;
        private Guna.UI2.WinForms.Guna2Button btnKg;
        private Guna.UI2.WinForms.Guna2Button btnLb;
        private System.Windows.Forms.Label label3;
        public Guna.UI2.WinForms.Guna2Panel BmiPanel;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Panel Resultpanel;
        private System.Windows.Forms.Label Bmilabel;
        private System.Windows.Forms.Label Commentlabel;
    }
}