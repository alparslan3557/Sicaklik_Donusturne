﻿namespace Sicaklik_Degistirme
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 30);
            label1.Name = "label1";
            label1.Size = new Size(128, 15);
            label1.TabIndex = 0;
            label1.Text = "Fahrenheit Değeri Girin";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(40, 56);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(326, 30);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 2;
            label2.Text = "Santigrat Karşılığı";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(324, 57);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(182, 57);
            button1.Name = "button1";
            button1.Size = new Size(106, 23);
            button1.TabIndex = 4;
            button1.Text = "Dönüştür";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 123);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 5;
            label3.Text = "Santigrat girin";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(324, 129);
            label4.Name = "label4";
            label4.Size = new Size(107, 15);
            label4.TabIndex = 6;
            label4.Text = "Fahrenheit Karşılığı";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(40, 157);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(324, 157);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 8;
            // 
            // button2
            // 
            button2.Location = new Point(182, 157);
            button2.Name = "button2";
            button2.Size = new Size(106, 23);
            button2.TabIndex = 9;
            button2.Text = "Dönüştür";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Button button1;
        private Label label3;
        private Label label4;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button2;
    }
}
