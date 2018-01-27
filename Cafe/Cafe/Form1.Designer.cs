namespace Cafe
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.UserNameText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(350, 254);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(146, 47);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Username";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Cooper Black", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(350, 85);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(475, 68);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Login to the Cafe ";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(350, 345);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(146, 47);
            this.textBox4.TabIndex = 3;
            this.textBox4.Text = "Password";
            // 
            // PasswordText
            // 
            this.PasswordText.Location = new System.Drawing.Point(527, 345);
            this.PasswordText.Multiline = true;
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(209, 49);
            this.PasswordText.TabIndex = 4;
            this.PasswordText.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // UserNameText
            // 
            this.UserNameText.Location = new System.Drawing.Point(527, 252);
            this.UserNameText.Multiline = true;
            this.UserNameText.Name = "UserNameText";
            this.UserNameText.Size = new System.Drawing.Size(209, 49);
            this.UserNameText.TabIndex = 5;
            this.UserNameText.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(350, 432);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 65);
            this.button1.TabIndex = 6;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 561);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UserNameText);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.TextBox UserNameText;
        private System.Windows.Forms.Button button1;
    }
}

