namespace ITEC.view
{
    partial class User
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
            this.cmbx_categories = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grb_items = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lw_items = new System.Windows.Forms.ListView();
            this.itemsBtn = new System.Windows.Forms.Button();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.menLine = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.grb_settings = new System.Windows.Forms.GroupBox();
            this.regDate = new System.Windows.Forms.DateTimePicker();
            this.groupBoxMessage = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.messageTb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.typeTB = new System.Windows.Forms.TextBox();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.groupBoxPassword = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.repPassTb = new System.Windows.Forms.TextBox();
            this.newPassTb = new System.Windows.Forms.TextBox();
            this.initialTb = new System.Windows.Forms.TextBox();
            this.welcomeBtn = new System.Windows.Forms.Button();
            this.passwordBtn = new System.Windows.Forms.Button();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.pointsTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBtn = new System.Windows.Forms.Button();
            this.groupBoxGroups = new System.Windows.Forms.GroupBox();
            this.groupsFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.manPanel = new System.Windows.Forms.Panel();
            this.grb_items.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.grb_settings.SuspendLayout();
            this.groupBoxMessage.SuspendLayout();
            this.groupBoxPassword.SuspendLayout();
            this.groupBoxGroups.SuspendLayout();
            this.manPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbx_categories
            // 
            this.cmbx_categories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbx_categories.FormattingEnabled = true;
            this.cmbx_categories.Location = new System.Drawing.Point(71, 19);
            this.cmbx_categories.Name = "cmbx_categories";
            this.cmbx_categories.Size = new System.Drawing.Size(121, 21);
            this.cmbx_categories.TabIndex = 0;
            this.cmbx_categories.SelectedIndexChanged += new System.EventHandler(this.cmbx_categories_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Category";
            // 
            // grb_items
            // 
            this.grb_items.Controls.Add(this.groupBox1);
            this.grb_items.Controls.Add(this.lw_items);
            this.grb_items.Controls.Add(this.cmbx_categories);
            this.grb_items.Controls.Add(this.label1);
            this.grb_items.Location = new System.Drawing.Point(4, 54);
            this.grb_items.Name = "grb_items";
            this.grb_items.Size = new System.Drawing.Size(530, 208);
            this.grb_items.TabIndex = 2;
            this.grb_items.TabStop = false;
            this.grb_items.Text = "Items";
            this.grb_items.Enter += new System.EventHandler(this.grb_items_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Location = new System.Drawing.Point(335, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 86);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vote";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(106, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Vote";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "No. Points";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(74, 19);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(56, 20);
            this.numericUpDown1.TabIndex = 0;
            // 
            // lw_items
            // 
            this.lw_items.FullRowSelect = true;
            this.lw_items.Location = new System.Drawing.Point(6, 46);
            this.lw_items.Name = "lw_items";
            this.lw_items.Size = new System.Drawing.Size(321, 149);
            this.lw_items.TabIndex = 2;
            this.lw_items.UseCompatibleStateImageBehavior = false;
            // 
            // itemsBtn
            // 
            this.itemsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemsBtn.Location = new System.Drawing.Point(6, 4);
            this.itemsBtn.Name = "itemsBtn";
            this.itemsBtn.Size = new System.Drawing.Size(110, 23);
            this.itemsBtn.TabIndex = 3;
            this.itemsBtn.Text = "Items";
            this.itemsBtn.UseVisualStyleBackColor = true;
            this.itemsBtn.Click += new System.EventHandler(this.itemsBtn_Click);
            // 
            // settingsBtn
            // 
            this.settingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsBtn.Location = new System.Drawing.Point(122, 4);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(110, 23);
            this.settingsBtn.TabIndex = 4;
            this.settingsBtn.Text = "Settings";
            this.settingsBtn.UseVisualStyleBackColor = true;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape4,
            this.menLine});
            this.shapeContainer1.Size = new System.Drawing.Size(766, 754);
            this.shapeContainer1.TabIndex = 5;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape4
            // 
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 390;
            this.lineShape4.X2 = 390;
            this.lineShape4.Y1 = 11;
            this.lineShape4.Y2 = 35;
            this.lineShape4.Click += new System.EventHandler(this.lineShape4_Click);
            // 
            // menLine
            // 
            this.menLine.Name = "menLine";
            this.menLine.X1 = 6;
            this.menLine.X2 = 529;
            this.menLine.Y1 = 42;
            this.menLine.Y2 = 42;
            // 
            // grb_settings
            // 
            this.grb_settings.Controls.Add(this.regDate);
            this.grb_settings.Controls.Add(this.groupBoxMessage);
            this.grb_settings.Controls.Add(this.label10);
            this.grb_settings.Controls.Add(this.label9);
            this.grb_settings.Controls.Add(this.label8);
            this.grb_settings.Controls.Add(this.label7);
            this.grb_settings.Controls.Add(this.typeTB);
            this.grb_settings.Controls.Add(this.nameTb);
            this.grb_settings.Controls.Add(this.usernameTB);
            this.grb_settings.Controls.Add(this.saveBtn);
            this.grb_settings.Controls.Add(this.groupBoxPassword);
            this.grb_settings.Controls.Add(this.welcomeBtn);
            this.grb_settings.Controls.Add(this.passwordBtn);
            this.grb_settings.Controls.Add(this.shapeContainer2);
            this.grb_settings.Location = new System.Drawing.Point(97, 652);
            this.grb_settings.Name = "grb_settings";
            this.grb_settings.Size = new System.Drawing.Size(650, 225);
            this.grb_settings.TabIndex = 6;
            this.grb_settings.TabStop = false;
            this.grb_settings.Text = "W";
            // 
            // regDate
            // 
            this.regDate.Enabled = false;
            this.regDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.regDate.Location = new System.Drawing.Point(114, 83);
            this.regDate.Name = "regDate";
            this.regDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.regDate.Size = new System.Drawing.Size(166, 20);
            this.regDate.TabIndex = 19;
            // 
            // groupBoxMessage
            // 
            this.groupBoxMessage.Controls.Add(this.label6);
            this.groupBoxMessage.Controls.Add(this.messageTb);
            this.groupBoxMessage.Location = new System.Drawing.Point(24, 141);
            this.groupBoxMessage.Name = "groupBoxMessage";
            this.groupBoxMessage.Size = new System.Drawing.Size(324, 111);
            this.groupBoxMessage.TabIndex = 11;
            this.groupBoxMessage.TabStop = false;
            this.groupBoxMessage.Text = "Welcome Message";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Message";
            // 
            // messageTb
            // 
            this.messageTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.messageTb.Location = new System.Drawing.Point(70, 28);
            this.messageTb.Name = "messageTb";
            this.messageTb.Size = new System.Drawing.Size(248, 20);
            this.messageTb.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(77, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Registration date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(73, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Username";
            // 
            // typeTB
            // 
            this.typeTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.typeTB.Enabled = false;
            this.typeTB.Location = new System.Drawing.Point(114, 111);
            this.typeTB.Name = "typeTB";
            this.typeTB.Size = new System.Drawing.Size(166, 20);
            this.typeTB.TabIndex = 14;
            // 
            // nameTb
            // 
            this.nameTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTb.Enabled = false;
            this.nameTb.Location = new System.Drawing.Point(114, 57);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(166, 20);
            this.nameTb.TabIndex = 13;
            // 
            // usernameTB
            // 
            this.usernameTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameTB.Enabled = false;
            this.usernameTB.Location = new System.Drawing.Point(114, 32);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(166, 20);
            this.usernameTB.TabIndex = 12;
            // 
            // saveBtn
            // 
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Location = new System.Drawing.Point(532, 191);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(110, 23);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // groupBoxPassword
            // 
            this.groupBoxPassword.Controls.Add(this.label5);
            this.groupBoxPassword.Controls.Add(this.label4);
            this.groupBoxPassword.Controls.Add(this.label3);
            this.groupBoxPassword.Controls.Add(this.repPassTb);
            this.groupBoxPassword.Controls.Add(this.newPassTb);
            this.groupBoxPassword.Controls.Add(this.initialTb);
            this.groupBoxPassword.Location = new System.Drawing.Point(322, 67);
            this.groupBoxPassword.Name = "groupBoxPassword";
            this.groupBoxPassword.Size = new System.Drawing.Size(324, 111);
            this.groupBoxPassword.TabIndex = 11;
            this.groupBoxPassword.TabStop = false;
            this.groupBoxPassword.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Repeat password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "New password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Initial password";
            // 
            // repPassTb
            // 
            this.repPassTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.repPassTb.Location = new System.Drawing.Point(118, 74);
            this.repPassTb.Name = "repPassTb";
            this.repPassTb.Size = new System.Drawing.Size(189, 20);
            this.repPassTb.TabIndex = 6;
            // 
            // newPassTb
            // 
            this.newPassTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newPassTb.Location = new System.Drawing.Point(118, 48);
            this.newPassTb.Name = "newPassTb";
            this.newPassTb.Size = new System.Drawing.Size(189, 20);
            this.newPassTb.TabIndex = 5;
            // 
            // initialTb
            // 
            this.initialTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.initialTb.Location = new System.Drawing.Point(118, 22);
            this.initialTb.Name = "initialTb";
            this.initialTb.Size = new System.Drawing.Size(189, 20);
            this.initialTb.TabIndex = 4;
            // 
            // welcomeBtn
            // 
            this.welcomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.welcomeBtn.Location = new System.Drawing.Point(443, 24);
            this.welcomeBtn.Name = "welcomeBtn";
            this.welcomeBtn.Size = new System.Drawing.Size(110, 23);
            this.welcomeBtn.TabIndex = 1;
            this.welcomeBtn.Text = "Welcome Message";
            this.welcomeBtn.UseVisualStyleBackColor = true;
            this.welcomeBtn.Click += new System.EventHandler(this.welcomeBtn_Click);
            // 
            // passwordBtn
            // 
            this.passwordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.passwordBtn.Location = new System.Drawing.Point(327, 24);
            this.passwordBtn.Name = "passwordBtn";
            this.passwordBtn.Size = new System.Drawing.Size(110, 23);
            this.passwordBtn.TabIndex = 0;
            this.passwordBtn.Text = "Password";
            this.passwordBtn.UseVisualStyleBackColor = true;
            this.passwordBtn.Click += new System.EventHandler(this.passwordBtn_Click);
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(3, 16);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape3,
            this.lineShape2});
            this.shapeContainer2.Size = new System.Drawing.Size(644, 206);
            this.shapeContainer2.TabIndex = 2;
            this.shapeContainer2.TabStop = false;
            // 
            // lineShape3
            // 
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 319;
            this.lineShape3.X2 = 638;
            this.lineShape3.Y1 = 41;
            this.lineShape3.Y2 = 41;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 311;
            this.lineShape2.X2 = 311;
            this.lineShape2.Y1 = 2;
            this.lineShape2.Y2 = 195;
            // 
            // pointsTb
            // 
            this.pointsTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pointsTb.Enabled = false;
            this.pointsTb.Location = new System.Drawing.Point(439, 8);
            this.pointsTb.Name = "pointsTb";
            this.pointsTb.Size = new System.Drawing.Size(67, 20);
            this.pointsTb.TabIndex = 7;
            this.pointsTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pointsTb.TextChanged += new System.EventHandler(this.pointsTb_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(398, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Points";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBtn
            // 
            this.groupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBtn.Location = new System.Drawing.Point(238, 4);
            this.groupBtn.Name = "groupBtn";
            this.groupBtn.Size = new System.Drawing.Size(110, 23);
            this.groupBtn.TabIndex = 12;
            this.groupBtn.Text = "Groups";
            this.groupBtn.UseVisualStyleBackColor = true;
            this.groupBtn.Click += new System.EventHandler(this.groupBtn_Click);
            // 
            // groupBoxGroups
            // 
            this.groupBoxGroups.Controls.Add(this.groupsFlowLayout);
            this.groupBoxGroups.Location = new System.Drawing.Point(18, 359);
            this.groupBoxGroups.Name = "groupBoxGroups";
            this.groupBoxGroups.Size = new System.Drawing.Size(599, 261);
            this.groupBoxGroups.TabIndex = 13;
            this.groupBoxGroups.TabStop = false;
            this.groupBoxGroups.Text = "Groups";
            // 
            // groupsFlowLayout
            // 
            this.groupsFlowLayout.AutoScroll = true;
            this.groupsFlowLayout.Location = new System.Drawing.Point(13, 19);
            this.groupsFlowLayout.Name = "groupsFlowLayout";
            this.groupsFlowLayout.Size = new System.Drawing.Size(550, 230);
            this.groupsFlowLayout.TabIndex = 0;
            // 
            // manPanel
            // 
            this.manPanel.Controls.Add(this.groupBtn);
            this.manPanel.Controls.Add(this.label2);
            this.manPanel.Controls.Add(this.pointsTb);
            this.manPanel.Controls.Add(this.settingsBtn);
            this.manPanel.Controls.Add(this.itemsBtn);
            this.manPanel.Location = new System.Drawing.Point(12, 8);
            this.manPanel.Name = "manPanel";
            this.manPanel.Size = new System.Drawing.Size(516, 30);
            this.manPanel.TabIndex = 14;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 754);
            this.Controls.Add(this.manPanel);
            this.Controls.Add(this.grb_settings);
            this.Controls.Add(this.groupBoxGroups);
            this.Controls.Add(this.grb_items);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "User";
            this.Load += new System.EventHandler(this.User_Load);
            this.grb_items.ResumeLayout(false);
            this.grb_items.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.grb_settings.ResumeLayout(false);
            this.grb_settings.PerformLayout();
            this.groupBoxMessage.ResumeLayout(false);
            this.groupBoxMessage.PerformLayout();
            this.groupBoxPassword.ResumeLayout(false);
            this.groupBoxPassword.PerformLayout();
            this.groupBoxGroups.ResumeLayout(false);
            this.manPanel.ResumeLayout(false);
            this.manPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbx_categories;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grb_items;
        private System.Windows.Forms.ListView lw_items;
        private System.Windows.Forms.Button itemsBtn;
        private System.Windows.Forms.Button settingsBtn;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape menLine;
        private System.Windows.Forms.GroupBox grb_settings;
        private System.Windows.Forms.TextBox pointsTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox repPassTb;
        private System.Windows.Forms.TextBox newPassTb;
        private System.Windows.Forms.TextBox initialTb;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button welcomeBtn;
        private System.Windows.Forms.Button passwordBtn;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.GroupBox groupBoxPassword;
        private System.Windows.Forms.TextBox messageTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBoxMessage;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox typeTB;
        private System.Windows.Forms.TextBox nameTb;
        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.DateTimePicker regDate;
        private System.Windows.Forms.Button groupBtn;
        private System.Windows.Forms.GroupBox groupBoxGroups;
        private System.Windows.Forms.FlowLayoutPanel groupsFlowLayout;
        private System.Windows.Forms.GroupBox groupBox1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Panel manPanel;
    }
}