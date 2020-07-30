namespace DemoUI
{
    partial class EmployedEntryUI
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameValue = new System.Windows.Forms.TextBox();
            this.lastNameValue = new System.Windows.Forms.TextBox();
            this.emailValue = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.mobilePhoneValue = new System.Windows.Forms.TextBox();
            this.mobilePhoneLabel = new System.Windows.Forms.Label();
            this.createEmployeeButton = new System.Windows.Forms.Button();
            this.IdLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.titleLabel.Location = new System.Drawing.Point(25, 25);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(331, 50);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Add New Employee";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.firstNameLabel.Location = new System.Drawing.Point(27, 105);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(139, 37);
            this.firstNameLabel.TabIndex = 1;
            this.firstNameLabel.Text = "First name";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lastNameLabel.Location = new System.Drawing.Point(27, 179);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(137, 37);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Last name";
            // 
            // firstNameValue
            // 
            this.firstNameValue.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameValue.Location = new System.Drawing.Point(190, 105);
            this.firstNameValue.Name = "firstNameValue";
            this.firstNameValue.Size = new System.Drawing.Size(374, 43);
            this.firstNameValue.TabIndex = 3;
            // 
            // lastNameValue
            // 
            this.lastNameValue.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameValue.Location = new System.Drawing.Point(190, 179);
            this.lastNameValue.Name = "lastNameValue";
            this.lastNameValue.Size = new System.Drawing.Size(374, 43);
            this.lastNameValue.TabIndex = 4;
            // 
            // emailValue
            // 
            this.emailValue.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailValue.Location = new System.Drawing.Point(190, 253);
            this.emailValue.Name = "emailValue";
            this.emailValue.Size = new System.Drawing.Size(374, 43);
            this.emailValue.TabIndex = 5;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.emailLabel.Location = new System.Drawing.Point(27, 253);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(82, 37);
            this.emailLabel.TabIndex = 6;
            this.emailLabel.Text = "Email";
            // 
            // mobilePhoneValue
            // 
            this.mobilePhoneValue.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobilePhoneValue.Location = new System.Drawing.Point(190, 327);
            this.mobilePhoneValue.Name = "mobilePhoneValue";
            this.mobilePhoneValue.Size = new System.Drawing.Size(374, 43);
            this.mobilePhoneValue.TabIndex = 7;
            // 
            // mobilePhoneLabel
            // 
            this.mobilePhoneLabel.AutoSize = true;
            this.mobilePhoneLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobilePhoneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.mobilePhoneLabel.Location = new System.Drawing.Point(27, 327);
            this.mobilePhoneLabel.Name = "mobilePhoneLabel";
            this.mobilePhoneLabel.Size = new System.Drawing.Size(138, 37);
            this.mobilePhoneLabel.TabIndex = 8;
            this.mobilePhoneLabel.Text = "Cellphone";
            // 
            // createEmployeeButton
            // 
            this.createEmployeeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createEmployeeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createEmployeeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createEmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createEmployeeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createEmployeeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createEmployeeButton.Location = new System.Drawing.Point(190, 413);
            this.createEmployeeButton.Name = "createEmployeeButton";
            this.createEmployeeButton.Size = new System.Drawing.Size(374, 63);
            this.createEmployeeButton.TabIndex = 9;
            this.createEmployeeButton.Text = "Add Employee";
            this.createEmployeeButton.UseVisualStyleBackColor = true;
            this.createEmployeeButton.Click += new System.EventHandler(this.createEmployeeButton_Click);
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.IdLabel.Location = new System.Drawing.Point(362, 25);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(41, 50);
            this.IdLabel.TabIndex = 10;
            this.IdLabel.Text = "0";
            // 
            // EmployedEntryUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(635, 499);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.createEmployeeButton);
            this.Controls.Add(this.mobilePhoneLabel);
            this.Controls.Add(this.mobilePhoneValue);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.emailValue);
            this.Controls.Add(this.lastNameValue);
            this.Controls.Add(this.firstNameValue);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.titleLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "EmployedEntryUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employed Data Entry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox firstNameValue;
        private System.Windows.Forms.TextBox lastNameValue;
        private System.Windows.Forms.TextBox emailValue;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox mobilePhoneValue;
        private System.Windows.Forms.Label mobilePhoneLabel;
        private System.Windows.Forms.Button createEmployeeButton;
        private System.Windows.Forms.Label IdLabel;
    }
}

