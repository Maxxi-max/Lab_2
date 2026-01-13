namespace Lab6
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
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            textBox6 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 14);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(548, 447);
            dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(613, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(147, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(766, 18);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(147, 23);
            textBox2.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(613, 47);
            button1.Name = "button1";
            button1.Size = new Size(300, 25);
            button1.TabIndex = 6;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btn_insert_dt;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(613, 120);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(300, 23);
            textBox6.TabIndex = 7;
            // 
            // button2
            // 
            button2.Location = new Point(613, 149);
            button2.Name = "button2";
            button2.Size = new Size(300, 25);
            button2.TabIndex = 8;
            button2.Text = "Удалить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btn_delete_dt;
            // 
            // button3
            // 
            button3.Location = new Point(22, 467);
            button3.Name = "button3";
            button3.Size = new Size(548, 25);
            button3.TabIndex = 9;
            button3.Text = "Обновить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += load_database;
            // 
            // button4
            // 
            button4.Location = new Point(613, 246);
            button4.Name = "button4";
            button4.Size = new Size(300, 25);
            button4.TabIndex = 12;
            button4.Text = "Заменить";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btn_update_dt;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(766, 217);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(147, 23);
            textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(613, 217);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(147, 23);
            textBox4.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 513);
            Controls.Add(button4);
            Controls.Add(textBox3);
            Controls.Add(textBox4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox6);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += load_database;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private TextBox textBox6;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}
