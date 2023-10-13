namespace project1
{
    partial class FormReg
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
            this.Pasbox1 = new System.Windows.Forms.TextBox();
            this.Loginbox = new System.Windows.Forms.TextBox();
            this.Registration_button = new System.Windows.Forms.Button();
            this.Pasbox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Pasbox1
            // 
            this.Pasbox1.Location = new System.Drawing.Point(56, 179);
            this.Pasbox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pasbox1.Name = "Pasbox1";
            this.Pasbox1.Size = new System.Drawing.Size(196, 22);
            this.Pasbox1.TabIndex = 7;
            // 
            // Loginbox
            // 
            this.Loginbox.Location = new System.Drawing.Point(56, 135);
            this.Loginbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Loginbox.Name = "Loginbox";
            this.Loginbox.Size = new System.Drawing.Size(196, 22);
            this.Loginbox.TabIndex = 6;
            // 
            // Registration_button
            // 
            this.Registration_button.Location = new System.Drawing.Point(56, 269);
            this.Registration_button.Margin = new System.Windows.Forms.Padding(4);
            this.Registration_button.Name = "Registration_button";
            this.Registration_button.Size = new System.Drawing.Size(196, 24);
            this.Registration_button.TabIndex = 5;
            this.Registration_button.Text = "Регистрация";
            this.Registration_button.UseVisualStyleBackColor = true;
            this.Registration_button.Click += new System.EventHandler(this.Registration_button_Click);
            // 
            // Pasbox2
            // 
            this.Pasbox2.Location = new System.Drawing.Point(56, 221);
            this.Pasbox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pasbox2.Name = "Pasbox2";
            this.Pasbox2.Size = new System.Drawing.Size(196, 22);
            this.Pasbox2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Логин";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Повторите пароль";
            // 
            // FormReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 439);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Pasbox2);
            this.Controls.Add(this.Pasbox1);
            this.Controls.Add(this.Loginbox);
            this.Controls.Add(this.Registration_button);
            this.Name = "FormReg";
            this.Text = "FormReg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Pasbox1;
        private System.Windows.Forms.TextBox Loginbox;
        private System.Windows.Forms.Button Registration_button;
        private System.Windows.Forms.TextBox Pasbox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}