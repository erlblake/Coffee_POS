namespace Cafe
{
    partial class DatabaseTest
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FullName = new System.Windows.Forms.TextBox();
            this.UserName = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Full Name";
            // 
            // FullName
            // 
            this.FullName.Location = new System.Drawing.Point(341, 291);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(105, 31);
            this.FullName.TabIndex = 3;
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(341, 346);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(105, 31);
            this.UserName.TabIndex = 4;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(341, 391);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(105, 31);
            this.Password.TabIndex = 5;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(254, 493);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(176, 109);
            this.Save.TabIndex = 6;
            this.Save.Text = "button1";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // DatabaseTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 810);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.FullName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DatabaseTest";
            this.Text = "DatabaseTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FullName;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button Save;
    }
}