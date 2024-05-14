
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
            this.headerLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.heightTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.weightTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ftBtn = new Guna.UI2.WinForms.Guna2Button();
            this.kgBtn = new Guna.UI2.WinForms.Guna2Button();
            this.lbsBtn = new Guna.UI2.WinForms.Guna2Button();
            this.BmiPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.BmiContent.SuspendLayout();
            this.BmiPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BmiContent
            // 
            this.BmiContent.Controls.Add(this.BmiPanel);
            this.BmiContent.Controls.Add(this.kgBtn);
            this.BmiContent.Controls.Add(this.lbsBtn);
            this.BmiContent.Controls.Add(this.cmBtn);
            this.BmiContent.Controls.Add(this.ftBtn);
            this.BmiContent.Controls.Add(this.label2);
            this.BmiContent.Controls.Add(this.label1);
            this.BmiContent.Controls.Add(this.weightTxt);
            this.BmiContent.Controls.Add(this.heightTxt);
            this.BmiContent.Controls.Add(this.headerLbl);
            this.BmiContent.Location = new System.Drawing.Point(0, 0);
            this.BmiContent.Name = "BmiContent";
            this.BmiContent.ShadowDecoration.Parent = this.BmiContent;
            this.BmiContent.Size = new System.Drawing.Size(1099, 577);
            this.BmiContent.TabIndex = 1;
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
            // heightTxt
            // 
            this.heightTxt.BorderRadius = 10;
            this.heightTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.heightTxt.DefaultText = "";
            this.heightTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.heightTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.heightTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.heightTxt.DisabledState.Parent = this.heightTxt;
            this.heightTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.heightTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.heightTxt.FocusedState.Parent = this.heightTxt;
            this.heightTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.heightTxt.HoverState.Parent = this.heightTxt;
            this.heightTxt.Location = new System.Drawing.Point(297, 212);
            this.heightTxt.Name = "heightTxt";
            this.heightTxt.PasswordChar = '\0';
            this.heightTxt.PlaceholderText = "";
            this.heightTxt.SelectedText = "";
            this.heightTxt.ShadowDecoration.Parent = this.heightTxt;
            this.heightTxt.Size = new System.Drawing.Size(167, 51);
            this.heightTxt.TabIndex = 15;
            this.heightTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.heightTxt_KeyPress);
            // 
            // weightTxt
            // 
            this.weightTxt.BorderRadius = 10;
            this.weightTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.weightTxt.DefaultText = "";
            this.weightTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.weightTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.weightTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.weightTxt.DisabledState.Parent = this.weightTxt;
            this.weightTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.weightTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.weightTxt.FocusedState.Parent = this.weightTxt;
            this.weightTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.weightTxt.HoverState.Parent = this.weightTxt;
            this.weightTxt.Location = new System.Drawing.Point(618, 212);
            this.weightTxt.Name = "weightTxt";
            this.weightTxt.PasswordChar = '\0';
            this.weightTxt.PlaceholderText = "";
            this.weightTxt.SelectedText = "";
            this.weightTxt.ShadowDecoration.Parent = this.weightTxt;
            this.weightTxt.Size = new System.Drawing.Size(167, 51);
            this.weightTxt.TabIndex = 16;
            this.weightTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.weightTxt_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(304, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "HEIGHT";
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
            // cmBtn
            // 
            this.cmBtn.BackColor = System.Drawing.Color.Transparent;
            this.cmBtn.BorderColor = System.Drawing.Color.White;
            this.cmBtn.BorderRadius = 12;
            this.cmBtn.BorderThickness = 1;
            this.cmBtn.CheckedState.Parent = this.cmBtn;
            this.cmBtn.CustomImages.Parent = this.cmBtn;
            this.cmBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(105)))), ((int)(((byte)(114)))));
            this.cmBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmBtn.ForeColor = System.Drawing.Color.White;
            this.cmBtn.HoverState.Parent = this.cmBtn;
            this.cmBtn.Location = new System.Drawing.Point(328, 280);
            this.cmBtn.Name = "cmBtn";
            this.cmBtn.ShadowDecoration.Parent = this.cmBtn;
            this.cmBtn.Size = new System.Drawing.Size(47, 26);
            this.cmBtn.TabIndex = 19;
            this.cmBtn.Text = "cm";
            this.cmBtn.UseTransparentBackground = true;
            this.cmBtn.Click += new System.EventHandler(this.cmBtn_Click);
            // 
            // ftBtn
            // 
            this.ftBtn.BackColor = System.Drawing.Color.Transparent;
            this.ftBtn.BorderColor = System.Drawing.Color.White;
            this.ftBtn.BorderRadius = 12;
            this.ftBtn.CheckedState.Parent = this.ftBtn;
            this.ftBtn.CustomImages.Parent = this.ftBtn;
            this.ftBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(44)))), ((int)(((byte)(87)))));
            this.ftBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ftBtn.ForeColor = System.Drawing.Color.White;
            this.ftBtn.HoverState.Parent = this.ftBtn;
            this.ftBtn.Location = new System.Drawing.Point(363, 280);
            this.ftBtn.Name = "ftBtn";
            this.ftBtn.ShadowDecoration.Parent = this.ftBtn;
            this.ftBtn.Size = new System.Drawing.Size(47, 26);
            this.ftBtn.TabIndex = 20;
            this.ftBtn.Text = "ft";
            this.ftBtn.UseTransparentBackground = true;
            this.ftBtn.Click += new System.EventHandler(this.ftBtn_Click);
            // 
            // kgBtn
            // 
            this.kgBtn.BackColor = System.Drawing.Color.Transparent;
            this.kgBtn.BorderColor = System.Drawing.Color.White;
            this.kgBtn.BorderRadius = 12;
            this.kgBtn.BorderThickness = 1;
            this.kgBtn.CheckedState.Parent = this.kgBtn;
            this.kgBtn.CustomImages.Parent = this.kgBtn;
            this.kgBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(105)))), ((int)(((byte)(114)))));
            this.kgBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.kgBtn.ForeColor = System.Drawing.Color.White;
            this.kgBtn.HoverState.Parent = this.kgBtn;
            this.kgBtn.Location = new System.Drawing.Point(658, 280);
            this.kgBtn.Name = "kgBtn";
            this.kgBtn.ShadowDecoration.Parent = this.kgBtn;
            this.kgBtn.Size = new System.Drawing.Size(47, 26);
            this.kgBtn.TabIndex = 21;
            this.kgBtn.Text = "kg";
            this.kgBtn.UseTransparentBackground = true;
            this.kgBtn.Click += new System.EventHandler(this.kgBtn_Click);
            // 
            // lbsBtn
            // 
            this.lbsBtn.BackColor = System.Drawing.Color.Transparent;
            this.lbsBtn.BorderColor = System.Drawing.Color.White;
            this.lbsBtn.BorderRadius = 12;
            this.lbsBtn.CheckedState.Parent = this.lbsBtn;
            this.lbsBtn.CustomImages.Parent = this.lbsBtn;
            this.lbsBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(44)))), ((int)(((byte)(87)))));
            this.lbsBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbsBtn.ForeColor = System.Drawing.Color.White;
            this.lbsBtn.HoverState.Parent = this.lbsBtn;
            this.lbsBtn.Location = new System.Drawing.Point(693, 280);
            this.lbsBtn.Name = "lbsBtn";
            this.lbsBtn.ShadowDecoration.Parent = this.lbsBtn;
            this.lbsBtn.Size = new System.Drawing.Size(47, 26);
            this.lbsBtn.TabIndex = 22;
            this.lbsBtn.Text = "lbs";
            this.lbsBtn.UseTransparentBackground = true;
            this.lbsBtn.Click += new System.EventHandler(this.lbsBtn_Click);
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
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2Panel BmiContent;
        private Guna.UI2.WinForms.Guna2HtmlLabel headerLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox weightTxt;
        private Guna.UI2.WinForms.Guna2TextBox heightTxt;
        private Guna.UI2.WinForms.Guna2Button cmBtn;
        private Guna.UI2.WinForms.Guna2Button ftBtn;
        private Guna.UI2.WinForms.Guna2Button kgBtn;
        private Guna.UI2.WinForms.Guna2Button lbsBtn;
        private System.Windows.Forms.Label label3;
        public Guna.UI2.WinForms.Guna2Panel BmiPanel;
    }
}