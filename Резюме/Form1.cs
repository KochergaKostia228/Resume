namespace Резюме
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_StartGame_Click(object sender, EventArgs e)
        {
            int begin = 0;
            int end = 10;
            int result = 5;
            while (begin != result && end != result)
            {
                string text = "Ваше число більше " + result + "?Якщо це саме те шукане число натисныть (Cancel)";
                var resultDialog = MessageBox.Show(text, "Гра почалась", MessageBoxButtons.YesNoCancel);

                if (resultDialog == DialogResult.Yes)
                {
                    begin = result;
                    result += begin / 2;
                }
                else if (resultDialog == DialogResult.No)
                {
                    end = result - 1;
                    result = end / 2;
                }
                else
                {
                    break;
                }
            }

            var resultDialog1 = MessageBox.Show("Ваше задане число --> " + result + ".Хочете зіграти ще раз?", "Результат", MessageBoxButtons.YesNo);
            if (resultDialog1 == DialogResult.Yes)
            {
                bt_StartGame_Click(sender, e);
            }
        }
    }
}