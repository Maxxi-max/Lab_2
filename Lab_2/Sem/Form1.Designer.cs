namespace Sem
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            pictureBox1 = new PictureBox();
            button7 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(103, 64);
            button1.TabIndex = 0;
            button1.Text = "С зазором";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btn_type_click;
            // 
            // button2
            // 
            button2.Location = new Point(124, 12);
            button2.Name = "button2";
            button2.Size = new Size(103, 64);
            button2.TabIndex = 1;
            button2.Text = "С натягом";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btn_type_click;
            // 
            // button3
            // 
            button3.Location = new Point(236, 12);
            button3.Name = "button3";
            button3.Size = new Size(103, 64);
            button3.TabIndex = 2;
            button3.Text = "Переходная 1";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btn_type_click;
            // 
            // button4
            // 
            button4.Location = new Point(572, 12);
            button4.Name = "button4";
            button4.Size = new Size(103, 64);
            button4.TabIndex = 5;
            button4.Text = "Переходная 4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btn_type_click;
            // 
            // button5
            // 
            button5.Location = new Point(460, 12);
            button5.Name = "button5";
            button5.Size = new Size(103, 64);
            button5.TabIndex = 4;
            button5.Text = "Переходная 3";
            button5.UseVisualStyleBackColor = true;
            button5.Click += btn_type_click;
            // 
            // button6
            // 
            button6.Location = new Point(348, 12);
            button6.Name = "button6";
            button6.Size = new Size(103, 64);
            button6.TabIndex = 3;
            button6.Text = "Переходная 2";
            button6.UseVisualStyleBackColor = true;
            button6.Click += btn_type_click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(22, 125);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(653, 311);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // button7
            // 
            button7.Location = new Point(12, 82);
            button7.Name = "button7";
            button7.Size = new Size(103, 37);
            button7.TabIndex = 7;
            button7.Text = "ES+ EI+";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(701, 458);
            Controls.Add(button7);
            Controls.Add(pictureBox1);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private PictureBox pictureBox1;
        private Button button7;
    }
}
