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
    }
}
