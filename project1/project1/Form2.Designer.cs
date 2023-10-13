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
            this.Loginbox = new System.Windows.Forms.TextBox();
            this.Pasbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Authorization_button
            // 
            this.Authorization_button.Location = new System.Drawing.Point(83, 262);
            this.Authorization_button.Margin = new System.Windows.Forms.Padding(4);
            this.Authorization_button.Name = "Authorization_button";
            this.Authorization_button.Size = new System.Drawing.Size(196, 24);
            this.Authorization_button.TabIndex = 0;
            this.Authorization_button.Text = "Авторизация";
            this.Authorization_button.UseVisualStyleBackColor = true;
            this.Authorization_button.Click += new System.EventHandler(this.Authorization_button_Click);
            // 
            // Registration_button
            // 
            this.Registration_button.Location = new System.Drawing.Point(83, 297);
            this.Registration_button.Margin = new System.Windows.Forms.Padding(4);
            this.Registration_button.Name = "Registration_button";
            this.Registration_button.Size = new System.Drawing.Size(196, 24);
            this.Registration_button.TabIndex = 1;
            this.Registration_button.Text = "Регистрация";
            this.Registration_button.UseVisualStyleBackColor = true;
            this.Registration_button.Click += new System.EventHandler(this.Registration_button_Click);
            // 
            // Loginbox
            // 
            this.Loginbox.Location = new System.Drawing.Point(83, 177);
            this.Loginbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Loginbox.Name = "Loginbox";
            this.Loginbox.Size = new System.Drawing.Size(196, 22);
            this.Loginbox.TabIndex = 2;
            // 
            // Pasbox
            // 
            this.Pasbox.Location = new System.Drawing.Point(83, 223);
            this.Pasbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pasbox.Name = "Pasbox";
            this.Pasbox.Size = new System.Drawing.Size(196, 22);
            this.Pasbox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Пароль";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 430);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pasbox);
            this.Controls.Add(this.Loginbox);
            this.Controls.Add(this.Registration_button);
            this.Controls.Add(this.Authorization_button);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Authorization_button;
        private System.Windows.Forms.Button Registration_button;
        private System.Windows.Forms.TextBox Loginbox;
        private System.Windows.Forms.TextBox Pasbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}