namespace passkeeper
{
    partial class AddPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPassword));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.LblShowPassword = new System.Windows.Forms.Label();
            this.btnSavePassword = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnGeneratePassword = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFormFadeTransition1 = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.CbShowPassword = new Bunifu.Framework.UI.BunifuCheckbox();
            this.TbPassword = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.TbUsername = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.topPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFormClose = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.TbDomain = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // LblShowPassword
            // 
            this.LblShowPassword.AutoSize = true;
            this.LblShowPassword.Location = new System.Drawing.Point(49, 360);
            this.LblShowPassword.Name = "LblShowPassword";
            this.LblShowPassword.Size = new System.Drawing.Size(77, 13);
            this.LblShowPassword.TabIndex = 113;
            this.LblShowPassword.Text = "Hide password";
            this.LblShowPassword.Click += new System.EventHandler(this.LblShowPassword_Click);
            // 
            // btnSavePassword
            // 
            this.btnSavePassword.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSavePassword.BackColor = System.Drawing.Color.LightSalmon;
            this.btnSavePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSavePassword.BorderRadius = 0;
            this.btnSavePassword.ButtonText = "Save Password";
            this.btnSavePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSavePassword.DisabledColor = System.Drawing.Color.Gray;
            this.btnSavePassword.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSavePassword.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSavePassword.Iconimage")));
            this.btnSavePassword.Iconimage_right = null;
            this.btnSavePassword.Iconimage_right_Selected = null;
            this.btnSavePassword.Iconimage_Selected = null;
            this.btnSavePassword.IconMarginLeft = 0;
            this.btnSavePassword.IconMarginRight = 0;
            this.btnSavePassword.IconRightVisible = true;
            this.btnSavePassword.IconRightZoom = 0D;
            this.btnSavePassword.IconVisible = false;
            this.btnSavePassword.IconZoom = 90D;
            this.btnSavePassword.IsTab = false;
            this.btnSavePassword.Location = new System.Drawing.Point(12, 379);
            this.btnSavePassword.Name = "btnSavePassword";
            this.btnSavePassword.Normalcolor = System.Drawing.Color.LightSalmon;
            this.btnSavePassword.OnHovercolor = System.Drawing.Color.Coral;
            this.btnSavePassword.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSavePassword.selected = false;
            this.btnSavePassword.Size = new System.Drawing.Size(475, 48);
            this.btnSavePassword.TabIndex = 106;
            this.btnSavePassword.Text = "Save Password";
            this.btnSavePassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSavePassword.Textcolor = System.Drawing.Color.White;
            this.btnSavePassword.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePassword.Click += new System.EventHandler(this.btnSavePassword_Click);
            // 
            // BtnGeneratePassword
            // 
            this.BtnGeneratePassword.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnGeneratePassword.BackColor = System.Drawing.Color.BurlyWood;
            this.BtnGeneratePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnGeneratePassword.BorderRadius = 0;
            this.BtnGeneratePassword.ButtonText = "Generate Password";
            this.BtnGeneratePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGeneratePassword.DisabledColor = System.Drawing.Color.Gray;
            this.BtnGeneratePassword.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnGeneratePassword.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnGeneratePassword.Iconimage")));
            this.BtnGeneratePassword.Iconimage_right = null;
            this.BtnGeneratePassword.Iconimage_right_Selected = null;
            this.BtnGeneratePassword.Iconimage_Selected = null;
            this.BtnGeneratePassword.IconMarginLeft = 0;
            this.BtnGeneratePassword.IconMarginRight = 0;
            this.BtnGeneratePassword.IconRightVisible = true;
            this.BtnGeneratePassword.IconRightZoom = 0D;
            this.BtnGeneratePassword.IconVisible = false;
            this.BtnGeneratePassword.IconZoom = 90D;
            this.BtnGeneratePassword.IsTab = false;
            this.BtnGeneratePassword.Location = new System.Drawing.Point(17, 299);
            this.BtnGeneratePassword.Name = "BtnGeneratePassword";
            this.BtnGeneratePassword.Normalcolor = System.Drawing.Color.BurlyWood;
            this.BtnGeneratePassword.OnHovercolor = System.Drawing.Color.Peru;
            this.BtnGeneratePassword.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnGeneratePassword.selected = false;
            this.BtnGeneratePassword.Size = new System.Drawing.Size(368, 48);
            this.BtnGeneratePassword.TabIndex = 107;
            this.BtnGeneratePassword.Text = "Generate Password";
            this.BtnGeneratePassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnGeneratePassword.Textcolor = System.Drawing.Color.White;
            this.BtnGeneratePassword.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGeneratePassword.Click += new System.EventHandler(this.BtnGeneratePassword_Click);
            // 
            // bunifuFormFadeTransition1
            // 
            this.bunifuFormFadeTransition1.Delay = 1;
            // 
            // CbShowPassword
            // 
            this.CbShowPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.CbShowPassword.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.CbShowPassword.Checked = true;
            this.CbShowPassword.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.CbShowPassword.ForeColor = System.Drawing.Color.White;
            this.CbShowPassword.Location = new System.Drawing.Point(17, 353);
            this.CbShowPassword.Name = "CbShowPassword";
            this.CbShowPassword.Size = new System.Drawing.Size(20, 20);
            this.CbShowPassword.TabIndex = 112;
            this.CbShowPassword.OnChange += new System.EventHandler(this.CbShowPassword_OnChange);
            // 
            // TbPassword
            // 
            this.TbPassword.BorderColorFocused = System.Drawing.Color.Blue;
            this.TbPassword.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TbPassword.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.TbPassword.BorderThickness = 3;
            this.TbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TbPassword.isPassword = true;
            this.TbPassword.Location = new System.Drawing.Point(13, 238);
            this.TbPassword.Margin = new System.Windows.Forms.Padding(4);
            this.TbPassword.Name = "TbPassword";
            this.TbPassword.Size = new System.Drawing.Size(370, 44);
            this.TbPassword.TabIndex = 105;
            this.TbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 109;
            this.label3.Text = "Password";
            // 
            // TbUsername
            // 
            this.TbUsername.BorderColorFocused = System.Drawing.Color.Blue;
            this.TbUsername.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TbUsername.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.TbUsername.BorderThickness = 3;
            this.TbUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TbUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TbUsername.isPassword = false;
            this.TbUsername.Location = new System.Drawing.Point(13, 169);
            this.TbUsername.Margin = new System.Windows.Forms.Padding(4);
            this.TbUsername.Name = "TbUsername";
            this.TbUsername.Size = new System.Drawing.Size(370, 44);
            this.TbUsername.TabIndex = 104;
            this.TbUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 108;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 110;
            this.label1.Text = "Domain - App";
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.topPanel;
            this.bunifuDragControl2.Vertical = true;
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.label4);
            this.topPanel.Controls.Add(this.btnFormClose);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(499, 63);
            this.topPanel.TabIndex = 111;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Millionaire DEMO", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(119, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Save a new password";
            // 
            // btnFormClose
            // 
            this.btnFormClose.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(30)))), ((int)(((byte)(24)))));
            this.btnFormClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(30)))), ((int)(((byte)(24)))));
            this.btnFormClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFormClose.BorderRadius = 0;
            this.btnFormClose.ButtonText = "  X";
            this.btnFormClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFormClose.DisabledColor = System.Drawing.Color.Gray;
            this.btnFormClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFormClose.Iconcolor = System.Drawing.Color.Transparent;
            this.btnFormClose.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnFormClose.Iconimage")));
            this.btnFormClose.Iconimage_right = null;
            this.btnFormClose.Iconimage_right_Selected = null;
            this.btnFormClose.Iconimage_Selected = null;
            this.btnFormClose.IconMarginLeft = 0;
            this.btnFormClose.IconMarginRight = 0;
            this.btnFormClose.IconRightVisible = true;
            this.btnFormClose.IconRightZoom = 0D;
            this.btnFormClose.IconVisible = false;
            this.btnFormClose.IconZoom = 90D;
            this.btnFormClose.IsTab = false;
            this.btnFormClose.Location = new System.Drawing.Point(449, 0);
            this.btnFormClose.Name = "btnFormClose";
            this.btnFormClose.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(30)))), ((int)(((byte)(24)))));
            this.btnFormClose.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btnFormClose.OnHoverTextColor = System.Drawing.Color.White;
            this.btnFormClose.selected = false;
            this.btnFormClose.Size = new System.Drawing.Size(50, 63);
            this.btnFormClose.TabIndex = 6;
            this.btnFormClose.Text = "  X";
            this.btnFormClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFormClose.Textcolor = System.Drawing.Color.White;
            this.btnFormClose.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormClose.Click += new System.EventHandler(this.btnFormClose_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // TbDomain
            // 
            this.TbDomain.BorderColorFocused = System.Drawing.Color.Blue;
            this.TbDomain.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TbDomain.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.TbDomain.BorderThickness = 3;
            this.TbDomain.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbDomain.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TbDomain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TbDomain.isPassword = false;
            this.TbDomain.Location = new System.Drawing.Point(11, 100);
            this.TbDomain.Margin = new System.Windows.Forms.Padding(4);
            this.TbDomain.Name = "TbDomain";
            this.TbDomain.Size = new System.Drawing.Size(370, 44);
            this.TbDomain.TabIndex = 103;
            this.TbDomain.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this;
            // 
            // AddPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(499, 436);
            this.Controls.Add(this.LblShowPassword);
            this.Controls.Add(this.btnSavePassword);
            this.Controls.Add(this.BtnGeneratePassword);
            this.Controls.Add(this.CbShowPassword);
            this.Controls.Add(this.TbPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.TbDomain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddPassword";
            this.Text = "AddPassword";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label LblShowPassword;
        private Bunifu.Framework.UI.BunifuFlatButton btnSavePassword;
        private Bunifu.Framework.UI.BunifuFlatButton BtnGeneratePassword;
        private Bunifu.Framework.UI.BunifuCheckbox CbShowPassword;
        private Bunifu.Framework.UI.BunifuMetroTextbox TbPassword;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMetroTextbox TbUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuFlatButton btnFormClose;
        private Bunifu.Framework.UI.BunifuMetroTextbox TbDomain;
        private Bunifu.Framework.UI.BunifuFormFadeTransition bunifuFormFadeTransition1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
    }
}