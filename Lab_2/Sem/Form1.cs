using Sem.Tolerance;
using System;
using System.Windows;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Runtime.InteropServices.Marshalling;

namespace Sem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string a = "";
        private string b = "";
        
       

        private void btn_type_click(object sender, EventArgs e)
        {
            a = ((Button)sender).Text;
            switch (a)
            {
                case "С зазором":
                    pictureBox1.Image = Image.FromFile("C:\\Users\\Слушатель\\Desktop\\Lab_2 Puzanov\\Lab_2\\Sem\\img\\zazor.png");
                    break;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (Graphics g = Graphics.FromImage(pictureBox1.Image))
            {
                Pen blackPen = new Pen(Color.Black, 3);
                // Рисование текста на изображении
                g.DrawLine(blackPen, 1, 258, 635, 258);
            }
            pictureBox1.Refresh();
        }

        private void btn_calculation(object sender, EventArgs e)
        {
            Tolerance.Size otv = new Tolerance.Size("отверстие", Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text)); // Задача данных отверстия
            Tolerance.Size val = new Tolerance.Size("вал", Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox5.Text), Convert.ToDouble(textBox4.Text)); // Задача данных вала
            Connection con = new Connection(otv, val);
            textBox6.Text = otv.Dmin().ToString();
            textBox7.Text = otv.Dmax().ToString();
            textBox8.Text = val.Dmin().ToString();
            textBox9.Text = val.Dmax().ToString();
            textBox10.Text = otv.TD().ToString();
            textBox11.Text = val.TD().ToString();
            textBox12.Text = con.GetInfo();
            textBox13.Text = con.SNmax().ToString();
            textBox14.Text = con.SNmin().ToString();
            if (con.GetInfo() == "Посадка с зазором")
            {
                label12.Text = "Smax";
                label13.Text = "Smin";
            }
            else if (con.GetInfo() == "Посадка с натягом")
            {
                label12.Text = "Nmax";
                label13.Text = "Nmin";
            }
            else if (con.GetInfo() == "Переходная посадка")
            {
                label12.Text = "Smax";
                label13.Text = "Nmax";
            }
        }
    }
}
