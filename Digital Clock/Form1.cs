namespace Digital_Clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timeDisplayLabel.Text = DateTime.Now.ToString("hh:mm:ss");
            dateDisplayLabel.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy");
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            Timer.Start();
            redButton.FlatStyle = FlatStyle.Flat;
            greenButton.FlatStyle = FlatStyle.Flat;
            purpleButton.FlatStyle = FlatStyle.Flat;
            yellowButton.FlatStyle = FlatStyle.Flat;
            whiteButton.FlatStyle = FlatStyle.Flat;
            cyanButton.FlatStyle = FlatStyle.Flat;
            blueButton.FlatStyle = FlatStyle.Flat;
            silverButton.FlatStyle = FlatStyle.Flat;
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            timeDisplayLabel.ForeColor = Color.Red;
            dateDisplayLabel.ForeColor = Color.Red;
        }

        private void greenButton_Click(object sender, EventArgs e)
        {
            timeDisplayLabel.ForeColor = Color.Lime;
            dateDisplayLabel.ForeColor = Color.Lime;
        }

        private void purpleButton_Click(object sender, EventArgs e)
        {
            timeDisplayLabel.ForeColor = Color.Fuchsia;
            dateDisplayLabel.ForeColor = Color.Fuchsia;
        }

        private void yellowButton_Click(object sender, EventArgs e)
        {
            timeDisplayLabel.ForeColor = Color.Yellow;
            dateDisplayLabel.ForeColor = Color.Yellow;
        }

        private void whiteButton_Click(object sender, EventArgs e)
        {
            timeDisplayLabel.ForeColor = Color.White;
            dateDisplayLabel.ForeColor = Color.White;
        }

        private void style1_Click(object sender, EventArgs e)
        {
            timeDisplayLabel.Font = new Font("Segoe UI", 70, FontStyle.Regular);
            dateDisplayLabel.Font = new Font("Segoe UI", 30, FontStyle.Regular);
        }

        private void style2_Click(object sender, EventArgs e)
        {
            timeDisplayLabel.Font = new Font("Kristen ITC", 70, FontStyle.Regular);
            dateDisplayLabel.Font = new Font("Kristen ITC", 30, FontStyle.Regular);
        }

        private void style3_Click(object sender, EventArgs e)
        {
            timeDisplayLabel.Font = new Font("Cascadia Mono", 70, FontStyle.Regular);
            dateDisplayLabel.Font = new Font("Cascadia Mono", 25, FontStyle.Regular);
        }

        private void style4_Click(object sender, EventArgs e)
        {
            timeDisplayLabel.Font = new Font("Ink Free", 70, FontStyle.Regular);
            dateDisplayLabel.Font = new Font("Ink Free", 30, FontStyle.Regular);
        }

        private void cyanButton_Click(object sender, EventArgs e)
        {
            timeDisplayLabel.ForeColor = Color.Cyan;
            dateDisplayLabel.ForeColor = Color.Cyan;
        }

        private void silverButton_Click(object sender, EventArgs e)
        {
            timeDisplayLabel.ForeColor = Color.Silver;
            dateDisplayLabel.ForeColor = Color.Silver;
        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            timeDisplayLabel.ForeColor = Color.Blue;
            dateDisplayLabel.ForeColor = Color.Blue;
        }
    }
}