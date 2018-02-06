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
            this.Save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.UserNameText = new System.Windows.Forms.TextBox();
            this.FullNameText = new System.Windows.Forms.TextBox();
            this.IDText = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.FullName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(321, 410);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(100, 57);
            this.Save.TabIndex = 29;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 51);
            this.label1.TabIndex = 28;
            this.label1.Text = "Cafe Employees";
            // 
            // PasswordText
            // 
            this.PasswordText.Location = new System.Drawing.Point(321, 336);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(132, 31);
            this.PasswordText.TabIndex = 27;
            // 
            // UserNameText
            // 
            this.UserNameText.Location = new System.Drawing.Point(321, 281);
            this.UserNameText.Name = "UserNameText";
            this.UserNameText.Size = new System.Drawing.Size(132, 31);
            this.UserNameText.TabIndex = 26;
            // 
            // FullNameText
            // 
            this.FullNameText.Location = new System.Drawing.Point(321, 221);
            this.FullNameText.Name = "FullNameText";
            this.FullNameText.Size = new System.Drawing.Size(132, 31);
            this.FullNameText.TabIndex = 25;
            // 
            // IDText
            // 
            this.IDText.Location = new System.Drawing.Point(321, 170);
            this.IDText.Name = "IDText";
            this.IDText.Size = new System.Drawing.Size(132, 31);
            this.IDText.TabIndex = 24;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(164, 342);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(106, 25);
            this.Password.TabIndex = 23;
            this.Password.Text = "Password";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(164, 176);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(32, 25);
            this.ID.TabIndex = 22;
            this.ID.Text = "ID";
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Location = new System.Drawing.Point(164, 287);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(119, 25);
            this.UserName.TabIndex = 21;
            this.UserName.Text = "User Name";
            // 
            // FullName
            // 
            this.FullName.AutoSize = true;
            this.FullName.Location = new System.Drawing.Point(164, 227);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(109, 25);
            this.FullName.TabIndex = 20;
            this.FullName.Text = "Full Name";
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 539);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.UserNameText);
            this.Controls.Add(this.FullNameText);
            this.Controls.Add(this.IDText);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.FullName);
            this.Name = "Employees";
            this.Text = "Employees";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.TextBox UserNameText;
        private System.Windows.Forms.TextBox FullNameText;
        private System.Windows.Forms.TextBox IDText;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label FullName;
    }
}