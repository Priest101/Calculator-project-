using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaryCalculatorNew
{
    public partial class Form1 : Form
    {
        double num;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public static double Evaluate(string expression)
        {
            DataTable table = new DataTable();
            table.Columns.Add("expression", typeof(string), expression);
            DataRow row = table.NewRow();
            table.Rows.Add(row);
            return double.Parse((string)row["expression"]);
        }

        string Expression = "";

        public double lastAns { get; private set; }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblExpression.Text = Expression = "";
            lblAns.Text = "0";
        }

        string GetRandomNums(decimal Ans)
        {
            this.lastAns = (double)Ans;
            string tmp = "";
            Random ran = new Random();
            for (int i = 0; i < Ans.ToString().Length; i++)
            {
                tmp += ran.Next();
            }
            return tmp;
        }

        int i = 0;

        private void timeAnimate_Tick(object sender, EventArgs e)
        {
            if (i < 5)
            {
                lblAns.Text = GetRandomNums((decimal)this.lastAns);
                i++;
            }
            else
            {
                i = 0;
                lblAns.Text = lastAns.ToString();
                timeAnimate.Stop();
            }
        }

        private void btnNums_Click(object sender, EventArgs e)
        {
            lblExpression.Text = "";
            lblAns.Text = 0.ToString();
            lblExpression.Text = (Expression += ((Control)sender).Tag.ToString());
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                lblExpression.Text = Expression = Expression.Substring(0, Expression.Length - 1);
            }
            catch (Exception)
            {

            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            lastAns = Evaluate(Expression);
            timeAnimate.Start();
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            num = float.Parse(lblExpression.Text);
            if (num > 0 || num < 0)
            {
                double sine = Math.Sin(num);
                lblAns.Text = sine.ToString();
            }
            else
            {
                lblAns.Text = "Invalid input";
            }

        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            num = float.Parse(lblExpression.Text);
            if (num > 0 || num < 0)
            {
                double tangent = Math.Tan(num);
                lblAns.Text = tangent.ToString();
            }
            else
            {
                lblAns.Text = "Invalid input";
            }
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            num = float.Parse(lblExpression.Text);
            if (num > 0 || num < 0)
            {
                double cosine = Math.Cos(num);
                lblAns.Text = cosine.ToString();
            }
            else
            {
                lblAns.Text = "Invalid input";
            }
        }

        private void btnInv_Click(object sender, EventArgs e)
        {
            num = float.Parse(lblExpression.Text);
            if (num > 0 || num < 0)
            {
                double inv = 1/num;
                lblAns.Text = inv.ToString();
            }
            else
            {
                lblAns.Text = "Invalid input";
            }
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            num = float.Parse(lblExpression.Text);
            if (num > 0 || num < 0)
            {
                double log = Math.Log10(num);
                lblAns.Text = log.ToString();
            }
            else
            {
                lblAns.Text = "Invalid input";
            }
        }

        private void btnRoot_Click(object sender, EventArgs e)
        {
            num = float.Parse(lblExpression.Text);
            if (num > 0 || num < 0)
            {
                double sqrt = Math.Sqrt(num);
                lblAns.Text = sqrt.ToString();
            }
            else
            {
                lblAns.Text = "Invalid input";
            }
        }

        private void btnAns_Click(object sender, EventArgs e)
        {
            double ans = float.Parse(lblAns.Text);
            lblExpression.Text = Expression = "";
            lblExpression.Text = (Expression += ans.ToString());
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            num = float.Parse(lblExpression.Text);
            if (num > 0 || num < 0)
            {
                double sqrt = num*num;
                lblAns.Text = sqrt.ToString();
            }
            else
            {
                lblAns.Text = "Invalid input";
            }
        }

        private void btnCosh_Click(object sender, EventArgs e)
        {
            num = float.Parse(lblExpression.Text);
            if (num > 0 || num < 0)
            {
                double cosh = Math.Cosh(num);
                lblAns.Text = cosh.ToString();
            }
            else
            {
                lblAns.Text = "Invalid input";
            }
        }

        private void btnSinh_Click(object sender, EventArgs e)
        {
            num = float.Parse(lblExpression.Text);
            if (num > 0 || num < 0)
            {
                double sineh = Math.Sinh(num);
                lblAns.Text = sineh.ToString();
            }
            else
            {
                lblAns.Text = "Invalid input";
            }
        }

        private void btnTanh_Click(object sender, EventArgs e)
        {
            num = float.Parse(lblExpression.Text);
            if (num > 0 || num < 0)
            {
                double tanh = Math.Tanh(num);
                lblAns.Text = tanh.ToString();
            }
            else
            {
                lblAns.Text = "Invalid input";
            }
        }

        private void btnCube_Click(object sender, EventArgs e)
        {
            num = float.Parse(lblExpression.Text);
            if (num > 0 || num < 0)
            {
                double sqrt = num*num*num;
                lblAns.Text = sqrt.ToString();
            }
            else
            {
                lblAns.Text = "Invalid input";
            }
        }
    }
}
