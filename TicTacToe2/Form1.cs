namespace TicTacToe2
{
    public partial class Form1 : Form
    {
        char activePlayer = 'O';
        public Form1()
        {
            InitializeComponent();
        }

        void SwitchPlayer()
        {
            activePlayer = (activePlayer == 'O') ? 'X' : 'O';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Text != " ")
            {
                return;
            }

            button.Text = activePlayer.ToString();
            CheckResult();
            SwitchPlayer();
            activePlaterLabel.Text = "Aktywny Gracz: " + activePlayer.ToString();
        }

        void CheckResult()
        {
            if (TopLeft.Text != " " &&
                TopCenter.Text != " " &&
                TopRight.Text != " ")
            {
                if (TopLeft.Text == TopCenter.Text && TopCenter.Text == TopRight.Text)
                {
                    MessageBox.Show("Wygra³ gracz: " + TopLeft.Text);
                }
            }

            if (CenterLeft.Text != " " &&
                CenterCenter.Text != " " &&
                CenterRight.Text != " ")
            {
                if (CenterLeft.Text == CenterCenter.Text && CenterCenter.Text == CenterRight.Text)
                {
                    MessageBox.Show("Wygra³ gracz: " + TopLeft.Text);
                }
            }

            if (BottomLeft.Text != " " &&
                BottomCenter.Text != " " &&
                BottomRight.Text != " ")
            {
                if (BottomLeft.Text == BottomCenter.Text && BottomCenter.Text == BottomRight.Text)
                {
                    MessageBox.Show("Wygra³ gracz: " + TopLeft.Text);
                }
            }
        }
    }
}
