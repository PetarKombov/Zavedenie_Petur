namespace Zavedenie_Form
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
            textBox1 = new TextBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(127, 61);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(205, 23);
            textBox1.TabIndex = 15;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Пушачи ", "Непушачи" });
            comboBox2.Location = new Point(127, 123);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(150, 23);
            comboBox2.TabIndex = 14;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Кеш", "Карта" });
            comboBox1.Location = new Point(127, 195);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(134, 23);
            comboBox1.TabIndex = 13;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(14, 307);
            button1.Name = "button1";
            button1.Size = new Size(156, 23);
            button1.TabIndex = 12;
            button1.Text = "Към Менюто";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 203);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 11;
            label4.Text = "Как ще плащате";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 131);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 10;
            label3.Text = "Каква маса";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 61);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 9;
            label2.Text = "Колко души";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(127, 9);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 8;
            label1.Text = "Заведение";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 456);
            Controls.Add(textBox1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Button button1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}