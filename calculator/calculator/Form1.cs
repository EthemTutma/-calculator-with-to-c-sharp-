namespace calculator
{
    public partial class Form1 : Form
    {
        bool optdurum = false;
        double sonuc;
        string opt;
        public Form1()
        {
            
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rakamolay(object sender, EventArgs e)
        {
            if (txtsonuc.Text == "0" || optdurum)
            {
                txtsonuc.Clear();
            }
            optdurum = false;
            Button btn = (Button)sender;
            txtsonuc.Text += btn.Text;



        }

        private void optolay(object sender, EventArgs e)
        {
            optdurum = true;
            Button btn = (Button)sender;
            string yeniopt = btn.Text;
            lbsonuc.Text = lbsonuc.Text + " " + txtsonuc.Text + " " + yeniopt;

            
            switch(opt)
            {
                case "+":txtsonuc.Text = (sonuc + Double.Parse(txtsonuc.Text)).ToString();break;
                case "-":txtsonuc.Text = (sonuc - Double.Parse(txtsonuc.Text)).ToString();break;
                case "*":txtsonuc.Text = (sonuc * Double.Parse(txtsonuc.Text)).ToString();break;
                case "/":txtsonuc.Text = (sonuc / Double.Parse(txtsonuc.Text)).ToString();break;

            }
            sonuc = Double.Parse(txtsonuc.Text);
            txtsonuc.Text = sonuc.ToString();
            opt = yeniopt;
            
        }

        private void txtsonuc_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (opt=="+")
            {
                lbsonuc.Text += " 0";
            }
            if (opt == "-")
            {
                lbsonuc.Text += " 0";
            }
            if (opt == "*")
            {
                lbsonuc.Text += " 1";
            }
            if (opt == "/")
            {
                lbsonuc.Text += " 1";
            }
            lbsonuc.Text += " = " + txtsonuc.Text;
            txtsonuc.Text = "0";


        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtsonuc.Text = "0";
            lbsonuc.Text = "";
            opt = "";
            sonuc = 0;
            optdurum = false;

        }

        private void button16_Click(object sender, EventArgs e)
        {
            lbsonuc.Text = "";
            optdurum = true;
            switch (opt)
            {
                case "+": txtsonuc.Text = (sonuc + Double.Parse(txtsonuc.Text)).ToString(); break;
                case "-": txtsonuc.Text = (sonuc - Double.Parse(txtsonuc.Text)).ToString(); break;
                case "*": txtsonuc.Text = (sonuc * Double.Parse(txtsonuc.Text)).ToString(); break;
                case "/": txtsonuc.Text = (sonuc / Double.Parse(txtsonuc.Text)).ToString(); break;

            }
            
            sonuc = Double.Parse(txtsonuc.Text);
            txtsonuc.Text = sonuc.ToString();
            opt = "";

        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (txtsonuc.Text == "0")
            {
                txtsonuc.Text = "0";

            }
            else if (optdurum)
            {
                txtsonuc.Text = "0";

            }
            if (!txtsonuc.Text.Contains(","))

            {
                txtsonuc.Text += ",";
            }
            optdurum = false;
        }
    }
}