namespace CalculatoR
{
    public partial class Form1 : Form
    {
        public string? Dest;
        public string? Digit;
        public bool New_Digit;
        public Form1()
        {
            New_Digit = false;
            InitializeComponent();
        }

        private void button46_Click(object sender, EventArgs e)
        {
            if (New_Digit)
            {
                New_Digit = false;
                textBox25.Text = "0";
            }
            Button but = (Button)sender;
            if (textBox25.Text == "0")
                textBox25.Text = but.Text;
            else
                textBox25.Text = textBox25.Text + but.Text;

        }

        private void button31_Click(object sender, EventArgs e)
        {
            textBox25.Text = "0";
        }

        private void button36_Click(object sender, EventArgs e)
        {
            Button but = (Button)sender;
            Dest = but.Text;
            Digit = textBox25.Text;
            New_Digit = true;
        }

        private void button40_Click(object sender, EventArgs e)
        {
            double digit1, digit2;
            double result = 0;
            digit1 = Convert.ToDouble(Digit);
            digit2 = Convert.ToDouble(textBox25.Text);

            if (Dest == "+") result = digit1 + digit2;
            if (Dest == "-") result = digit1 - digit2;
            if (Dest == "*") result = digit1 * digit2;
            if (Dest == "/") result = digit1 / digit2;
            if (Dest == "%") result = digit1 * digit2 / 100;
            Dest = "=";
            New_Digit = true;
            textBox25.Text = result.ToString();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            double digit = Convert.ToDouble(textBox25.Text);
            double result = Math.Sqrt(digit);
            textBox25.Text = result.ToString();

        }

        private void button26_Click(object sender, EventArgs e)
        {
            double digit = Convert.ToDouble(textBox25.Text);
            double result = digit * digit;
            textBox25.Text = result.ToString();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            double digit = Convert.ToDouble(textBox25.Text);
            double result = 1 / digit;
            textBox25.Text = result.ToString();
        }

        private void button42_Click(object sender, EventArgs e)
        {
            double digit = Convert.ToDouble(textBox25.Text);
            double result = -digit;
            textBox25.Text = result.ToString();
        }

        private void button41_Click(object sender, EventArgs e)
        {
            if (!textBox25.Text.Contains(",")) textBox25.Text = textBox25.Text + ",";
        }

        private void button29_Click(object sender, EventArgs e)
        {
            textBox25.Text = textBox25.Text.Substring(0, textBox25.Text.Length - 1);
            if (textBox25.Text == "") textBox25.Text = "0";
        }
    }
}
