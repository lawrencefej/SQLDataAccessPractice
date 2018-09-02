namespace FormUI
{
    partial class Dashboard
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
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.peopleFoundListbox = new System.Windows.Forms.ListBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.firstNameInsText = new System.Windows.Forms.TextBox();
            this.firstNameINSLabel = new System.Windows.Forms.Label();
            this.lastNameInsText = new System.Windows.Forms.TextBox();
            this.lastNameInsLabel = new System.Windows.Forms.Label();
            this.emailAddressInsText = new System.Windows.Forms.TextBox();
            this.EmailAddressInsLabel = new System.Windows.Forms.Label();
            this.phoneNumberInsText = new System.Windows.Forms.TextBox();
            this.phoneNumberInsLabel = new System.Windows.Forms.Label();
            this.insertRecordButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(12, 29);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(115, 25);
            this.lastNameLabel.TabIndex = 0;
            this.lastNameLabel.Text = "Last Name";
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(133, 23);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(194, 31);
            this.lastNameText.TabIndex = 1;
            // 
            // peopleFoundListbox
            // 
            this.peopleFoundListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peopleFoundListbox.FormattingEnabled = true;
            this.peopleFoundListbox.ItemHeight = 16;
            this.peopleFoundListbox.Location = new System.Drawing.Point(17, 74);
            this.peopleFoundListbox.Name = "peopleFoundListbox";
            this.peopleFoundListbox.Size = new System.Drawing.Size(391, 164);
            this.peopleFoundListbox.TabIndex = 2;
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(333, 23);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 30);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // firstNameInsText
            // 
            this.firstNameInsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameInsText.Location = new System.Drawing.Point(133, 278);
            this.firstNameInsText.Multiline = true;
            this.firstNameInsText.Name = "firstNameInsText";
            this.firstNameInsText.Size = new System.Drawing.Size(194, 24);
            this.firstNameInsText.TabIndex = 9;
            // 
            // firstNameINSLabel
            // 
            this.firstNameINSLabel.AutoSize = true;
            this.firstNameINSLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameINSLabel.Location = new System.Drawing.Point(13, 281);
            this.firstNameINSLabel.Name = "firstNameINSLabel";
            this.firstNameINSLabel.Size = new System.Drawing.Size(86, 20);
            this.firstNameINSLabel.TabIndex = 8;
            this.firstNameINSLabel.Text = "First Name";
            // 
            // lastNameInsText
            // 
            this.lastNameInsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameInsText.Location = new System.Drawing.Point(133, 308);
            this.lastNameInsText.Multiline = true;
            this.lastNameInsText.Name = "lastNameInsText";
            this.lastNameInsText.Size = new System.Drawing.Size(194, 24);
            this.lastNameInsText.TabIndex = 11;
            // 
            // lastNameInsLabel
            // 
            this.lastNameInsLabel.AutoSize = true;
            this.lastNameInsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameInsLabel.Location = new System.Drawing.Point(13, 311);
            this.lastNameInsLabel.Name = "lastNameInsLabel";
            this.lastNameInsLabel.Size = new System.Drawing.Size(86, 20);
            this.lastNameInsLabel.TabIndex = 10;
            this.lastNameInsLabel.Text = "Last Name";
            // 
            // emailAddressInsText
            // 
            this.emailAddressInsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailAddressInsText.Location = new System.Drawing.Point(133, 338);
            this.emailAddressInsText.Multiline = true;
            this.emailAddressInsText.Name = "emailAddressInsText";
            this.emailAddressInsText.Size = new System.Drawing.Size(194, 24);
            this.emailAddressInsText.TabIndex = 13;
            // 
            // EmailAddressInsLabel
            // 
            this.EmailAddressInsLabel.AutoSize = true;
            this.EmailAddressInsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailAddressInsLabel.Location = new System.Drawing.Point(13, 341);
            this.EmailAddressInsLabel.Name = "EmailAddressInsLabel";
            this.EmailAddressInsLabel.Size = new System.Drawing.Size(111, 20);
            this.EmailAddressInsLabel.TabIndex = 12;
            this.EmailAddressInsLabel.Text = "Email Address";
            // 
            // phoneNumberInsText
            // 
            this.phoneNumberInsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberInsText.Location = new System.Drawing.Point(133, 368);
            this.phoneNumberInsText.Multiline = true;
            this.phoneNumberInsText.Name = "phoneNumberInsText";
            this.phoneNumberInsText.Size = new System.Drawing.Size(194, 24);
            this.phoneNumberInsText.TabIndex = 15;
            // 
            // phoneNumberInsLabel
            // 
            this.phoneNumberInsLabel.AutoSize = true;
            this.phoneNumberInsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberInsLabel.Location = new System.Drawing.Point(13, 371);
            this.phoneNumberInsLabel.Name = "phoneNumberInsLabel";
            this.phoneNumberInsLabel.Size = new System.Drawing.Size(115, 20);
            this.phoneNumberInsLabel.TabIndex = 14;
            this.phoneNumberInsLabel.Text = "Phone Number";
            // 
            // insertRecordButton
            // 
            this.insertRecordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertRecordButton.Location = new System.Drawing.Point(189, 407);
            this.insertRecordButton.Name = "insertRecordButton";
            this.insertRecordButton.Size = new System.Drawing.Size(75, 30);
            this.insertRecordButton.TabIndex = 16;
            this.insertRecordButton.Text = "Insert";
            this.insertRecordButton.UseVisualStyleBackColor = true;
            this.insertRecordButton.Click += new System.EventHandler(this.insertRecordButton_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 493);
            this.Controls.Add(this.insertRecordButton);
            this.Controls.Add(this.phoneNumberInsText);
            this.Controls.Add(this.phoneNumberInsLabel);
            this.Controls.Add(this.emailAddressInsText);
            this.Controls.Add(this.EmailAddressInsLabel);
            this.Controls.Add(this.lastNameInsText);
            this.Controls.Add(this.lastNameInsLabel);
            this.Controls.Add(this.firstNameInsText);
            this.Controls.Add(this.firstNameINSLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.peopleFoundListbox);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.lastNameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Dashboard";
            this.Text = "SQl Data Access";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.ListBox peopleFoundListbox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox firstNameInsText;
        private System.Windows.Forms.Label firstNameINSLabel;
        private System.Windows.Forms.TextBox lastNameInsText;
        private System.Windows.Forms.Label lastNameInsLabel;
        private System.Windows.Forms.TextBox emailAddressInsText;
        private System.Windows.Forms.Label EmailAddressInsLabel;
        private System.Windows.Forms.TextBox phoneNumberInsText;
        private System.Windows.Forms.Label phoneNumberInsLabel;
        private System.Windows.Forms.Button insertRecordButton;
    }
}

