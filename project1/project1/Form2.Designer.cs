namespace project1
{
    partial class Form2
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
            this.Authorization_button = new System.Windows.Forms.Button();
            this.Registration_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Authorization_button
            // 
            this.Authorization_button.Location = new System.Drawing.Point(82, 298);
            this.Authorization_button.Name = "Authorization_button";
            this.Authorization_button.Size = new System.Drawing.Size(196, 23);
            this.Authorization_button.TabIndex = 0;
            this.Authorization_button.Text = "Авторизация";
            this.Authorization_button.UseVisualStyleBackColor = true;
            this.Authorization_button.Click += new System.EventHandler(this.Authorization_button_Click);
            // 
            // Registration_button
            // 
            this.Registration_button.Location = new System.Drawing.Point(82, 327);
            this.Registration_button.Name = "Registration_button";
            this.Registration_button.Size = new System.Drawing.Size(196, 23);
            this.Registration_button.TabIndex = 1;
            this.Registration_button.Text = "Регистрация";
            this.Registration_button.UseVisualStyleBackColor = true;
            this.Registration_button.Click += new System.EventHandler(this.Registration_button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(82, 195);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(82, 223);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(196, 22);
            this.textBox2.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 430);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Registration_button);
            this.Controls.Add(this.Authorization_button);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Authorization_button;
        private System.Windows.Forms.Button Registration_button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}