namespace Mini_411
{
    partial class Form1
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnNumberofCustomers = new System.Windows.Forms.Button();
            this.lbNameOutput = new System.Windows.Forms.ListBox();
            this.lbPhoneOutput = new System.Windows.Forms.ListBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnSearchName = new System.Windows.Forms.Button();
            this.btnSearchNumber = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtEditPhone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(44, 47);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(129, 26);
            this.txtName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(40, 19);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(236, 19);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(115, 20);
            this.lblPhoneNumber.TabIndex = 2;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(240, 47);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(129, 26);
            this.txtPhoneNumber.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(157, 88);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(137, 36);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnNumberofCustomers
            // 
            this.btnNumberofCustomers.Location = new System.Drawing.Point(157, 139);
            this.btnNumberofCustomers.Name = "btnNumberofCustomers";
            this.btnNumberofCustomers.Size = new System.Drawing.Size(137, 58);
            this.btnNumberofCustomers.TabIndex = 5;
            this.btnNumberofCustomers.Text = "Number of Customers";
            this.btnNumberofCustomers.UseVisualStyleBackColor = true;
            this.btnNumberofCustomers.Click += new System.EventHandler(this.btnNumberofCustomers_Click);
            // 
            // lbNameOutput
            // 
            this.lbNameOutput.FormattingEnabled = true;
            this.lbNameOutput.ItemHeight = 20;
            this.lbNameOutput.Location = new System.Drawing.Point(12, 88);
            this.lbNameOutput.Name = "lbNameOutput";
            this.lbNameOutput.Size = new System.Drawing.Size(120, 144);
            this.lbNameOutput.TabIndex = 6;
            this.lbNameOutput.SelectedIndexChanged += new System.EventHandler(this.lbNameOutput_SelectedIndexChanged);
            // 
            // lbPhoneOutput
            // 
            this.lbPhoneOutput.FormattingEnabled = true;
            this.lbPhoneOutput.ItemHeight = 20;
            this.lbPhoneOutput.Location = new System.Drawing.Point(308, 88);
            this.lbPhoneOutput.Name = "lbPhoneOutput";
            this.lbPhoneOutput.Size = new System.Drawing.Size(120, 144);
            this.lbPhoneOutput.TabIndex = 7;
            this.lbPhoneOutput.SelectedIndexChanged += new System.EventHandler(this.lbPhoneOutput_SelectedIndexChanged);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(157, 212);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(137, 36);
            this.btnShow.TabIndex = 8;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnSearchName
            // 
            this.btnSearchName.Location = new System.Drawing.Point(12, 250);
            this.btnSearchName.Name = "btnSearchName";
            this.btnSearchName.Size = new System.Drawing.Size(137, 58);
            this.btnSearchName.TabIndex = 9;
            this.btnSearchName.Text = "Search by Name";
            this.btnSearchName.UseVisualStyleBackColor = true;
            this.btnSearchName.Click += new System.EventHandler(this.btnSearchName_Click);
            // 
            // btnSearchNumber
            // 
            this.btnSearchNumber.Location = new System.Drawing.Point(308, 250);
            this.btnSearchNumber.Name = "btnSearchNumber";
            this.btnSearchNumber.Size = new System.Drawing.Size(137, 58);
            this.btnSearchNumber.TabIndex = 10;
            this.btnSearchNumber.Text = "Search by Number";
            this.btnSearchNumber.UseVisualStyleBackColor = true;
            this.btnSearchNumber.Click += new System.EventHandler(this.btnSearchNumber_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(157, 314);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(137, 36);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtEditPhone
            // 
            this.txtEditPhone.Location = new System.Drawing.Point(157, 260);
            this.txtEditPhone.Name = "txtEditPhone";
            this.txtEditPhone.Size = new System.Drawing.Size(137, 39);
            this.txtEditPhone.TabIndex = 13;
            this.txtEditPhone.Text = "Edit Number";
            this.txtEditPhone.UseVisualStyleBackColor = true;
            this.txtEditPhone.Click += new System.EventHandler(this.txtEditPhone_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 377);
            this.Controls.Add(this.txtEditPhone);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearchNumber);
            this.Controls.Add(this.btnSearchName);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lbPhoneOutput);
            this.Controls.Add(this.lbNameOutput);
            this.Controls.Add(this.btnNumberofCustomers);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Text = "Mini 411";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnNumberofCustomers;
        private System.Windows.Forms.ListBox lbNameOutput;
        private System.Windows.Forms.ListBox lbPhoneOutput;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnSearchName;
        private System.Windows.Forms.Button btnSearchNumber;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button txtEditPhone;
    }
}

