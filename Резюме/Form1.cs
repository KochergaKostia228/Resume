namespace Резюме
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            bt_No.Top -= e.Y;
            bt_No.Left += e.X;
            if (bt_No.Top < -10 || bt_No.Top > 100)
            {
                bt_No.Top = 60;
            }
            if (bt_No.Left < -80 || bt_No.Left > 250)
            {
                bt_No.Left = 120;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ми й не сумнівались що ви так думаєте");
        }
    }
}