namespace project1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Add_money_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Decrease_money_button = new System.Windows.Forms.Button();
            this.Display_button = new System.Windows.Forms.Button();
            this.faq_button = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // Add_money_button
            // 
            this.Add_money_button.AutoEllipsis = true;
            this.Add_money_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Add_money_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Add_money_button.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.Add_money_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_money_button.Location = new System.Drawing.Point(187, 456);
            this.Add_money_button.Name = "Add_money_button";
            this.Add_money_button.Size = new System.Drawing.Size(143, 33);
            this.Add_money_button.TabIndex = 0;
            this.Add_money_button.Text = "Добавить";
            this.Add_money_button.UseVisualStyleBackColor = false;
            this.Add_money_button.Click += new System.EventHandler(this.Add_money_button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(187, 428);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Название";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(357, 428);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(114, 22);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Сумма";
            // 
            // Decrease_money_button
            // 
            this.Decrease_money_button.AllowDrop = true;
            this.Decrease_money_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Decrease_money_button.AutoEllipsis = true;
            this.Decrease_money_button.BackColor = System.Drawing.Color.LightCoral;
            this.Decrease_money_button.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Decrease_money_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Decrease_money_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Decrease_money_button.Location = new System.Drawing.Point(336, 456);
            this.Decrease_money_button.Name = "Decrease_money_button";
            this.Decrease_money_button.Size = new System.Drawing.Size(135, 33);
            this.Decrease_money_button.TabIndex = 3;
            this.Decrease_money_button.Text = "Убавить";
            this.Decrease_money_button.UseVisualStyleBackColor = false;
            this.Decrease_money_button.Click += new System.EventHandler(this.Decrease_money_button_Click);
            // 
            // Display_button
            // 
            this.Display_button.AutoEllipsis = true;
            this.Display_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Display_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Display_button.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.Display_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Display_button.Location = new System.Drawing.Point(187, 495);
            this.Display_button.Name = "Display_button";
            this.Display_button.Size = new System.Drawing.Size(240, 33);
            this.Display_button.TabIndex = 4;
            this.Display_button.Text = "Отобразить траты";
            this.Display_button.UseVisualStyleBackColor = false;
            this.Display_button.Click += new System.EventHandler(this.Display_button_Click);
            // 
            // faq_button
            // 
            this.faq_button.AutoEllipsis = true;
            this.faq_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.faq_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.faq_button.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.faq_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.faq_button.Location = new System.Drawing.Point(433, 495);
            this.faq_button.Name = "faq_button";
            this.faq_button.Size = new System.Drawing.Size(38, 33);
            this.faq_button.TabIndex = 5;
            this.faq_button.Text = "?";
            this.faq_button.UseVisualStyleBackColor = false;
            this.faq_button.Click += new System.EventHandler(this.faq_button_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Enabled = false;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(45, 32);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(566, 354);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "хз";
            this.chart1.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(82, 41);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(489, 372);
            this.listBox1.TabIndex = 7;
            this.listBox1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 555);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.faq_button);
            this.Controls.Add(this.Display_button);
            this.Controls.Add(this.Decrease_money_button);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Add_money_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор расходов";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add_money_button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Decrease_money_button;
        private System.Windows.Forms.Button Display_button;
        private System.Windows.Forms.Button faq_button;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

