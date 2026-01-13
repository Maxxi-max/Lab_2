using Sem.Tolerance;
using System;
using System.Windows;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Runtime.InteropServices.Marshalling;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Drawing;
using System.Data.OleDb;
using System.Collections.Generic;

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

        string connectionstring = @$"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users\\pc\\source\\repos\\Lab_2\\Lab_2\\Sem\\RecTolerance.accdb;";
        private void LoadDataInf(object sender, EventArgs e) //Выбор
        {
            textBox1.Text = "1";
            listBox2.DataSource = null;
            listBoxVal.DataSource = null;
            listBoxVal.Items.Clear();
            listBox2.Items.Clear();

            SQLiteConnection con = new SQLiteConnection("Data Source=C:\\Users\\pc\\source\\repos\\Lab_2\\Lab_2\\Sem\\TolerancesFields.db;");
            con.Open();
            try
            {
                String[] columnRest = new string[4];
                columnRest[2] = "Вал_EI";
                DataTable schema = con.GetSchema("Columns", columnRest);
                foreach (DataRow row in schema.Rows)
                {
                    listBoxVal.Items.Add(row.Field<string>("COLUMN_NAME"));
                }
                listBoxVal.Items.Remove("ID");
                listBoxVal.Items.Remove("SizeToInclusive");
                listBoxVal.Items.Remove("SizeFrom");
                String[] columnRestOt = new string[4];
                columnRestOt[2] = "Отв_ES";
                DataTable schemaOt = con.GetSchema("Columns", columnRestOt);
                foreach (DataRow row in schemaOt.Rows)
                {
                    listBox2.Items.Add(row.Field<string>("COLUMN_NAME"));
                }
                listBox2.Items.Remove("ID");
                listBox2.Items.Remove("SizeToInclusive");
                listBox2.Items.Remove("SizeFrom");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void FilterTolerance(object sender, EventArgs e)
        {
            listBox2.DataSource = null;
            listBoxVal.DataSource = null;
            listBoxVal.Items.Clear();
            listBox2.Items.Clear();
            string action = "";
            action = ((Button)sender).Text;
            try
            {
                switch (action)
                {
                    case "С зазором":
                        {
                            List<string> list = new List<string>();
                            OleDbConnection con = new OleDbConnection(connectionstring);
                            string query = $"SELECT [Допуск Отверстия] FROM [Рекомендуемые посадки] WHERE [ID типа] = 1";
                            con.Open();
                            OleDbCommand cmd = new OleDbCommand(query, con);
                            var reader = cmd.ExecuteReader();
                            while (reader.Read())
                            {
                                list.Add(reader[0].ToString());
                            }
                            List<string> result = list.Distinct().ToList();
                            listBox2.DataSource = result;
                            List<string> list1 = new List<string>();
                            string query1 = $"SELECT [Допуск Вала] FROM [Рекомендуемые посадки] WHERE [ID типа] = 1";
                            OleDbCommand cmd1 = new OleDbCommand(query1, con);
                            var reader1 = cmd1.ExecuteReader();
                            while (reader1.Read())
                            {
                                list1.Add(reader1[0].ToString());
                            }
                            List<string> result1 = list1.Distinct().ToList();
                            listBoxVal.DataSource = result1;
                            con.Close();
                            break;
                        }
                    case "С натягом":
                        {
                            List<string> list = new List<string>();
                            OleDbConnection con = new OleDbConnection(connectionstring);
                            string query = $"SELECT [Допуск Отверстия] FROM [Рекомендуемые посадки] WHERE [ID типа] = 2";
                            con.Open();
                            OleDbCommand cmd = new OleDbCommand(query, con);
                            var reader = cmd.ExecuteReader();
                            while (reader.Read())
                            {
                                list.Add(reader[0].ToString());
                            }
                            List<string> result = list.Distinct().ToList();
                            listBox2.DataSource = result;
                            List<string> list1 = new List<string>();
                            string query1 = $"SELECT [Допуск Вала] FROM [Рекомендуемые посадки] WHERE [ID типа] = 2";
                            OleDbCommand cmd1 = new OleDbCommand(query1, con);
                            var reader1 = cmd1.ExecuteReader();
                            while (reader1.Read())
                            {
                                list1.Add(reader1[0].ToString());
                            }
                            List<string> result1 = list1.Distinct().ToList();
                            listBoxVal.DataSource = result1;
                            con.Close();
                            break;
                        }
                    case "Переходные":
                        {
                            List<string> list = new List<string>();
                            OleDbConnection con = new OleDbConnection(connectionstring);
                            string query = $"SELECT [Допуск Отверстия] FROM [Рекомендуемые посадки] WHERE [ID типа] = 3";
                            con.Open();
                            OleDbCommand cmd = new OleDbCommand(query, con);
                            var reader = cmd.ExecuteReader();
                            while (reader.Read())
                            {
                                list.Add(reader[0].ToString());
                            }
                            List<string> result = list.Distinct().ToList();
                            listBox2.DataSource = result;
                            List<string> list1 = new List<string>();
                            string query1 = $"SELECT [Допуск Вала] FROM [Рекомендуемые посадки] WHERE [ID типа] = 3";
                            OleDbCommand cmd1 = new OleDbCommand(query1, con);
                            var reader1 = cmd1.ExecuteReader();
                            while (reader1.Read())
                            {
                                list1.Add(reader1[0].ToString());
                            }
                            List<string> result1 = list1.Distinct().ToList();
                            listBoxVal.DataSource = result1;
                            con.Close();
                            break;
                        }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadDataNumb(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source=C:\\Users\\pc\\source\\repos\\Lab_2\\Lab_2\\Sem\\TolerancesFields.db;");
            con.Open();
            try
            {
                string val = listBoxVal.SelectedItem.ToString();
                SQLiteCommand cmd1 = new SQLiteCommand($"SELECT {val} FROM Вал_EI WHERE SizeFrom < {textBox1.Text} AND SizeToInclusive >= {textBox1.Text}", con);
                SQLiteCommand cmd2 = new SQLiteCommand($"SELECT {val} FROM Вал_ES WHERE SizeFrom < {textBox1.Text} AND SizeToInclusive >= {textBox1.Text}", con);

                var reader1 = cmd2.ExecuteReader();
                while (reader1.Read())
                {
                    textBox5.Text = reader1[0].ToString();
                }
                var reader2 = cmd1.ExecuteReader();
                while (reader2.Read())
                {
                    textBox4.Text = reader2[0].ToString();
                }
                string otv = listBox2.SelectedItem.ToString();
                SQLiteCommand cmd3 = new SQLiteCommand($"SELECT {otv} FROM Отв_EI WHERE SizeFrom < {textBox1.Text} AND SizeToInclusive >={textBox1.Text}", con);
                SQLiteCommand cmd4 = new SQLiteCommand($"SELECT {otv} FROM Отв_ES WHERE SizeFrom < {textBox1.Text} AND SizeToInclusive >={textBox1.Text}", con);

                var reader3 = cmd4.ExecuteReader();
                while (reader3.Read())
                {
                    textBox2.Text = reader3[0].ToString();
                }
                var reader4 = cmd3.ExecuteReader();
                while (reader4.Read())
                {
                    textBox3.Text = reader4[0].ToString();
                }
                textBox17.Text = listBoxVal.SelectedItem.ToString();
                textBox18.Text = listBox2.SelectedItem.ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        double s;
        double s1;
        private void btn_type_click(object sender, EventArgs e)
        {

            pictureBox1.Image = Image.FromFile("C:\\Users\\pc\\source\\repos\\Lab_2\\Lab_2\\Sem\\img\\empty.png");
            double a = Convert.ToDouble(textBox2.Text);
            double b = Convert.ToDouble(textBox3.Text);
            double c = Convert.ToDouble(textBox5.Text);
            double d = Convert.ToDouble(textBox4.Text);
            using (Graphics g = Graphics.FromImage(pictureBox1.Image))
            {
                if (a >= 0 && b>=0)
                {
                    s = b * 200 + 50;
                    s = 156 - s;
                }
                else if (a>=0 && b<0)
                {
                    s = Math.Abs(a) * 200-50;
                    s = 156 + s;
                }
                else
                {
                    s = Math.Abs(a) * 200;
                    s = 156 + s;
                }
                if (c >= 0 && d >= 0)
                {
                    s1 = d * 200 + 50;
                    s1 = 156 - s1;
                }
                else if (c >= 0 && d < 0)
                {
                    s = Math.Abs(c) * 200 - 50;
                    s = 156 + s;
                }
                else
                {
                    s1 = Math.Abs(c) * 200;
                    s1 = 156 + s1;
                }
                g.Clear(Color.White);
                Pen blackPen = new Pen(Color.Black, 3);
                Brush brb = new SolidBrush(Color.Black);
                Brush brw = new SolidBrush(Color.White);
                Font cl = new Font("Arial", 12);
                Font cla = new Font("Arial", 10);
                g.DrawLine(blackPen, 1, 156, 695, 156);
                float s2 = Convert.ToSingle(s);
                float s3 = Convert.ToSingle(s1);
                g.DrawRectangle(blackPen, 150, s2, 100, 50);
                g.DrawRectangle(blackPen, 300, s3, 100, 50);
                Rectangle rect1 = new Rectangle(152, Convert.ToInt32(s2+2), 97, 47);
                Rectangle rect2 = new Rectangle(302, Convert.ToInt32(s3+2), 97, 47);
                g.FillRectangle(brw, rect1);
                g.FillRectangle(brw, rect2);
                g.DrawString($"{textBox18.Text}", cl, brb, 190, s2 + 20);
                g.DrawString($"{textBox17.Text}", cl, brb, 340, s3 + 20);
                g.DrawString("0", cl, brb, 1, 158);
                g.DrawLine(blackPen, 20, 300, 20, 157);
                g.DrawLine(blackPen, 15, 170, 20, 157);
                g.DrawLine(blackPen, 25, 170, 20, 157);
                //
                g.DrawLine(blackPen, 140, 300, 140, s2);
                g.DrawLine(blackPen, 135, (s2+10), 140, s2);
                g.DrawLine(blackPen, 145, (s2+10), 140, s2);
                g.DrawLine(blackPen, 220, 300, 220, s2+50);
                g.DrawLine(blackPen, 140, s2, 150, s2);
                //
                g.DrawLine(blackPen, 215, (s2 + 60), 220, s2+50);
                g.DrawLine(blackPen, 225, (s2 + 60), 220, s2+50);
                g.DrawLine(blackPen, 330, 300, 330, s3 + 50);
                g.DrawLine(blackPen, 325, (s3 + 60), 330, s3+50);
                g.DrawLine(blackPen, 335, (s3 + 60), 330, s3+50);
                g.DrawLine(blackPen, 410, 300, 410, s3);
                g.DrawLine(blackPen, 405, (s3 + 10), 410, s3);
                g.DrawLine(blackPen, 415, (s3 + 10), 410, s3);
                g.DrawLine(blackPen, 410, s3, 400, s3);
                //
                g.DrawString($"Dn = {textBox1.Text}", cla, brb, 23, 200);
                g.DrawString($"Dmax = {textBox7.Text}", cla, brb, 50, 250);
                g.DrawString($"Dmin = {textBox6.Text}", cla, brb, 140, 280);
                g.DrawString($"dmax = {textBox9.Text}", cla, brb, 250, 250);
                g.DrawString($"dmin = {textBox8.Text}", cla, brb, 415, 280);
                switch (textBox12.Text)
                {
                    case "Посадка с зазором":
                        {
                            g.DrawLine(blackPen, 450, s3 + 50, 450, s2);
                            g.DrawLine(blackPen, 445, (s2 + 10), 450, s2);
                            g.DrawLine(blackPen, 455, (s2 + 10), 450, s2);
                            g.DrawLine(blackPen, 445, (s3 + 40), 450, s3 + 50);
                            g.DrawLine(blackPen, 455, (s3 + 40), 450, s3 + 50);
                            g.DrawLine(blackPen, 250, s2, 450, s2);
                            g.DrawLine(blackPen, 400, s3 + 50, 450, s3 + 50);
                            //
                            g.DrawLine(blackPen, 275, s3, 275, s2+50);
                            g.DrawLine(blackPen, 270, (s2 + 60), 275, s2+50);
                            g.DrawLine(blackPen, 280, (s2 + 60), 275, s2+50);
                            g.DrawLine(blackPen, 270, (s3 - 10), 275, s3);
                            g.DrawLine(blackPen, 280, (s3 - 10), 275, s3);
                            g.DrawLine(blackPen, 300, s3, 275, s3);
                            g.DrawLine(blackPen, 250, s2+50, 275, s2 + 50);
                            //
                            g.DrawString($"Smax = {textBox13.Text}", cla, brb, 280, (s3 + s2) / 2);
                            g.DrawString($"Smin = {textBox14.Text}", cla, brb, 455, (s3 + s2) / 2);
                            break;
                        }
                    case "Посадка с натягом":
                        {
                            g.DrawLine(blackPen, 450, s3 + 50, 450, s2);
                            g.DrawLine(blackPen, 445, (s2 - 10), 450, s2);
                            g.DrawLine(blackPen, 455, (s2 - 10), 450, s2);
                            g.DrawLine(blackPen, 445, (s3 + 60), 450, s3 + 50);
                            g.DrawLine(blackPen, 455, (s3 + 60), 450, s3 + 50);
                            g.DrawLine(blackPen, 250, s2, 450, s2);
                            g.DrawLine(blackPen, 400, s3 + 50, 450, s3 + 50);
                            //
                            g.DrawLine(blackPen, 275, s3, 275, s2 + 50);
                            g.DrawLine(blackPen, 270, (s2 + 40), 275, s2 + 50);
                            g.DrawLine(blackPen, 280, (s2 + 40), 275, s2 + 50);
                            g.DrawLine(blackPen, 270, (s3 + 10), 275, s3);
                            g.DrawLine(blackPen, 280, (s3 + 10), 275, s3);
                            g.DrawLine(blackPen, 300, s3, 275, s3);
                            g.DrawLine(blackPen, 250, s2 + 50, 275, s2 + 50);
                            g.DrawString($"Nmax = {textBox13.Text}", cla, brb, 230, (s3+s2)/2);
                            g.DrawString($"Nmin = {textBox14.Text}", cla, brb, 455, (s3 + s2) / 2);
                            break;
                        }
                    case "Переходная посадка":
                        {
                            g.DrawLine(blackPen, 450, s3 + 50, 450, s2);
                            g.DrawLine(blackPen, 445, (s2 + 10), 450, s2);
                            g.DrawLine(blackPen, 455, (s2 + 10), 450, s2);
                            g.DrawLine(blackPen, 445, (s3 + 40), 450, s3 + 50);
                            g.DrawLine(blackPen, 455, (s3 + 40), 450, s3 + 50);
                            g.DrawLine(blackPen, 250, s2, 450, s2);
                            g.DrawLine(blackPen, 400, s3 + 50, 450, s3 + 50);
                            //
                            g.DrawLine(blackPen, 275, s3, 275, s2 + 50);
                            g.DrawLine(blackPen, 270, (s2 + 40), 275, s2 + 50);
                            g.DrawLine(blackPen, 280, (s2 + 40), 275, s2 + 50);
                            g.DrawLine(blackPen, 270, (s3 + 10), 275, s3);
                            g.DrawLine(blackPen, 280, (s3 + 10), 275, s3);
                            g.DrawLine(blackPen, 300, s3, 275, s3);
                            g.DrawLine(blackPen, 250, s2 + 50, 275, s2 + 50);
                            g.DrawString($"Smax = {textBox13.Text}", cla, brb, 280, s2-20);
                            g.DrawString($"Nmax = {textBox14.Text}", cla, brb, 455, s2-10);
                            break;
                        }
                }
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
                textBox15.Text = "-";
                textBox16.Text = "-";
            }
            else if (con.GetInfo() == "Посадка с натягом")
            {
                label12.Text = "Nmax";
                label13.Text = "Nmin";
                textBox15.Text = "-";
                textBox16.Text = "-";
            }
            else if (con.GetInfo() == "Переходная посадка")
            {
                label12.Text = "Smax";
                label13.Text = "Nmax";
                textBox15.Text = con.ProbabilityNmax().ToString();
                textBox16.Text = con.ProbabilitySmax().ToString();
            }
        }

       
    }
}
