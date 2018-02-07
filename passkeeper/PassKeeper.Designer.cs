namespace passkeeper
{
    partial class PassKeeper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PassKeeper));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSaveGenLength = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnSaveDataPath = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnSavePasswordLogin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnSaveUsernameLogin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tbPathChange = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tbPasswordChange = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tbUsernameChange = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NudPasswordLength = new System.Windows.Forms.NumericUpDown();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.CbSearchUsername = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.CbSearchAll = new Bunifu.Framework.UI.BunifuCheckbox();
            this.CbSearchDomain = new Bunifu.Framework.UI.BunifuCheckbox();
            this.CbSearchPassword = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator4 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.sliderCounter = new Bunifu.Framework.UI.BunifuGauge();
            this.TbSearch = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.TbGeneratedPassword = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnGeneratePassword = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnSearch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAddPassword = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lvPasswords = new System.Windows.Forms.ListView();
            this.CMSListView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CMSCopyPW = new System.Windows.Forms.ToolStripMenuItem();
            this.CMSDelEntry = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.BtnLogin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPasswordLogin = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tbUsernameLogin = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.BtnPassKeeperSettingsTab = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnPasswordTab = new Bunifu.Framework.UI.BunifuFlatButton();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.BtnLogOutTab = new Bunifu.Framework.UI.BunifuFlatButton();
            this.topPanel = new System.Windows.Forms.Panel();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnFormMinimize = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnFormClose = new Bunifu.Framework.UI.BunifuFlatButton();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudPasswordLength)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.CMSListView.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.sidePanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.BtnSaveGenLength);
            this.tabPage2.Controls.Add(this.BtnSaveDataPath);
            this.tabPage2.Controls.Add(this.BtnSavePasswordLogin);
            this.tabPage2.Controls.Add(this.BtnSaveUsernameLogin);
            this.tabPage2.Controls.Add(this.tbPathChange);
            this.tabPage2.Controls.Add(this.tbPasswordChange);
            this.tabPage2.Controls.Add(this.tbUsernameChange);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.NudPasswordLength);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(848, 519);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(534, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(107, 28);
            this.panel1.TabIndex = 5;
            // 
            // BtnSaveGenLength
            // 
            this.BtnSaveGenLength.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnSaveGenLength.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnSaveGenLength.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSaveGenLength.BorderRadius = 0;
            this.BtnSaveGenLength.ButtonText = "Save length";
            this.BtnSaveGenLength.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSaveGenLength.DisabledColor = System.Drawing.Color.Gray;
            this.BtnSaveGenLength.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnSaveGenLength.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnSaveGenLength.Iconimage")));
            this.BtnSaveGenLength.Iconimage_right = null;
            this.BtnSaveGenLength.Iconimage_right_Selected = null;
            this.BtnSaveGenLength.Iconimage_Selected = null;
            this.BtnSaveGenLength.IconMarginLeft = 0;
            this.BtnSaveGenLength.IconMarginRight = 0;
            this.BtnSaveGenLength.IconRightVisible = false;
            this.BtnSaveGenLength.IconRightZoom = 0D;
            this.BtnSaveGenLength.IconVisible = false;
            this.BtnSaveGenLength.IconZoom = 90D;
            this.BtnSaveGenLength.IsTab = false;
            this.BtnSaveGenLength.Location = new System.Drawing.Point(235, 81);
            this.BtnSaveGenLength.Name = "BtnSaveGenLength";
            this.BtnSaveGenLength.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnSaveGenLength.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BtnSaveGenLength.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnSaveGenLength.selected = false;
            this.BtnSaveGenLength.Size = new System.Drawing.Size(212, 20);
            this.BtnSaveGenLength.TabIndex = 4;
            this.BtnSaveGenLength.Text = "Save length";
            this.BtnSaveGenLength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnSaveGenLength.Textcolor = System.Drawing.Color.White;
            this.BtnSaveGenLength.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveGenLength.Click += new System.EventHandler(this.BtnSaveGenLength_Click);
            // 
            // BtnSaveDataPath
            // 
            this.BtnSaveDataPath.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnSaveDataPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnSaveDataPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSaveDataPath.BorderRadius = 0;
            this.BtnSaveDataPath.ButtonText = "Choose new data path";
            this.BtnSaveDataPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSaveDataPath.DisabledColor = System.Drawing.Color.Gray;
            this.BtnSaveDataPath.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnSaveDataPath.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnSaveDataPath.Iconimage")));
            this.BtnSaveDataPath.Iconimage_right = null;
            this.BtnSaveDataPath.Iconimage_right_Selected = null;
            this.BtnSaveDataPath.Iconimage_Selected = null;
            this.BtnSaveDataPath.IconMarginLeft = 0;
            this.BtnSaveDataPath.IconMarginRight = 0;
            this.BtnSaveDataPath.IconRightVisible = false;
            this.BtnSaveDataPath.IconRightZoom = 0D;
            this.BtnSaveDataPath.IconVisible = false;
            this.BtnSaveDataPath.IconZoom = 90D;
            this.BtnSaveDataPath.IsTab = false;
            this.BtnSaveDataPath.Location = new System.Drawing.Point(24, 397);
            this.BtnSaveDataPath.Name = "BtnSaveDataPath";
            this.BtnSaveDataPath.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnSaveDataPath.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BtnSaveDataPath.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnSaveDataPath.selected = false;
            this.BtnSaveDataPath.Size = new System.Drawing.Size(606, 44);
            this.BtnSaveDataPath.TabIndex = 4;
            this.BtnSaveDataPath.Text = "Choose new data path";
            this.BtnSaveDataPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnSaveDataPath.Textcolor = System.Drawing.Color.White;
            this.BtnSaveDataPath.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveDataPath.Click += new System.EventHandler(this.BtnSaveDataPath_Click);
            // 
            // BtnSavePasswordLogin
            // 
            this.BtnSavePasswordLogin.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnSavePasswordLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnSavePasswordLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSavePasswordLogin.BorderRadius = 0;
            this.BtnSavePasswordLogin.ButtonText = "Save password";
            this.BtnSavePasswordLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSavePasswordLogin.DisabledColor = System.Drawing.Color.Gray;
            this.BtnSavePasswordLogin.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnSavePasswordLogin.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnSavePasswordLogin.Iconimage")));
            this.BtnSavePasswordLogin.Iconimage_right = null;
            this.BtnSavePasswordLogin.Iconimage_right_Selected = null;
            this.BtnSavePasswordLogin.Iconimage_Selected = null;
            this.BtnSavePasswordLogin.IconMarginLeft = 0;
            this.BtnSavePasswordLogin.IconMarginRight = 0;
            this.BtnSavePasswordLogin.IconRightVisible = false;
            this.BtnSavePasswordLogin.IconRightZoom = 0D;
            this.BtnSavePasswordLogin.IconVisible = false;
            this.BtnSavePasswordLogin.IconZoom = 90D;
            this.BtnSavePasswordLogin.IsTab = false;
            this.BtnSavePasswordLogin.Location = new System.Drawing.Point(418, 282);
            this.BtnSavePasswordLogin.Name = "BtnSavePasswordLogin";
            this.BtnSavePasswordLogin.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnSavePasswordLogin.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BtnSavePasswordLogin.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnSavePasswordLogin.selected = false;
            this.BtnSavePasswordLogin.Size = new System.Drawing.Size(212, 44);
            this.BtnSavePasswordLogin.TabIndex = 4;
            this.BtnSavePasswordLogin.Text = "Save password";
            this.BtnSavePasswordLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnSavePasswordLogin.Textcolor = System.Drawing.Color.White;
            this.BtnSavePasswordLogin.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSavePasswordLogin.Click += new System.EventHandler(this.BtnSavePasswordLogin_Click);
            // 
            // BtnSaveUsernameLogin
            // 
            this.BtnSaveUsernameLogin.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnSaveUsernameLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnSaveUsernameLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSaveUsernameLogin.BorderRadius = 0;
            this.BtnSaveUsernameLogin.ButtonText = "Save username";
            this.BtnSaveUsernameLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSaveUsernameLogin.DisabledColor = System.Drawing.Color.Gray;
            this.BtnSaveUsernameLogin.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnSaveUsernameLogin.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnSaveUsernameLogin.Iconimage")));
            this.BtnSaveUsernameLogin.Iconimage_right = null;
            this.BtnSaveUsernameLogin.Iconimage_right_Selected = null;
            this.BtnSaveUsernameLogin.Iconimage_Selected = null;
            this.BtnSaveUsernameLogin.IconMarginLeft = 0;
            this.BtnSaveUsernameLogin.IconMarginRight = 0;
            this.BtnSaveUsernameLogin.IconRightVisible = false;
            this.BtnSaveUsernameLogin.IconRightZoom = 0D;
            this.BtnSaveUsernameLogin.IconVisible = false;
            this.BtnSaveUsernameLogin.IconZoom = 90D;
            this.BtnSaveUsernameLogin.IsTab = false;
            this.BtnSaveUsernameLogin.Location = new System.Drawing.Point(418, 176);
            this.BtnSaveUsernameLogin.Name = "BtnSaveUsernameLogin";
            this.BtnSaveUsernameLogin.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnSaveUsernameLogin.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BtnSaveUsernameLogin.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnSaveUsernameLogin.selected = false;
            this.BtnSaveUsernameLogin.Size = new System.Drawing.Size(212, 44);
            this.BtnSaveUsernameLogin.TabIndex = 4;
            this.BtnSaveUsernameLogin.Text = "Save username";
            this.BtnSaveUsernameLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnSaveUsernameLogin.Textcolor = System.Drawing.Color.White;
            this.BtnSaveUsernameLogin.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveUsernameLogin.Click += new System.EventHandler(this.BtnSaveUsernameLogin_Click);
            // 
            // tbPathChange
            // 
            this.tbPathChange.BorderColorFocused = System.Drawing.Color.Blue;
            this.tbPathChange.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbPathChange.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tbPathChange.BorderThickness = 3;
            this.tbPathChange.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPathChange.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbPathChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbPathChange.isPassword = false;
            this.tbPathChange.Location = new System.Drawing.Point(24, 448);
            this.tbPathChange.Margin = new System.Windows.Forms.Padding(4);
            this.tbPathChange.Name = "tbPathChange";
            this.tbPathChange.Size = new System.Drawing.Size(606, 31);
            this.tbPathChange.TabIndex = 3;
            this.tbPathChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbPasswordChange
            // 
            this.tbPasswordChange.BorderColorFocused = System.Drawing.Color.Blue;
            this.tbPasswordChange.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbPasswordChange.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tbPasswordChange.BorderThickness = 3;
            this.tbPasswordChange.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPasswordChange.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbPasswordChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbPasswordChange.isPassword = false;
            this.tbPasswordChange.Location = new System.Drawing.Point(24, 282);
            this.tbPasswordChange.Margin = new System.Windows.Forms.Padding(4);
            this.tbPasswordChange.Name = "tbPasswordChange";
            this.tbPasswordChange.Size = new System.Drawing.Size(370, 44);
            this.tbPasswordChange.TabIndex = 3;
            this.tbPasswordChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbUsernameChange
            // 
            this.tbUsernameChange.BorderColorFocused = System.Drawing.Color.Blue;
            this.tbUsernameChange.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbUsernameChange.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tbUsernameChange.BorderThickness = 3;
            this.tbUsernameChange.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUsernameChange.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbUsernameChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbUsernameChange.isPassword = false;
            this.tbUsernameChange.Location = new System.Drawing.Point(24, 176);
            this.tbUsernameChange.Margin = new System.Windows.Forms.Padding(4);
            this.tbUsernameChange.Name = "tbUsernameChange";
            this.tbUsernameChange.Size = new System.Drawing.Size(369, 44);
            this.tbUsernameChange.TabIndex = 2;
            this.tbUsernameChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Quantify", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "New Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Quantify", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "Data File Path";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Quantify", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "New Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Quantify", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Generated Password Length";
            // 
            // NudPasswordLength
            // 
            this.NudPasswordLength.Location = new System.Drawing.Point(24, 81);
            this.NudPasswordLength.Name = "NudPasswordLength";
            this.NudPasswordLength.Size = new System.Drawing.Size(195, 20);
            this.NudPasswordLength.TabIndex = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Username";
            this.columnHeader2.Width = 169;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Domain";
            this.columnHeader1.Width = 180;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Password";
            this.columnHeader3.Width = 269;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(61, 287);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(113, 13);
            this.bunifuCustomLabel1.TabIndex = 16;
            this.bunifuCustomLabel1.Text = "Search on all collumns";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(61, 345);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(95, 13);
            this.bunifuCustomLabel3.TabIndex = 16;
            this.bunifuCustomLabel3.Text = "Search on Domain";
            // 
            // CbSearchUsername
            // 
            this.CbSearchUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.CbSearchUsername.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.CbSearchUsername.Checked = true;
            this.CbSearchUsername.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.CbSearchUsername.ForeColor = System.Drawing.Color.White;
            this.CbSearchUsername.Location = new System.Drawing.Point(35, 374);
            this.CbSearchUsername.Name = "CbSearchUsername";
            this.CbSearchUsername.Size = new System.Drawing.Size(20, 20);
            this.CbSearchUsername.TabIndex = 22;
            this.CbSearchUsername.OnChange += new System.EventHandler(this.CbSearchUsername_OnChange);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(61, 406);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(105, 13);
            this.bunifuCustomLabel5.TabIndex = 17;
            this.bunifuCustomLabel5.Text = "Search on Password";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.bunifuCustomLabel6);
            this.tabPage1.Controls.Add(this.bunifuCustomLabel1);
            this.tabPage1.Controls.Add(this.bunifuCustomLabel3);
            this.tabPage1.Controls.Add(this.CbSearchUsername);
            this.tabPage1.Controls.Add(this.bunifuCustomLabel5);
            this.tabPage1.Controls.Add(this.bunifuCustomLabel4);
            this.tabPage1.Controls.Add(this.CbSearchAll);
            this.tabPage1.Controls.Add(this.CbSearchDomain);
            this.tabPage1.Controls.Add(this.CbSearchPassword);
            this.tabPage1.Controls.Add(this.bunifuSeparator2);
            this.tabPage1.Controls.Add(this.bunifuSeparator4);
            this.tabPage1.Controls.Add(this.bunifuSeparator1);
            this.tabPage1.Controls.Add(this.bunifuCustomLabel8);
            this.tabPage1.Controls.Add(this.sliderCounter);
            this.tabPage1.Controls.Add(this.TbSearch);
            this.tabPage1.Controls.Add(this.TbGeneratedPassword);
            this.tabPage1.Controls.Add(this.btnGeneratePassword);
            this.tabPage1.Controls.Add(this.BtnSearch);
            this.tabPage1.Controls.Add(this.btnAddPassword);
            this.tabPage1.Controls.Add(this.lvPasswords);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(848, 519);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("NEOTERIC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(6, 222);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(200, 26);
            this.bunifuCustomLabel6.TabIndex = 26;
            this.bunifuCustomLabel6.Text = "Filters on searching";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(61, 374);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(107, 13);
            this.bunifuCustomLabel4.TabIndex = 18;
            this.bunifuCustomLabel4.Text = "Search on Username";
            // 
            // CbSearchAll
            // 
            this.CbSearchAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.CbSearchAll.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.CbSearchAll.Checked = true;
            this.CbSearchAll.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.CbSearchAll.ForeColor = System.Drawing.Color.White;
            this.CbSearchAll.Location = new System.Drawing.Point(35, 282);
            this.CbSearchAll.Name = "CbSearchAll";
            this.CbSearchAll.Size = new System.Drawing.Size(20, 20);
            this.CbSearchAll.TabIndex = 24;
            this.CbSearchAll.Tag = "cbAll";
            this.CbSearchAll.OnChange += new System.EventHandler(this.CbSearchAll_OnChange);
            // 
            // CbSearchDomain
            // 
            this.CbSearchDomain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.CbSearchDomain.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.CbSearchDomain.Checked = true;
            this.CbSearchDomain.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.CbSearchDomain.ForeColor = System.Drawing.Color.White;
            this.CbSearchDomain.Location = new System.Drawing.Point(35, 345);
            this.CbSearchDomain.Name = "CbSearchDomain";
            this.CbSearchDomain.Size = new System.Drawing.Size(20, 20);
            this.CbSearchDomain.TabIndex = 24;
            this.CbSearchDomain.OnChange += new System.EventHandler(this.CbSearchDomain_OnChange);
            // 
            // CbSearchPassword
            // 
            this.CbSearchPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.CbSearchPassword.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.CbSearchPassword.Checked = true;
            this.CbSearchPassword.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.CbSearchPassword.ForeColor = System.Drawing.Color.White;
            this.CbSearchPassword.Location = new System.Drawing.Point(35, 406);
            this.CbSearchPassword.Name = "CbSearchPassword";
            this.CbSearchPassword.Size = new System.Drawing.Size(20, 20);
            this.CbSearchPassword.TabIndex = 25;
            this.CbSearchPassword.OnChange += new System.EventHandler(this.CbSearchPassword_OnChange);
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(6, 308);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(198, 35);
            this.bunifuSeparator2.TabIndex = 11;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // bunifuSeparator4
            // 
            this.bunifuSeparator4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator4.LineThickness = 1;
            this.bunifuSeparator4.Location = new System.Drawing.Point(6, 184);
            this.bunifuSeparator4.Name = "bunifuSeparator4";
            this.bunifuSeparator4.Size = new System.Drawing.Size(198, 35);
            this.bunifuSeparator4.TabIndex = 11;
            this.bunifuSeparator4.Transparency = 255;
            this.bunifuSeparator4.Vertical = false;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(6, 251);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(198, 35);
            this.bunifuSeparator1.TabIndex = 11;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(53, 156);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(91, 13);
            this.bunifuCustomLabel8.TabIndex = 10;
            this.bunifuCustomLabel8.Text = "Saved passwords";
            // 
            // sliderCounter
            // 
            this.sliderCounter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sliderCounter.BackgroundImage")));
            this.sliderCounter.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.sliderCounter.Location = new System.Drawing.Point(6, 6);
            this.sliderCounter.Margin = new System.Windows.Forms.Padding(6);
            this.sliderCounter.Name = "sliderCounter";
            this.sliderCounter.ProgressBgColor = System.Drawing.Color.Gray;
            this.sliderCounter.ProgressColor1 = System.Drawing.Color.RoyalBlue;
            this.sliderCounter.ProgressColor2 = System.Drawing.Color.IndianRed;
            this.sliderCounter.Size = new System.Drawing.Size(200, 144);
            this.sliderCounter.Suffix = "";
            this.sliderCounter.TabIndex = 9;
            this.sliderCounter.Thickness = 30;
            this.sliderCounter.Value = 50;
            // 
            // TbSearch
            // 
            this.TbSearch.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(43)))), ((int)(((byte)(110)))));
            this.TbSearch.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TbSearch.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.TbSearch.BorderThickness = 3;
            this.TbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TbSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TbSearch.isPassword = false;
            this.TbSearch.Location = new System.Drawing.Point(210, 7);
            this.TbSearch.Margin = new System.Windows.Forms.Padding(4);
            this.TbSearch.Name = "TbSearch";
            this.TbSearch.Size = new System.Drawing.Size(391, 54);
            this.TbSearch.TabIndex = 8;
            this.TbSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TbSearch.OnValueChanged += new System.EventHandler(this.TbSearch_OnValueChanged);
            // 
            // TbGeneratedPassword
            // 
            this.TbGeneratedPassword.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(43)))), ((int)(((byte)(110)))));
            this.TbGeneratedPassword.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TbGeneratedPassword.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.TbGeneratedPassword.BorderThickness = 3;
            this.TbGeneratedPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbGeneratedPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TbGeneratedPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TbGeneratedPassword.isPassword = false;
            this.TbGeneratedPassword.Location = new System.Drawing.Point(278, 475);
            this.TbGeneratedPassword.Margin = new System.Windows.Forms.Padding(4);
            this.TbGeneratedPassword.Name = "TbGeneratedPassword";
            this.TbGeneratedPassword.Size = new System.Drawing.Size(561, 44);
            this.TbGeneratedPassword.TabIndex = 7;
            this.TbGeneratedPassword.Text = "********";
            this.TbGeneratedPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGeneratePassword
            // 
            this.btnGeneratePassword.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGeneratePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.btnGeneratePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGeneratePassword.BorderRadius = 0;
            this.btnGeneratePassword.ButtonText = "Generate Password";
            this.btnGeneratePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGeneratePassword.DisabledColor = System.Drawing.Color.Gray;
            this.btnGeneratePassword.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGeneratePassword.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnGeneratePassword.Iconimage")));
            this.btnGeneratePassword.Iconimage_right = null;
            this.btnGeneratePassword.Iconimage_right_Selected = null;
            this.btnGeneratePassword.Iconimage_Selected = null;
            this.btnGeneratePassword.IconMarginLeft = 0;
            this.btnGeneratePassword.IconMarginRight = 0;
            this.btnGeneratePassword.IconRightVisible = false;
            this.btnGeneratePassword.IconRightZoom = 0D;
            this.btnGeneratePassword.IconVisible = false;
            this.btnGeneratePassword.IconZoom = 90D;
            this.btnGeneratePassword.IsTab = false;
            this.btnGeneratePassword.Location = new System.Drawing.Point(3, 475);
            this.btnGeneratePassword.Name = "btnGeneratePassword";
            this.btnGeneratePassword.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.btnGeneratePassword.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(43)))), ((int)(((byte)(110)))));
            this.btnGeneratePassword.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGeneratePassword.selected = false;
            this.btnGeneratePassword.Size = new System.Drawing.Size(265, 44);
            this.btnGeneratePassword.TabIndex = 4;
            this.btnGeneratePassword.Text = "Generate Password";
            this.btnGeneratePassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGeneratePassword.Textcolor = System.Drawing.Color.White;
            this.btnGeneratePassword.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneratePassword.Click += new System.EventHandler(this.btnGeneratePassword_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSearch.BorderRadius = 0;
            this.BtnSearch.ButtonText = "Search";
            this.BtnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSearch.DisabledColor = System.Drawing.Color.Gray;
            this.BtnSearch.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnSearch.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnSearch.Iconimage")));
            this.BtnSearch.Iconimage_right = null;
            this.BtnSearch.Iconimage_right_Selected = null;
            this.BtnSearch.Iconimage_Selected = null;
            this.BtnSearch.IconMarginLeft = 0;
            this.BtnSearch.IconMarginRight = 0;
            this.BtnSearch.IconRightVisible = false;
            this.BtnSearch.IconRightZoom = 0D;
            this.BtnSearch.IconVisible = false;
            this.BtnSearch.IconZoom = 90D;
            this.BtnSearch.IsTab = false;
            this.BtnSearch.Location = new System.Drawing.Point(608, 6);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.BtnSearch.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(43)))), ((int)(((byte)(110)))));
            this.BtnSearch.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnSearch.selected = false;
            this.BtnSearch.Size = new System.Drawing.Size(231, 56);
            this.BtnSearch.TabIndex = 3;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnSearch.Textcolor = System.Drawing.Color.White;
            this.BtnSearch.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // btnAddPassword
            // 
            this.btnAddPassword.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.btnAddPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.btnAddPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddPassword.BorderRadius = 0;
            this.btnAddPassword.ButtonText = "Add password";
            this.btnAddPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPassword.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddPassword.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddPassword.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAddPassword.Iconimage")));
            this.btnAddPassword.Iconimage_right = null;
            this.btnAddPassword.Iconimage_right_Selected = null;
            this.btnAddPassword.Iconimage_Selected = null;
            this.btnAddPassword.IconMarginLeft = 0;
            this.btnAddPassword.IconMarginRight = 0;
            this.btnAddPassword.IconRightVisible = false;
            this.btnAddPassword.IconRightZoom = 0D;
            this.btnAddPassword.IconVisible = false;
            this.btnAddPassword.IconZoom = 90D;
            this.btnAddPassword.IsTab = false;
            this.btnAddPassword.Location = new System.Drawing.Point(210, 394);
            this.btnAddPassword.Name = "btnAddPassword";
            this.btnAddPassword.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.btnAddPassword.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnAddPassword.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddPassword.selected = false;
            this.btnAddPassword.Size = new System.Drawing.Size(632, 60);
            this.btnAddPassword.TabIndex = 1;
            this.btnAddPassword.Text = "Add password";
            this.btnAddPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddPassword.Textcolor = System.Drawing.Color.White;
            this.btnAddPassword.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPassword.Click += new System.EventHandler(this.btnAddPassword_Click);
            // 
            // lvPasswords
            // 
            this.lvPasswords.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvPasswords.ContextMenuStrip = this.CMSListView;
            this.lvPasswords.FullRowSelect = true;
            this.lvPasswords.Location = new System.Drawing.Point(210, 68);
            this.lvPasswords.MultiSelect = false;
            this.lvPasswords.Name = "lvPasswords";
            this.lvPasswords.Size = new System.Drawing.Size(629, 321);
            this.lvPasswords.TabIndex = 2;
            this.lvPasswords.UseCompatibleStateImageBehavior = false;
            this.lvPasswords.View = System.Windows.Forms.View.Details;
            // 
            // CMSListView
            // 
            this.CMSListView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CMSCopyPW,
            this.CMSDelEntry});
            this.CMSListView.Name = "CMSListView";
            this.CMSListView.Size = new System.Drawing.Size(156, 48);
            // 
            // CMSCopyPW
            // 
            this.CMSCopyPW.Name = "CMSCopyPW";
            this.CMSCopyPW.Size = new System.Drawing.Size(155, 22);
            this.CMSCopyPW.Text = "Copy password";
            this.CMSCopyPW.Click += new System.EventHandler(this.CMSCopyPW_Click);
            // 
            // CMSDelEntry
            // 
            this.CMSDelEntry.Name = "CMSDelEntry";
            this.CMSDelEntry.Size = new System.Drawing.Size(155, 22);
            this.CMSDelEntry.Text = "Delete entry";
            this.CMSDelEntry.Click += new System.EventHandler(this.CMSDelEntry_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(207, 64);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(856, 545);
            this.tabControl1.TabIndex = 24;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.BtnLogin);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.lblError);
            this.tabPage3.Controls.Add(this.lblLogin);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.tbPasswordLogin);
            this.tabPage3.Controls.Add(this.tbUsernameLogin);
            this.tabPage3.Font = new System.Drawing.Font("NEOTERIC", 8.25F);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(848, 519);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            // 
            // BtnLogin
            // 
            this.BtnLogin.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.BtnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.BtnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnLogin.BorderRadius = 0;
            this.BtnLogin.ButtonText = "Login";
            this.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogin.DisabledColor = System.Drawing.Color.Gray;
            this.BtnLogin.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnLogin.Iconimage = null;
            this.BtnLogin.Iconimage_right = null;
            this.BtnLogin.Iconimage_right_Selected = null;
            this.BtnLogin.Iconimage_Selected = null;
            this.BtnLogin.IconMarginLeft = 0;
            this.BtnLogin.IconMarginRight = 0;
            this.BtnLogin.IconRightVisible = false;
            this.BtnLogin.IconRightZoom = 0D;
            this.BtnLogin.IconVisible = false;
            this.BtnLogin.IconZoom = 90D;
            this.BtnLogin.IsTab = false;
            this.BtnLogin.Location = new System.Drawing.Point(196, 342);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.BtnLogin.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(43)))), ((int)(((byte)(110)))));
            this.BtnLogin.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnLogin.selected = false;
            this.BtnLogin.Size = new System.Drawing.Size(241, 52);
            this.BtnLogin.TabIndex = 3;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnLogin.Textcolor = System.Drawing.Color.White;
            this.BtnLogin.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("NEOTERIC", 14F);
            this.label2.Location = new System.Drawing.Point(158, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("NEOTERIC", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.Location = new System.Drawing.Point(57, 415);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 46);
            this.lblError.TabIndex = 1;
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("NEOTERIC", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(206, 51);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(222, 46);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Login please";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("NEOTERIC", 14F);
            this.label1.Location = new System.Drawing.Point(158, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // tbPasswordLogin
            // 
            this.tbPasswordLogin.BorderColorFocused = System.Drawing.Color.LightSteelBlue;
            this.tbPasswordLogin.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbPasswordLogin.BorderColorMouseHover = System.Drawing.Color.CornflowerBlue;
            this.tbPasswordLogin.BorderThickness = 3;
            this.tbPasswordLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPasswordLogin.Font = new System.Drawing.Font("Nexa Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPasswordLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbPasswordLogin.isPassword = true;
            this.tbPasswordLogin.Location = new System.Drawing.Point(152, 260);
            this.tbPasswordLogin.Margin = new System.Windows.Forms.Padding(4);
            this.tbPasswordLogin.Name = "tbPasswordLogin";
            this.tbPasswordLogin.Size = new System.Drawing.Size(324, 44);
            this.tbPasswordLogin.TabIndex = 2;
            this.tbPasswordLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbUsernameLogin
            // 
            this.tbUsernameLogin.BorderColorFocused = System.Drawing.Color.LightSteelBlue;
            this.tbUsernameLogin.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbUsernameLogin.BorderColorMouseHover = System.Drawing.Color.CornflowerBlue;
            this.tbUsernameLogin.BorderThickness = 3;
            this.tbUsernameLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUsernameLogin.Font = new System.Drawing.Font("Nexa Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsernameLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbUsernameLogin.isPassword = false;
            this.tbUsernameLogin.Location = new System.Drawing.Point(152, 160);
            this.tbUsernameLogin.Margin = new System.Windows.Forms.Padding(4);
            this.tbUsernameLogin.Name = "tbUsernameLogin";
            this.tbUsernameLogin.Size = new System.Drawing.Size(324, 44);
            this.tbUsernameLogin.TabIndex = 1;
            this.tbUsernameLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // BtnPassKeeperSettingsTab
            // 
            this.BtnPassKeeperSettingsTab.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.BtnPassKeeperSettingsTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.BtnPassKeeperSettingsTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPassKeeperSettingsTab.BorderRadius = 0;
            this.BtnPassKeeperSettingsTab.ButtonText = "Passkeeper settings";
            this.BtnPassKeeperSettingsTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPassKeeperSettingsTab.DisabledColor = System.Drawing.Color.Gray;
            this.BtnPassKeeperSettingsTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPassKeeperSettingsTab.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnPassKeeperSettingsTab.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnPassKeeperSettingsTab.Iconimage")));
            this.BtnPassKeeperSettingsTab.Iconimage_right = null;
            this.BtnPassKeeperSettingsTab.Iconimage_right_Selected = null;
            this.BtnPassKeeperSettingsTab.Iconimage_Selected = null;
            this.BtnPassKeeperSettingsTab.IconMarginLeft = 0;
            this.BtnPassKeeperSettingsTab.IconMarginRight = 0;
            this.BtnPassKeeperSettingsTab.IconRightVisible = true;
            this.BtnPassKeeperSettingsTab.IconRightZoom = 0D;
            this.BtnPassKeeperSettingsTab.IconVisible = true;
            this.BtnPassKeeperSettingsTab.IconZoom = 90D;
            this.BtnPassKeeperSettingsTab.IsTab = false;
            this.BtnPassKeeperSettingsTab.Location = new System.Drawing.Point(0, 48);
            this.BtnPassKeeperSettingsTab.Name = "BtnPassKeeperSettingsTab";
            this.BtnPassKeeperSettingsTab.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.BtnPassKeeperSettingsTab.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.BtnPassKeeperSettingsTab.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnPassKeeperSettingsTab.selected = false;
            this.BtnPassKeeperSettingsTab.Size = new System.Drawing.Size(200, 48);
            this.BtnPassKeeperSettingsTab.TabIndex = 14;
            this.BtnPassKeeperSettingsTab.Text = "Passkeeper settings";
            this.BtnPassKeeperSettingsTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPassKeeperSettingsTab.Textcolor = System.Drawing.Color.White;
            this.BtnPassKeeperSettingsTab.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPassKeeperSettingsTab.Click += new System.EventHandler(this.BtnPassKeeperSettingsTab_Click);
            // 
            // BtnPasswordTab
            // 
            this.BtnPasswordTab.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.BtnPasswordTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.BtnPasswordTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPasswordTab.BorderRadius = 0;
            this.BtnPasswordTab.ButtonText = "Password list";
            this.BtnPasswordTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPasswordTab.DisabledColor = System.Drawing.Color.Gray;
            this.BtnPasswordTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPasswordTab.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnPasswordTab.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnPasswordTab.Iconimage")));
            this.BtnPasswordTab.Iconimage_right = null;
            this.BtnPasswordTab.Iconimage_right_Selected = null;
            this.BtnPasswordTab.Iconimage_Selected = null;
            this.BtnPasswordTab.IconMarginLeft = 0;
            this.BtnPasswordTab.IconMarginRight = 0;
            this.BtnPasswordTab.IconRightVisible = true;
            this.BtnPasswordTab.IconRightZoom = 0D;
            this.BtnPasswordTab.IconVisible = true;
            this.BtnPasswordTab.IconZoom = 90D;
            this.BtnPasswordTab.IsTab = false;
            this.BtnPasswordTab.Location = new System.Drawing.Point(0, 0);
            this.BtnPasswordTab.Name = "BtnPasswordTab";
            this.BtnPasswordTab.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.BtnPasswordTab.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.BtnPasswordTab.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnPasswordTab.selected = false;
            this.BtnPasswordTab.Size = new System.Drawing.Size(200, 48);
            this.BtnPasswordTab.TabIndex = 1;
            this.BtnPasswordTab.Text = "Password list";
            this.BtnPasswordTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPasswordTab.Textcolor = System.Drawing.Color.White;
            this.BtnPasswordTab.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPasswordTab.Click += new System.EventHandler(this.BtnPasswordTab_Click);
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.sidePanel.Controls.Add(this.BtnLogOutTab);
            this.sidePanel.Controls.Add(this.BtnPassKeeperSettingsTab);
            this.sidePanel.Controls.Add(this.BtnPasswordTab);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 57);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(200, 552);
            this.sidePanel.TabIndex = 22;
            this.sidePanel.Visible = false;
            // 
            // BtnLogOutTab
            // 
            this.BtnLogOutTab.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.BtnLogOutTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.BtnLogOutTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnLogOutTab.BorderRadius = 0;
            this.BtnLogOutTab.ButtonText = "Log out";
            this.BtnLogOutTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogOutTab.DisabledColor = System.Drawing.Color.Gray;
            this.BtnLogOutTab.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnLogOutTab.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnLogOutTab.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnLogOutTab.Iconimage")));
            this.BtnLogOutTab.Iconimage_right = null;
            this.BtnLogOutTab.Iconimage_right_Selected = null;
            this.BtnLogOutTab.Iconimage_Selected = null;
            this.BtnLogOutTab.IconMarginLeft = 0;
            this.BtnLogOutTab.IconMarginRight = 0;
            this.BtnLogOutTab.IconRightVisible = true;
            this.BtnLogOutTab.IconRightZoom = 0D;
            this.BtnLogOutTab.IconVisible = true;
            this.BtnLogOutTab.IconZoom = 90D;
            this.BtnLogOutTab.IsTab = false;
            this.BtnLogOutTab.Location = new System.Drawing.Point(0, 504);
            this.BtnLogOutTab.Name = "BtnLogOutTab";
            this.BtnLogOutTab.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.BtnLogOutTab.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.BtnLogOutTab.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnLogOutTab.selected = false;
            this.BtnLogOutTab.Size = new System.Drawing.Size(200, 48);
            this.BtnLogOutTab.TabIndex = 15;
            this.BtnLogOutTab.Text = "Log out";
            this.BtnLogOutTab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnLogOutTab.Textcolor = System.Drawing.Color.White;
            this.BtnLogOutTab.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogOutTab.Click += new System.EventHandler(this.BtnLogOutTab_Click);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.White;
            this.topPanel.Controls.Add(this.logoPanel);
            this.topPanel.Controls.Add(this.btnFormMinimize);
            this.topPanel.Controls.Add(this.btnFormClose);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1063, 57);
            this.topPanel.TabIndex = 23;
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.logoPanel.Controls.Add(this.bunifuCustomLabel2);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(963, 57);
            this.logoPanel.TabIndex = 1;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Millionaire DEMO", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(24, 12);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(144, 26);
            this.bunifuCustomLabel2.TabIndex = 0;
            this.bunifuCustomLabel2.Text = "PassKeeper";
            // 
            // btnFormMinimize
            // 
            this.btnFormMinimize.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.btnFormMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.btnFormMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFormMinimize.BorderRadius = 0;
            this.btnFormMinimize.ButtonText = "  _";
            this.btnFormMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFormMinimize.DisabledColor = System.Drawing.Color.Gray;
            this.btnFormMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFormMinimize.Iconcolor = System.Drawing.Color.Transparent;
            this.btnFormMinimize.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnFormMinimize.Iconimage")));
            this.btnFormMinimize.Iconimage_right = null;
            this.btnFormMinimize.Iconimage_right_Selected = null;
            this.btnFormMinimize.Iconimage_Selected = null;
            this.btnFormMinimize.IconMarginLeft = 0;
            this.btnFormMinimize.IconMarginRight = 0;
            this.btnFormMinimize.IconRightVisible = true;
            this.btnFormMinimize.IconRightZoom = 0D;
            this.btnFormMinimize.IconVisible = false;
            this.btnFormMinimize.IconZoom = 90D;
            this.btnFormMinimize.IsTab = false;
            this.btnFormMinimize.Location = new System.Drawing.Point(963, 0);
            this.btnFormMinimize.Name = "btnFormMinimize";
            this.btnFormMinimize.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.btnFormMinimize.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnFormMinimize.OnHoverTextColor = System.Drawing.Color.White;
            this.btnFormMinimize.selected = false;
            this.btnFormMinimize.Size = new System.Drawing.Size(50, 57);
            this.btnFormMinimize.TabIndex = 0;
            this.btnFormMinimize.Text = "  _";
            this.btnFormMinimize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFormMinimize.Textcolor = System.Drawing.Color.White;
            this.btnFormMinimize.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormMinimize.Click += new System.EventHandler(this.btnFormMinimize_Click);
            // 
            // btnFormClose
            // 
            this.btnFormClose.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(30)))), ((int)(((byte)(24)))));
            this.btnFormClose.BackColor = System.Drawing.Color.Firebrick;
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
            this.btnFormClose.Location = new System.Drawing.Point(1013, 0);
            this.btnFormClose.Name = "btnFormClose";
            this.btnFormClose.Normalcolor = System.Drawing.Color.Firebrick;
            this.btnFormClose.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btnFormClose.OnHoverTextColor = System.Drawing.Color.White;
            this.btnFormClose.selected = false;
            this.btnFormClose.Size = new System.Drawing.Size(50, 57);
            this.btnFormClose.TabIndex = 0;
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
            this.bunifuDragControl1.TargetControl = this.logoPanel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // PassKeeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 609);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PassKeeper";
            this.Text = "Pass Keeper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PassKeeper_FormClosing);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudPasswordLength)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.CMSListView.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.sidePanel.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            this.logoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCheckbox CbSearchUsername;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCheckbox CbSearchAll;
        private Bunifu.Framework.UI.BunifuCheckbox CbSearchDomain;
        private Bunifu.Framework.UI.BunifuCheckbox CbSearchPassword;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        public Bunifu.Framework.UI.BunifuGauge sliderCounter;
        private Bunifu.Framework.UI.BunifuMetroTextbox TbSearch;
        private Bunifu.Framework.UI.BunifuMetroTextbox TbGeneratedPassword;
        private Bunifu.Framework.UI.BunifuFlatButton btnGeneratePassword;
        private Bunifu.Framework.UI.BunifuFlatButton BtnSearch;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddPassword;
        public System.Windows.Forms.ListView lvPasswords;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel sidePanel;
        private Bunifu.Framework.UI.BunifuFlatButton BtnPassKeeperSettingsTab;
        private Bunifu.Framework.UI.BunifuFlatButton BtnPasswordTab;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel logoPanel;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuFlatButton btnFormMinimize;
        private Bunifu.Framework.UI.BunifuFlatButton btnFormClose;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ContextMenuStrip CMSListView;
        private System.Windows.Forms.ToolStripMenuItem CMSCopyPW;
        private System.Windows.Forms.ToolStripMenuItem CMSDelEntry;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private Bunifu.Framework.UI.BunifuFlatButton BtnLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbUsernameLogin;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbPasswordLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NudPasswordLength;
        private Bunifu.Framework.UI.BunifuFlatButton BtnSaveGenLength;
        private Bunifu.Framework.UI.BunifuFlatButton BtnSaveDataPath;
        private Bunifu.Framework.UI.BunifuFlatButton BtnSavePasswordLogin;
        private Bunifu.Framework.UI.BunifuFlatButton BtnSaveUsernameLogin;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbPasswordChange;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbUsernameChange;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbPathChange;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblError;
        private Bunifu.Framework.UI.BunifuFlatButton BtnLogOutTab;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator4;
        private System.Windows.Forms.Panel panel1;
    }
}

