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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ProductPage = new System.Windows.Forms.TabPage();
            this.ProductOutputLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ProductUpdateCategoryInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ProductUpdatePriceInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ProductUpdateNameInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductUpdateIDInput = new System.Windows.Forms.TextBox();
            this.ProductSearchButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ProductSearchNameInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductSearchIDInput = new System.Windows.Forms.TextBox();
            this.UserPage = new System.Windows.Forms.TabPage();
            this.InvoicePage = new System.Windows.Forms.TabPage();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.ProductPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ProductPage);
            this.tabControl1.Controls.Add(this.UserPage);
            this.tabControl1.Controls.Add(this.InvoicePage);
            this.tabControl1.Location = new System.Drawing.Point(11, 40);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(798, 180);
            this.tabControl1.TabIndex = 0;
            // 
            // ProductPage
            // 
            this.ProductPage.Controls.Add(this.ProductOutputLabel);
            this.ProductPage.Controls.Add(this.groupBox1);
            this.ProductPage.Controls.Add(this.ProductSearchButton);
            this.ProductPage.Controls.Add(this.label2);
            this.ProductPage.Controls.Add(this.ProductSearchNameInput);
            this.ProductPage.Controls.Add(this.label1);
            this.ProductPage.Controls.Add(this.ProductSearchIDInput);
            this.ProductPage.Location = new System.Drawing.Point(4, 22);
            this.ProductPage.Name = "ProductPage";
            this.ProductPage.Padding = new System.Windows.Forms.Padding(3);
            this.ProductPage.Size = new System.Drawing.Size(790, 154);
            this.ProductPage.TabIndex = 0;
            this.ProductPage.Text = "Products";
            this.ProductPage.UseVisualStyleBackColor = true;
            // 
            // ProductOutputLabel
            // 
            this.ProductOutputLabel.AutoSize = true;
            this.ProductOutputLabel.ForeColor = System.Drawing.Color.Brown;
            this.ProductOutputLabel.Location = new System.Drawing.Point(510, 23);
            this.ProductOutputLabel.Name = "ProductOutputLabel";
            this.ProductOutputLabel.Size = new System.Drawing.Size(115, 13);
            this.ProductOutputLabel.TabIndex = 10;
            this.ProductOutputLabel.Text = "Could not Find Product";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.ProductUpdateCategoryInput);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ProductUpdatePriceInput);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ProductUpdateNameInput);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ProductUpdateIDInput);
            this.groupBox1.Location = new System.Drawing.Point(9, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 127);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Product";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(382, 65);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(258, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Delete Product";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(118, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(258, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Create / Update Product";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(511, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Product Category:";
            // 
            // ProductUpdateCategoryInput
            // 
            this.ProductUpdateCategoryInput.Location = new System.Drawing.Point(514, 39);
            this.ProductUpdateCategoryInput.Name = "ProductUpdateCategoryInput";
            this.ProductUpdateCategoryInput.Size = new System.Drawing.Size(126, 20);
            this.ProductUpdateCategoryInput.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(379, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Product Price:";
            // 
            // ProductUpdatePriceInput
            // 
            this.ProductUpdatePriceInput.Location = new System.Drawing.Point(382, 39);
            this.ProductUpdatePriceInput.Name = "ProductUpdatePriceInput";
            this.ProductUpdatePriceInput.Size = new System.Drawing.Size(126, 20);
            this.ProductUpdatePriceInput.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Product Name:";
            // 
            // ProductUpdateNameInput
            // 
            this.ProductUpdateNameInput.Location = new System.Drawing.Point(250, 39);
            this.ProductUpdateNameInput.Name = "ProductUpdateNameInput";
            this.ProductUpdateNameInput.Size = new System.Drawing.Size(126, 20);
            this.ProductUpdateNameInput.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Product ID:";
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
            this.ProductSearchButton.Location = new System.Drawing.Point(341, 6);
            this.ProductSearchButton.Name = "ProductSearchButton";
            this.ProductSearchButton.Size = new System.Drawing.Size(163, 46);
            this.ProductSearchButton.TabIndex = 4;
            this.ProductSearchButton.Text = "Search for Product";
            this.ProductSearchButton.UseVisualStyleBackColor = true;
            this.ProductSearchButton.Click += new System.EventHandler(this.ProductSearchButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Search Product Name:";
            // 
            // ProductSearchNameInput
            // 
            this.ProductSearchNameInput.Location = new System.Drawing.Point(127, 32);
            this.ProductSearchNameInput.Name = "ProductSearchNameInput";
            this.ProductSearchNameInput.Size = new System.Drawing.Size(208, 20);
            this.ProductSearchNameInput.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search Product ID:";
            // 
            // ProductSearchIDInput
            // 
            this.ProductSearchIDInput.Location = new System.Drawing.Point(127, 6);
            this.ProductSearchIDInput.Name = "ProductSearchIDInput";
            this.ProductSearchIDInput.Size = new System.Drawing.Size(208, 20);
            this.ProductSearchIDInput.TabIndex = 0;
            // 
            // UserPage
            // 
            this.UserPage.Location = new System.Drawing.Point(4, 22);
            this.UserPage.Name = "UserPage";
            this.UserPage.Padding = new System.Windows.Forms.Padding(3);
            this.UserPage.Size = new System.Drawing.Size(790, 154);
            this.UserPage.TabIndex = 1;
            this.UserPage.Text = "Users";
            this.UserPage.UseVisualStyleBackColor = true;
            // 
            // InvoicePage
            // 
            this.InvoicePage.Location = new System.Drawing.Point(4, 22);
            this.InvoicePage.Name = "InvoicePage";
            this.InvoicePage.Size = new System.Drawing.Size(790, 154);
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
            // AdminPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 232);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AdminPortal";
            this.Text = "AdminPortal";
            this.tabControl1.ResumeLayout(false);
            this.ProductPage.ResumeLayout(false);
            this.ProductPage.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ProductPage;
        private System.Windows.Forms.TabPage UserPage;
        private System.Windows.Forms.TabPage InvoicePage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ProductSearchIDInput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ProductUpdateIDInput;
        private System.Windows.Forms.Button ProductSearchButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ProductSearchNameInput;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
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
    }
}