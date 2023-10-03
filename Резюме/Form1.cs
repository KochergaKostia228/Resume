namespace Резюме
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text1 = "Мене звати Костя";
            string caption1 = "Моє ім'я";
            var Result1 = MessageBox.Show(text1, caption1, MessageBoxButtons.OK);
            if (Result1 == DialogResult.OK)
            {
                string text2 = "Мені 18 років";
                string caption2 = "Кількість років";
                var Result2 = MessageBox.Show(text2, caption2, MessageBoxButtons.OK);
                if (Result2 == DialogResult.OK)
                {
                    string text3 = "Я із України";
                    string caption3 = "Із якої країни";
                    var Result3 = MessageBox.Show(text3, caption3, MessageBoxButtons.OK);
                    if (Result3 == DialogResult.OK)
                    {
                        double a = (text1.Length + text2.Length + text3.Length) / 3;
                        string text4 = "Середня кількість символів -> " + a;
                        string caption4 = "Середня кількість символів";
                        MessageBox.Show(text4, caption4, MessageBoxButtons.OK); 
                    } 
                }
            }
        }
    }
}