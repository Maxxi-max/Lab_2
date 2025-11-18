namespace Converter
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
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(25, 47);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(294, 349);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(340, 47);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(337, 349);
            listBox2.TabIndex = 1;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Location = new Point(701, 47);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(310, 349);
            listBox3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(25, 24);
            label1.Name = "label1";
            label1.Size = new Size(162, 20);
            label1.TabIndex = 3;
            label1.Text = "Физическая величина";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(340, 24);
            label2.Name = "label2";
            label2.Size = new Size(228, 20);
            label2.TabIndex = 4;
            label2.Text = "Исходные единицы измерения";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(701, 24);
            label3.Name = "label3";
            label3.Size = new Size(237, 20);
            label3.TabIndex = 5;
            label3.Text = "Требуемые единицы измерения";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(340, 411);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(337, 23);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(701, 411);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(310, 23);
            textBox2.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(184, 414);
            label4.Name = "label4";
            label4.Size = new Size(135, 20);
            label4.TabIndex = 8;
            label4.Text = "Введите значение";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13F);
            button1.Location = new Point(497, 446);
            button1.Name = "button1";
            button1.Size = new Size(334, 42);
            button1.TabIndex = 9;
            button1.Text = "Перевести";
            button1.UseVisualStyleBackColor = true;
            button1.Click += BtnConvert_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1063, 516);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            Load += ConverterFormLoad;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private ListBox listBox2;
        private ListBox listBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private Button button1;
    }
}
