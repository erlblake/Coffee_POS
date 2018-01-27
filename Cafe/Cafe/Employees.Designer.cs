namespace Cafe
{
    partial class Employees
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.EmployUserName = new System.Windows.Forms.TextBox();
            this.EmployPasswordWord = new System.Windows.Forms.TextBox();
            this.EmployUserNameText = new System.Windows.Forms.TextBox();
            this.EmployPasswordText = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.FullNameText = new System.Windows.Forms.TextBox();
            this.EmployFirstName = new System.Windows.Forms.TextBox();
            this.EmployID = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Cooper Black", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(384, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(653, 68);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Adding a new employee ";
            // 
            // EmployUserName
            // 
            this.EmployUserName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployUserName.Location = new System.Drawing.Point(384, 421);
            this.EmployUserName.Name = "EmployUserName";
            this.EmployUserName.ReadOnly = true;
            this.EmployUserName.Size = new System.Drawing.Size(146, 47);
            this.EmployUserName.TabIndex = 3;
            this.EmployUserName.Text = "Username";
            // 
            // EmployPasswordWord
            // 
            this.EmployPasswordWord.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployPasswordWord.Location = new System.Drawing.Point(384, 506);
            this.EmployPasswordWord.Name = "EmployPasswordWord";
            this.EmployPasswordWord.ReadOnly = true;
            this.EmployPasswordWord.Size = new System.Drawing.Size(146, 47);
            this.EmployPasswordWord.TabIndex = 4;
            this.EmployPasswordWord.Text = "Password";
            // 
            // EmployUserNameText
            // 
            this.EmployUserNameText.Location = new System.Drawing.Point(581, 419);
            this.EmployUserNameText.Multiline = true;
            this.EmployUserNameText.Name = "EmployUserNameText";
            this.EmployUserNameText.Size = new System.Drawing.Size(209, 49);
            this.EmployUserNameText.TabIndex = 6;
            // 
            // EmployPasswordText
            // 
            this.EmployPasswordText.Location = new System.Drawing.Point(581, 506);
            this.EmployPasswordText.Multiline = true;
            this.EmployPasswordText.Name = "EmployPasswordText";
            this.EmployPasswordText.Size = new System.Drawing.Size(209, 49);
            this.EmployPasswordText.TabIndex = 7;
            // 
            // ID
            // 
            this.ID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(429, 261);
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Size = new System.Drawing.Size(43, 47);
            this.ID.TabIndex = 8;
            this.ID.Text = "ID";
            // 
            // FullNameText
            // 
            this.FullNameText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullNameText.Location = new System.Drawing.Point(384, 336);
            this.FullNameText.Name = "FullNameText";
            this.FullNameText.ReadOnly = true;
            this.FullNameText.Size = new System.Drawing.Size(146, 47);
            this.FullNameText.TabIndex = 9;
            this.FullNameText.Text = "Full Name";
            // 
            // EmployFirstName
            // 
            this.EmployFirstName.Location = new System.Drawing.Point(581, 336);
            this.EmployFirstName.Multiline = true;
            this.EmployFirstName.Name = "EmployFirstName";
            this.EmployFirstName.Size = new System.Drawing.Size(209, 49);
            this.EmployFirstName.TabIndex = 10;
            // 
            // EmployID
            // 
            this.EmployID.Location = new System.Drawing.Point(581, 259);
            this.EmployID.Multiline = true;
            this.EmployID.Name = "EmployID";
            this.EmployID.Size = new System.Drawing.Size(209, 49);
            this.EmployID.TabIndex = 11;
            this.EmployID.TextChanged += new System.EventHandler(this.EmployID_TextChanged);
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.Location = new System.Drawing.Point(454, 620);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(252, 115);
            this.Save.TabIndex = 12;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.button1_Click);
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 939);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.EmployID);
            this.Controls.Add(this.EmployFirstName);
            this.Controls.Add(this.FullNameText);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.EmployPasswordText);
            this.Controls.Add(this.EmployUserNameText);
            this.Controls.Add(this.EmployPasswordWord);
            this.Controls.Add(this.EmployUserName);
            this.Controls.Add(this.textBox2);
            this.Name = "Employees";
            this.Text = "Employees";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox EmployUserName;
        private System.Windows.Forms.TextBox EmployPasswordWord;
        private System.Windows.Forms.TextBox EmployUserNameText;
        private System.Windows.Forms.TextBox EmployPasswordText;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox FullNameText;
        private System.Windows.Forms.TextBox EmployFirstName;
        private System.Windows.Forms.TextBox EmployID;
        private System.Windows.Forms.Button Save;
    }
}