namespace Final_Project
{
    partial class AdminPortal
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
            this.adminTabControl = new System.Windows.Forms.TabControl();
            this.ProductPage = new System.Windows.Forms.TabPage();
            this.ProductDataView = new System.Windows.Forms.DataGridView();
            this.ProductOutputLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ProductDeleteButton = new System.Windows.Forms.Button();
            this.ProductCreateButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ProductUpdateCategoryInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ProductUpdatePriceInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ProductUpdateNameInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductUpdateIDInput = new System.Windows.Forms.TextBox();
            this.ProductSearchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductSearchIDInput = new System.Windows.Forms.TextBox();
            this.UserPage = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CreateUserTeacherCheckBox = new System.Windows.Forms.CheckBox();
            this.CreateUserButton = new System.Windows.Forms.Button();
            this.CreateUserVeteranCheckBox = new System.Windows.Forms.CheckBox();
            this.CreateUserSeniorCheckBox = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.CreateUserAdminCheckBox = new System.Windows.Forms.CheckBox();
            this.GeneratedUserUsernameTextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.GeneratedUserPasswordTextBox = new System.Windows.Forms.TextBox();
            this.UserDataView = new System.Windows.Forms.DataGridView();
            this.UserOutputLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.UpdateUserTeacherCheckbox = new System.Windows.Forms.CheckBox();
            this.UpdateUserVeteranCheckbox = new System.Windows.Forms.CheckBox();
            this.UpdateUserSeniorCheckbox = new System.Windows.Forms.CheckBox();
            this.UpdateUserAdminCheckbox = new System.Windows.Forms.CheckBox();
            this.DeleteUserButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.UpdateUserUsernameInput = new System.Windows.Forms.TextBox();
            this.UpdateUserButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.UpdateUserEmailInput = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.UpdateUserLastNameInput = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.UpdateUserPhoneInput = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.UpdateUserFirstNameInput = new System.Windows.Forms.TextBox();
            this.UserSearchButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.SearchUserUsernameInput = new System.Windows.Forms.TextBox();
            this.InvoicePage = new System.Windows.Forms.TabPage();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.UserSettingsButton = new System.Windows.Forms.Button();
            this.adminTabControl.SuspendLayout();
            this.ProductPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.UserPage.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserDataView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminTabControl
            // 
            this.adminTabControl.Controls.Add(this.ProductPage);
            this.adminTabControl.Controls.Add(this.UserPage);
            this.adminTabControl.Controls.Add(this.InvoicePage);
            this.adminTabControl.Location = new System.Drawing.Point(11, 40);
            this.adminTabControl.Name = "adminTabControl";
            this.adminTabControl.SelectedIndex = 0;
            this.adminTabControl.Size = new System.Drawing.Size(798, 455);
            this.adminTabControl.TabIndex = 0;
            // 
            // ProductPage
            // 
            this.ProductPage.Controls.Add(this.ProductDataView);
            this.ProductPage.Controls.Add(this.ProductOutputLabel);
            this.ProductPage.Controls.Add(this.groupBox1);
            this.ProductPage.Controls.Add(this.ProductSearchButton);
            this.ProductPage.Controls.Add(this.label1);
            this.ProductPage.Controls.Add(this.ProductSearchIDInput);
            this.ProductPage.Location = new System.Drawing.Point(4, 22);
            this.ProductPage.Name = "ProductPage";
            this.ProductPage.Padding = new System.Windows.Forms.Padding(3);
            this.ProductPage.Size = new System.Drawing.Size(790, 429);
            this.ProductPage.TabIndex = 0;
            this.ProductPage.Text = "Products";
            this.ProductPage.UseVisualStyleBackColor = true;
            // 
            // ProductDataView
            // 
            this.ProductDataView.AllowUserToAddRows = false;
            this.ProductDataView.AllowUserToDeleteRows = false;
            this.ProductDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductDataView.Location = new System.Drawing.Point(9, 137);
            this.ProductDataView.Name = "ProductDataView";
            this.ProductDataView.ReadOnly = true;
            this.ProductDataView.Size = new System.Drawing.Size(775, 285);
            this.ProductDataView.TabIndex = 5;
            // 
            // ProductOutputLabel
            // 
            this.ProductOutputLabel.AutoSize = true;
            this.ProductOutputLabel.ForeColor = System.Drawing.Color.Brown;
            this.ProductOutputLabel.Location = new System.Drawing.Point(510, 13);
            this.ProductOutputLabel.Name = "ProductOutputLabel";
            this.ProductOutputLabel.Size = new System.Drawing.Size(115, 13);
            this.ProductOutputLabel.TabIndex = 10;
            this.ProductOutputLabel.Text = "Could not Find Product";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ProductDeleteButton);
            this.groupBox1.Controls.Add(this.ProductCreateButton);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.ProductUpdateCategoryInput);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ProductUpdatePriceInput);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ProductUpdateNameInput);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ProductUpdateIDInput);
            this.groupBox1.Location = new System.Drawing.Point(9, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 97);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create or Update Product";
            // 
            // ProductDeleteButton
            // 
            this.ProductDeleteButton.Location = new System.Drawing.Point(382, 65);
            this.ProductDeleteButton.Name = "ProductDeleteButton";
            this.ProductDeleteButton.Size = new System.Drawing.Size(258, 23);
            this.ProductDeleteButton.TabIndex = 9;
            this.ProductDeleteButton.Text = "Delete Product";
            this.ProductDeleteButton.UseVisualStyleBackColor = true;
            this.ProductDeleteButton.Click += new System.EventHandler(this.ProductDeleteButton_Click);
            // 
            // ProductCreateButton
            // 
            this.ProductCreateButton.Location = new System.Drawing.Point(118, 65);
            this.ProductCreateButton.Name = "ProductCreateButton";
            this.ProductCreateButton.Size = new System.Drawing.Size(258, 23);
            this.ProductCreateButton.TabIndex = 8;
            this.ProductCreateButton.Text = "Create / Update Product";
            this.ProductCreateButton.UseVisualStyleBackColor = true;
            this.ProductCreateButton.Click += new System.EventHandler(this.ProductCreateButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(379, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Product Category";
            // 
            // ProductUpdateCategoryInput
            // 
            this.ProductUpdateCategoryInput.Location = new System.Drawing.Point(382, 39);
            this.ProductUpdateCategoryInput.Name = "ProductUpdateCategoryInput";
            this.ProductUpdateCategoryInput.Size = new System.Drawing.Size(126, 20);
            this.ProductUpdateCategoryInput.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(247, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Product Price *";
            // 
            // ProductUpdatePriceInput
            // 
            this.ProductUpdatePriceInput.Location = new System.Drawing.Point(250, 39);
            this.ProductUpdatePriceInput.Name = "ProductUpdatePriceInput";
            this.ProductUpdatePriceInput.Size = new System.Drawing.Size(126, 20);
            this.ProductUpdatePriceInput.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(511, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Product Name";
            // 
            // ProductUpdateNameInput
            // 
            this.ProductUpdateNameInput.Location = new System.Drawing.Point(514, 39);
            this.ProductUpdateNameInput.Name = "ProductUpdateNameInput";
            this.ProductUpdateNameInput.Size = new System.Drawing.Size(126, 20);
            this.ProductUpdateNameInput.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Product ID *";
            // 
            // ProductUpdateIDInput
            // 
            this.ProductUpdateIDInput.Location = new System.Drawing.Point(118, 39);
            this.ProductUpdateIDInput.Name = "ProductUpdateIDInput";
            this.ProductUpdateIDInput.Size = new System.Drawing.Size(126, 20);
            this.ProductUpdateIDInput.TabIndex = 0;
            // 
            // ProductSearchButton
            // 
            this.ProductSearchButton.Location = new System.Drawing.Point(341, 10);
            this.ProductSearchButton.Name = "ProductSearchButton";
            this.ProductSearchButton.Size = new System.Drawing.Size(163, 20);
            this.ProductSearchButton.TabIndex = 4;
            this.ProductSearchButton.Text = "Search for Product";
            this.ProductSearchButton.UseVisualStyleBackColor = true;
            this.ProductSearchButton.Click += new System.EventHandler(this.ProductSearchButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search Product ID:";
            // 
            // ProductSearchIDInput
            // 
            this.ProductSearchIDInput.Location = new System.Drawing.Point(127, 10);
            this.ProductSearchIDInput.Name = "ProductSearchIDInput";
            this.ProductSearchIDInput.Size = new System.Drawing.Size(208, 20);
            this.ProductSearchIDInput.TabIndex = 0;
            // 
            // UserPage
            // 
            this.UserPage.Controls.Add(this.groupBox3);
            this.UserPage.Controls.Add(this.UserDataView);
            this.UserPage.Controls.Add(this.UserOutputLabel);
            this.UserPage.Controls.Add(this.groupBox2);
            this.UserPage.Controls.Add(this.UserSearchButton);
            this.UserPage.Controls.Add(this.label12);
            this.UserPage.Controls.Add(this.SearchUserUsernameInput);
            this.UserPage.Location = new System.Drawing.Point(4, 22);
            this.UserPage.Name = "UserPage";
            this.UserPage.Padding = new System.Windows.Forms.Padding(3);
            this.UserPage.Size = new System.Drawing.Size(790, 429);
            this.UserPage.TabIndex = 1;
            this.UserPage.Text = "Users";
            this.UserPage.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CreateUserTeacherCheckBox);
            this.groupBox3.Controls.Add(this.CreateUserButton);
            this.groupBox3.Controls.Add(this.CreateUserVeteranCheckBox);
            this.groupBox3.Controls.Add(this.CreateUserSeniorCheckBox);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.CreateUserAdminCheckBox);
            this.groupBox3.Controls.Add(this.GeneratedUserUsernameTextBox);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.GeneratedUserPasswordTextBox);
            this.groupBox3.Location = new System.Drawing.Point(9, 137);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(775, 97);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Create New User";
            // 
            // CreateUserTeacherCheckBox
            // 
            this.CreateUserTeacherCheckBox.AutoSize = true;
            this.CreateUserTeacherCheckBox.Location = new System.Drawing.Point(280, 70);
            this.CreateUserTeacherCheckBox.Name = "CreateUserTeacherCheckBox";
            this.CreateUserTeacherCheckBox.Size = new System.Drawing.Size(66, 17);
            this.CreateUserTeacherCheckBox.TabIndex = 19;
            this.CreateUserTeacherCheckBox.Text = "Teacher";
            this.CreateUserTeacherCheckBox.UseVisualStyleBackColor = true;
            // 
            // CreateUserButton
            // 
            this.CreateUserButton.Location = new System.Drawing.Point(55, 39);
            this.CreateUserButton.Name = "CreateUserButton";
            this.CreateUserButton.Size = new System.Drawing.Size(126, 23);
            this.CreateUserButton.TabIndex = 11;
            this.CreateUserButton.Text = "Create New User";
            this.CreateUserButton.UseVisualStyleBackColor = true;
            this.CreateUserButton.Click += new System.EventHandler(this.CreateUserButton_Click);
            // 
            // CreateUserVeteranCheckBox
            // 
            this.CreateUserVeteranCheckBox.AutoSize = true;
            this.CreateUserVeteranCheckBox.Location = new System.Drawing.Point(200, 70);
            this.CreateUserVeteranCheckBox.Name = "CreateUserVeteranCheckBox";
            this.CreateUserVeteranCheckBox.Size = new System.Drawing.Size(63, 17);
            this.CreateUserVeteranCheckBox.TabIndex = 18;
            this.CreateUserVeteranCheckBox.Text = "Veteran";
            this.CreateUserVeteranCheckBox.UseVisualStyleBackColor = true;
            // 
            // CreateUserSeniorCheckBox
            // 
            this.CreateUserSeniorCheckBox.AutoSize = true;
            this.CreateUserSeniorCheckBox.Location = new System.Drawing.Point(127, 70);
            this.CreateUserSeniorCheckBox.Name = "CreateUserSeniorCheckBox";
            this.CreateUserSeniorCheckBox.Size = new System.Drawing.Size(56, 17);
            this.CreateUserSeniorCheckBox.TabIndex = 17;
            this.CreateUserSeniorCheckBox.Text = "Senior";
            this.CreateUserSeniorCheckBox.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(184, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(108, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "Generated Username";
            // 
            // CreateUserAdminCheckBox
            // 
            this.CreateUserAdminCheckBox.AutoSize = true;
            this.CreateUserAdminCheckBox.Location = new System.Drawing.Point(55, 70);
            this.CreateUserAdminCheckBox.Name = "CreateUserAdminCheckBox";
            this.CreateUserAdminCheckBox.Size = new System.Drawing.Size(55, 17);
            this.CreateUserAdminCheckBox.TabIndex = 16;
            this.CreateUserAdminCheckBox.Text = "Admin";
            this.CreateUserAdminCheckBox.UseVisualStyleBackColor = true;
            // 
            // GeneratedUserUsernameTextBox
            // 
            this.GeneratedUserUsernameTextBox.Location = new System.Drawing.Point(187, 41);
            this.GeneratedUserUsernameTextBox.Name = "GeneratedUserUsernameTextBox";
            this.GeneratedUserUsernameTextBox.ReadOnly = true;
            this.GeneratedUserUsernameTextBox.Size = new System.Drawing.Size(258, 20);
            this.GeneratedUserUsernameTextBox.TabIndex = 6;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(448, 26);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(106, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "Generated Password";
            // 
            // GeneratedUserPasswordTextBox
            // 
            this.GeneratedUserPasswordTextBox.Location = new System.Drawing.Point(451, 42);
            this.GeneratedUserPasswordTextBox.Name = "GeneratedUserPasswordTextBox";
            this.GeneratedUserPasswordTextBox.ReadOnly = true;
            this.GeneratedUserPasswordTextBox.Size = new System.Drawing.Size(258, 20);
            this.GeneratedUserPasswordTextBox.TabIndex = 2;
            // 
            // UserDataView
            // 
            this.UserDataView.AllowUserToAddRows = false;
            this.UserDataView.AllowUserToDeleteRows = false;
            this.UserDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserDataView.Location = new System.Drawing.Point(9, 240);
            this.UserDataView.Name = "UserDataView";
            this.UserDataView.ReadOnly = true;
            this.UserDataView.Size = new System.Drawing.Size(775, 182);
            this.UserDataView.TabIndex = 14;
            // 
            // UserOutputLabel
            // 
            this.UserOutputLabel.AutoSize = true;
            this.UserOutputLabel.ForeColor = System.Drawing.Color.Brown;
            this.UserOutputLabel.Location = new System.Drawing.Point(510, 13);
            this.UserOutputLabel.Name = "UserOutputLabel";
            this.UserOutputLabel.Size = new System.Drawing.Size(100, 13);
            this.UserOutputLabel.TabIndex = 16;
            this.UserOutputLabel.Text = "Could not Find User";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.UpdateUserTeacherCheckbox);
            this.groupBox2.Controls.Add(this.UpdateUserVeteranCheckbox);
            this.groupBox2.Controls.Add(this.UpdateUserSeniorCheckbox);
            this.groupBox2.Controls.Add(this.UpdateUserAdminCheckbox);
            this.groupBox2.Controls.Add(this.DeleteUserButton);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.UpdateUserUsernameInput);
            this.groupBox2.Controls.Add(this.UpdateUserButton);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.UpdateUserEmailInput);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.UpdateUserLastNameInput);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.UpdateUserPhoneInput);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.UpdateUserFirstNameInput);
            this.groupBox2.Location = new System.Drawing.Point(9, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(775, 97);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update Existing User";
            // 
            // UpdateUserTeacherCheckbox
            // 
            this.UpdateUserTeacherCheckbox.AutoSize = true;
            this.UpdateUserTeacherCheckbox.Location = new System.Drawing.Point(280, 69);
            this.UpdateUserTeacherCheckbox.Name = "UpdateUserTeacherCheckbox";
            this.UpdateUserTeacherCheckbox.Size = new System.Drawing.Size(66, 17);
            this.UpdateUserTeacherCheckbox.TabIndex = 15;
            this.UpdateUserTeacherCheckbox.Text = "Teacher";
            this.UpdateUserTeacherCheckbox.UseVisualStyleBackColor = true;
            // 
            // UpdateUserVeteranCheckbox
            // 
            this.UpdateUserVeteranCheckbox.AutoSize = true;
            this.UpdateUserVeteranCheckbox.Location = new System.Drawing.Point(200, 69);
            this.UpdateUserVeteranCheckbox.Name = "UpdateUserVeteranCheckbox";
            this.UpdateUserVeteranCheckbox.Size = new System.Drawing.Size(63, 17);
            this.UpdateUserVeteranCheckbox.TabIndex = 14;
            this.UpdateUserVeteranCheckbox.Text = "Veteran";
            this.UpdateUserVeteranCheckbox.UseVisualStyleBackColor = true;
            // 
            // UpdateUserSeniorCheckbox
            // 
            this.UpdateUserSeniorCheckbox.AutoSize = true;
            this.UpdateUserSeniorCheckbox.Location = new System.Drawing.Point(127, 69);
            this.UpdateUserSeniorCheckbox.Name = "UpdateUserSeniorCheckbox";
            this.UpdateUserSeniorCheckbox.Size = new System.Drawing.Size(56, 17);
            this.UpdateUserSeniorCheckbox.TabIndex = 13;
            this.UpdateUserSeniorCheckbox.Text = "Senior";
            this.UpdateUserSeniorCheckbox.UseVisualStyleBackColor = true;
            // 
            // UpdateUserAdminCheckbox
            // 
            this.UpdateUserAdminCheckbox.AutoSize = true;
            this.UpdateUserAdminCheckbox.Location = new System.Drawing.Point(55, 69);
            this.UpdateUserAdminCheckbox.Name = "UpdateUserAdminCheckbox";
            this.UpdateUserAdminCheckbox.Size = new System.Drawing.Size(55, 17);
            this.UpdateUserAdminCheckbox.TabIndex = 12;
            this.UpdateUserAdminCheckbox.Text = "Admin";
            this.UpdateUserAdminCheckbox.UseVisualStyleBackColor = true;
            // 
            // DeleteUserButton
            // 
            this.DeleteUserButton.Location = new System.Drawing.Point(583, 65);
            this.DeleteUserButton.Name = "DeleteUserButton";
            this.DeleteUserButton.Size = new System.Drawing.Size(126, 23);
            this.DeleteUserButton.TabIndex = 11;
            this.DeleteUserButton.Text = "Delete User";
            this.DeleteUserButton.UseVisualStyleBackColor = true;
            this.DeleteUserButton.Click += new System.EventHandler(this.DeleteUserButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Username *";
            // 
            // UpdateUserUsernameInput
            // 
            this.UpdateUserUsernameInput.Location = new System.Drawing.Point(55, 39);
            this.UpdateUserUsernameInput.Name = "UpdateUserUsernameInput";
            this.UpdateUserUsernameInput.Size = new System.Drawing.Size(126, 20);
            this.UpdateUserUsernameInput.TabIndex = 9;
            // 
            // UpdateUserButton
            // 
            this.UpdateUserButton.Location = new System.Drawing.Point(451, 65);
            this.UpdateUserButton.Name = "UpdateUserButton";
            this.UpdateUserButton.Size = new System.Drawing.Size(126, 23);
            this.UpdateUserButton.TabIndex = 8;
            this.UpdateUserButton.Text = "Update User Information";
            this.UpdateUserButton.UseVisualStyleBackColor = true;
            this.UpdateUserButton.Click += new System.EventHandler(this.UpdateUserButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(448, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Email Address";
            // 
            // UpdateUserEmailInput
            // 
            this.UpdateUserEmailInput.Location = new System.Drawing.Point(451, 39);
            this.UpdateUserEmailInput.Name = "UpdateUserEmailInput";
            this.UpdateUserEmailInput.Size = new System.Drawing.Size(126, 20);
            this.UpdateUserEmailInput.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(316, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Last Name";
            // 
            // UpdateUserLastNameInput
            // 
            this.UpdateUserLastNameInput.Location = new System.Drawing.Point(319, 39);
            this.UpdateUserLastNameInput.Name = "UpdateUserLastNameInput";
            this.UpdateUserLastNameInput.Size = new System.Drawing.Size(126, 20);
            this.UpdateUserLastNameInput.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(580, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Phone Number";
            // 
            // UpdateUserPhoneInput
            // 
            this.UpdateUserPhoneInput.Location = new System.Drawing.Point(583, 39);
            this.UpdateUserPhoneInput.Name = "UpdateUserPhoneInput";
            this.UpdateUserPhoneInput.Size = new System.Drawing.Size(126, 20);
            this.UpdateUserPhoneInput.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(184, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "First Name";
            // 
            // UpdateUserFirstNameInput
            // 
            this.UpdateUserFirstNameInput.Location = new System.Drawing.Point(187, 39);
            this.UpdateUserFirstNameInput.Name = "UpdateUserFirstNameInput";
            this.UpdateUserFirstNameInput.Size = new System.Drawing.Size(126, 20);
            this.UpdateUserFirstNameInput.TabIndex = 0;
            // 
            // UserSearchButton
            // 
            this.UserSearchButton.Location = new System.Drawing.Point(341, 10);
            this.UserSearchButton.Name = "UserSearchButton";
            this.UserSearchButton.Size = new System.Drawing.Size(163, 20);
            this.UserSearchButton.TabIndex = 13;
            this.UserSearchButton.Text = "Search for User";
            this.UserSearchButton.UseVisualStyleBackColor = true;
            this.UserSearchButton.Click += new System.EventHandler(this.UserSearchButton_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Search Username:";
            // 
            // SearchUserUsernameInput
            // 
            this.SearchUserUsernameInput.Location = new System.Drawing.Point(127, 10);
            this.SearchUserUsernameInput.Name = "SearchUserUsernameInput";
            this.SearchUserUsernameInput.Size = new System.Drawing.Size(208, 20);
            this.SearchUserUsernameInput.TabIndex = 11;
            // 
            // InvoicePage
            // 
            this.InvoicePage.Location = new System.Drawing.Point(4, 22);
            this.InvoicePage.Name = "InvoicePage";
            this.InvoicePage.Size = new System.Drawing.Size(790, 429);
            this.InvoicePage.TabIndex = 2;
            this.InvoicePage.Text = "Invoices";
            this.InvoicePage.UseVisualStyleBackColor = true;
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(649, 12);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(75, 23);
            this.LogoutButton.TabIndex = 1;
            this.LogoutButton.Text = "&Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(730, 12);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "&Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Hello,";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(43, 17);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(111, 13);
            this.UsernameLabel.TabIndex = 4;
            this.UsernameLabel.Text = "INSERT USERNAME";
            // 
            // UserSettingsButton
            // 
            this.UserSettingsButton.Location = new System.Drawing.Point(568, 12);
            this.UserSettingsButton.Name = "UserSettingsButton";
            this.UserSettingsButton.Size = new System.Drawing.Size(75, 23);
            this.UserSettingsButton.TabIndex = 5;
            this.UserSettingsButton.Text = "My &Account";
            this.UserSettingsButton.UseVisualStyleBackColor = true;
            this.UserSettingsButton.Click += new System.EventHandler(this.UserSettingsButton_Click);
            // 
            // AdminPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 506);
            this.Controls.Add(this.UserSettingsButton);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.adminTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximumSize = new System.Drawing.Size(837, 545);
            this.Name = "AdminPortal";
            this.Text = "Admin Portal";
            this.adminTabControl.ResumeLayout(false);
            this.ProductPage.ResumeLayout(false);
            this.ProductPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.UserPage.ResumeLayout(false);
            this.UserPage.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserDataView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl adminTabControl;
        private System.Windows.Forms.TabPage ProductPage;
        private System.Windows.Forms.TabPage UserPage;
        private System.Windows.Forms.TabPage InvoicePage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ProductSearchIDInput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ProductUpdateIDInput;
        private System.Windows.Forms.Button ProductSearchButton;
        private System.Windows.Forms.Button ProductDeleteButton;
        private System.Windows.Forms.Button ProductCreateButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ProductUpdateCategoryInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ProductUpdatePriceInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ProductUpdateNameInput;
        private System.Windows.Forms.Label ProductOutputLabel;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.DataGridView ProductDataView;
        private System.Windows.Forms.Button UserSettingsButton;
        private System.Windows.Forms.DataGridView UserDataView;
        private System.Windows.Forms.Label UserOutputLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button UpdateUserButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox UpdateUserEmailInput;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox UpdateUserLastNameInput;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox UpdateUserPhoneInput;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox UpdateUserFirstNameInput;
        private System.Windows.Forms.Button UserSearchButton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox SearchUserUsernameInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UpdateUserUsernameInput;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button CreateUserButton;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox GeneratedUserUsernameTextBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox GeneratedUserPasswordTextBox;
        private System.Windows.Forms.Button DeleteUserButton;
        private System.Windows.Forms.CheckBox UpdateUserTeacherCheckbox;
        private System.Windows.Forms.CheckBox UpdateUserVeteranCheckbox;
        private System.Windows.Forms.CheckBox UpdateUserSeniorCheckbox;
        private System.Windows.Forms.CheckBox UpdateUserAdminCheckbox;
        private System.Windows.Forms.CheckBox CreateUserTeacherCheckBox;
        private System.Windows.Forms.CheckBox CreateUserVeteranCheckBox;
        private System.Windows.Forms.CheckBox CreateUserSeniorCheckBox;
        private System.Windows.Forms.CheckBox CreateUserAdminCheckBox;
    }
}