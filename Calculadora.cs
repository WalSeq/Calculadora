namespace CalculadoraWalSeq
{
    public partial class Calculadora : Form
    {
        double primero;
        double segundo;
        string operador;
        public Calculadora()
        {
            InitializeComponent();
        }

        Clases.ClsSumar obj = new Clases.ClsSumar();
        Clases.ClsRestar obj2 = new Clases.ClsRestar();
        Clases.ClsMultiplicar obj3 = new Clases.ClsMultiplicar();
        Clases.ClsDividir obj4 = new Clases.ClsDividir();

        private void button16_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(tbxScreen.Text);

            double Sum;
            double Res;
            double Mul;
            double Div;

            switch (operador)
            {
                case "+":
                    Sum = obj.Sumar((primero), (segundo));
                    tbxScreen.Text = Sum.ToString();
                    break;
                case "-":
                    Res = obj2.Restar((primero), (segundo));
                    tbxScreen.Text = Res.ToString();
                    break;
                case "*":
                    Mul = obj3.Multiplicar((primero), (segundo));
                    tbxScreen.Text = Mul.ToString();
                    break;
                case "/":
                    Div = obj4.Dividir((primero), (segundo));
                    tbxScreen.Text = Div.ToString();
                    break;
            }

        }

        private bool screen0()
        {
            return tbxScreen.Text == "0";
        }

        private void btnN0_Click(object sender, EventArgs e)
        {
            if (screen0())
                return;
            tbxScreen.Text = tbxScreen.Text + "0";
        }

        private void btnN1_Click(object sender, EventArgs e)
        {
            if (screen0())
            {
                tbxScreen.Text = "1";
                return;
            }
            tbxScreen.Text = tbxScreen.Text + "1";
        }

        private void btnN2_Click(object sender, EventArgs e)
        {
            if (screen0())
            {
                tbxScreen.Text = "2";
                return;
            }
            tbxScreen.Text = tbxScreen.Text + "2";
        }

        private void btnN3_Click(object sender, EventArgs e)
        {
            if (screen0())
            {
                tbxScreen.Text = "3";
                return;
            }
            tbxScreen.Text = tbxScreen.Text + "3";
        }

        private void btnN4_Click(object sender, EventArgs e)
        {
            if (screen0())
            {
                tbxScreen.Text = "4";
                return;
            }
            tbxScreen.Text = tbxScreen.Text + "4";
        }

        private void btnN5_Click(object sender, EventArgs e)
        {
            if (screen0())
            {
                tbxScreen.Text = "5";
                return;
            }
            tbxScreen.Text = tbxScreen.Text + "5";
        }

        private void btnN6_Click(object sender, EventArgs e)
        {
            if (screen0())
            {
                tbxScreen.Text = "6";
                return;
            }
            tbxScreen.Text = tbxScreen.Text + "6";
        }

        private void btnN7_Click(object sender, EventArgs e)
        {
            if (screen0())
            {
                tbxScreen.Text = "7";
                return;
            }
            tbxScreen.Text = tbxScreen.Text + "7";
        }

        private void btnN8_Click(object sender, EventArgs e)
        {
            if (screen0())
            {
                tbxScreen.Text = "8";
                return;
            }
            tbxScreen.Text = tbxScreen.Text + "8";
        }

        private void btnN9_Click(object sender, EventArgs e)
        {
            if (screen0())
            {
                tbxScreen.Text = "9";
                return;
            }
            tbxScreen.Text = tbxScreen.Text + "9";
        }

        private void btnNPunto_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + ",";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNSumar_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void btnNRestar_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void btnNMultiplicar_Click(object sender, EventArgs e)
        {
            operador = "*";
            primero = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void btnNDividir_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void btnNLimpiar_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = "0";
        }

        private void btnNBorrar_Click(object sender, EventArgs e)
        {
            if (tbxScreen.Text.Length == 1)
                tbxScreen.Text = "";
            else
                tbxScreen.Text = tbxScreen.Text.Substring(0, tbxScreen.Text.Length - 1);
        }
    }
}
