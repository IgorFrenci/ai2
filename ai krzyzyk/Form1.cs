namespace ai_krzyzyk
{
    public partial class Form1 : Form
    {
        char player = 'X';

        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Text = player.ToString();
            if (player == 'X')
            {
                player = 'O';
                label1.Text = "Ruch gracza: O";
            }
            else
            {
                player = 'X';
                label1.Text = "Ruch gracza: X";
            }
                button.Enabled = false;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
