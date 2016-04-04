namespace Contacts
{
    partial class ContactsForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.ageBox = new System.Windows.Forms.TextBox();
            this.ageLabel = new System.Windows.Forms.Label();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.mobileBox = new System.Windows.Forms.TextBox();
            this.mobileLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.listBtn = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 16);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(55, 13);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(217, 20);
            this.nameBox.TabIndex = 1;
            // 
            // ageBox
            // 
            this.ageBox.Location = new System.Drawing.Point(55, 65);
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(217, 20);
            this.ageBox.TabIndex = 3;
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(17, 68);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(26, 13);
            this.ageLabel.TabIndex = 2;
            this.ageLabel.Text = "Age";
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(55, 39);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(217, 20);
            this.addressBox.TabIndex = 5;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(8, 42);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(45, 13);
            this.addressLabel.TabIndex = 4;
            this.addressLabel.Text = "Address";
            // 
            // mobileBox
            // 
            this.mobileBox.Location = new System.Drawing.Point(55, 91);
            this.mobileBox.Name = "mobileBox";
            this.mobileBox.Size = new System.Drawing.Size(217, 20);
            this.mobileBox.TabIndex = 7;
            // 
            // mobileLabel
            // 
            this.mobileLabel.AutoSize = true;
            this.mobileLabel.Location = new System.Drawing.Point(12, 94);
            this.mobileLabel.Name = "mobileLabel";
            this.mobileLabel.Size = new System.Drawing.Size(38, 13);
            this.mobileLabel.TabIndex = 6;
            this.mobileLabel.Text = "Mobile";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(14, 125);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(31, 13);
            this.typeLabel.TabIndex = 8;
            this.typeLabel.Text = "Type";
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(55, 122);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(217, 21);
            this.typeComboBox.TabIndex = 9;
            this.typeComboBox.SelectedIndexChanged += new System.EventHandler(this.typeComboBox_SelectedIndexChanged);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(55, 164);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(104, 23);
            this.saveBtn.TabIndex = 10;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // listBtn
            // 
            this.listBtn.Location = new System.Drawing.Point(168, 164);
            this.listBtn.Name = "listBtn";
            this.listBtn.Size = new System.Drawing.Size(104, 23);
            this.listBtn.TabIndex = 11;
            this.listBtn.Text = "List";
            this.listBtn.UseVisualStyleBackColor = true;
            this.listBtn.Click += new System.EventHandler(this.listBtn_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(278, 13);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(332, 173);
            this.listBox.TabIndex = 12;
            // 
            // ContactsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 195);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.listBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.mobileBox);
            this.Controls.Add(this.mobileLabel);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.ageBox);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.nameLabel);
            this.Name = "ContactsForm";
            this.Text = "Contacts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox ageBox;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox mobileBox;
        private System.Windows.Forms.Label mobileLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button listBtn;
        private System.Windows.Forms.ListBox listBox;
    }
}

