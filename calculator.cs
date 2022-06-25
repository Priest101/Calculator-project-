using System;
using System.Text;



namespace calculatorFX
{
    public partial class calculator : Form
    {

        Double results = 0;
        String Operation = "";
        bool enter_value = false;
        float num1, num2;

        public calculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            double pi = Math.PI;
            textBox1.Text = pi.ToString();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);

           
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);

            if (num1 > 0 || num1<0)
            {

                double exp = Math.Exp(num1);
                textBox1.Text = exp.ToString();

            }

        }

            

        private void Log_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);

            if (num1 > 0 || num1 < 0) {

                

                double lg = Math.Log10(num1);

                textBox1.Text = lg.ToString();

            }

            


        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (enter_value))

                textBox1.Text = "";
            enter_value = false;

            Button num = (Button)sender;
            if (num.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                    textBox1.Text = textBox1.Text + num.Text;


            }
            else
                    textBox1.Text = textBox1.Text + num.Text;
            



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void calculator_Load(object sender, EventArgs e)
        {
        }

        private void btnsin_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);

            if (num1 > 0 || num1 < 0)
            {

                double sine = Math.Sin(num1);
                textBox1.Text = sine.ToString();

            }
        }

        private void btnln_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);

            if (num1 > 0 || num1 < 0)
            {

                double sine = Math.Log(num1);
                textBox1.Text = sine.ToString();

            }

        }

        private void btnsqr_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);

            if (num1 > 0 || num1 < 0)
            {

                double sqr = num1 * num1;
                textBox1.Text = sqr.ToString();

            }
        }

        private void btncosh_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);

            if (num1 > 0 || num1 < 0)
            {

                double cosh = Math.Cosh(num1);
                textBox1.Text = cosh.ToString();

            }
        }

        private void btncos_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);

            if (num1 > 0 || num1 < 0)
            {

                double cos = Math.Cos(num1);
                textBox1.Text = cos.ToString();

            }
        }

        private void btnpercentage_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);

            if (num1 > 0 || num1 < 0)
            {

                double perc = num1 / 100;
                textBox1.Text = perc.ToString();

            }
        }

        private void btncube_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);

            if (num1 > 0 || num1 < 0)
            {

                double cube = num1*num1*num1;
                textBox1.Text = cube.ToString();

            }
        }

        private void btnsinh_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);

            if (num1 > 0 || num1 < 0)
            {

                double sinh = Math.Sinh(num1);
                textBox1.Text = sinh.ToString();

            }
        }

        private void btntan_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);

            if (num1 > 0 || num1 < 0)
            {

                double tan = Math.Tan(num1);
                textBox1.Text = tan.ToString();

            }
        }

        private void btnfactorial_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            int i;
            int fact=1;

            

            for (i = 1; i <= num1; i++)
            {
                 fact =  fact * i;
            }


            if (num1 > 0)
            {

                
                textBox1.Text = fact.ToString();

            }
        }

        private void btninv_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);

            if (num1 > 0 || num1 < 0)
            {
                double inv = 1/num1;
                textBox1.Text = inv.ToString();
            }
        }

        private void btnsqrt_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);

            if (num1 > 0 || num1 < 0)
            {
                double sqrt = Math.Sqrt(num1);
                textBox1.Text = sqrt.ToString();
            }

        }
    }
}