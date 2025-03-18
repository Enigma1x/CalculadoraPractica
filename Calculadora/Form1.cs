namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string CalTotal;
        double num1;
        double num2;
        string operation;
        double result;
        string displayText = "";
        int savednum = 0;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button29_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "1";
            displayText += "1";
            EnableButtons();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "2";
            displayText += "2";
            EnableButtons();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "3";
            displayText += "3";
            EnableButtons();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "4";
            displayText += "4";
            EnableButtons();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "5";
            displayText += "5";
            EnableButtons();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "6";
            displayText += "6";
            EnableButtons();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "7";
            displayText += "7";
            EnableButtons();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "8";
            displayText += "8";
            EnableButtons();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "9";
            displayText += "9";
            EnableButtons();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "0";
            displayText += "0";
            EnableButtons();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + ".";
            displayText += ".";
            EnableButtons();
        }

        private void button38_Click(object sender, EventArgs e)
        {
            // Verificar si displayText está vacío o nulo
            if (string.IsNullOrEmpty(displayText))
            {
                txtTotal.Text = "ERROR";
                DisableButtons();
                return;
            }
            // Botón de resultado
            num2 = double.Parse(displayText);
            if (operation == "+")
            {
                result = num1 + num2;
                txtTotal.Text = result.ToString();
            }
            else if (operation == "-")
            {
                result = num1 - num2;
                txtTotal.Text = result.ToString();
            }
            else if (operation == "*")
            {
                result = num1 * num2;
                txtTotal.Text = result.ToString();
            }
            else if (operation == "÷")
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    txtTotal.Text = result.ToString();
                }
                else
                {
                    txtTotal.Text = "ERROR";
                    DisableButtons();
                }
            }
            displayText = txtTotal.Text;
        }

        private void button37_Click(object sender, EventArgs e)
        {
            // Verificar si displayText está vacío o nulo
            if (string.IsNullOrEmpty(displayText))
            {
                txtTotal.Text = "ERROR";
                DisableButtons();
                return;
            }
            operation = "+";
            num1 = double.Parse(displayText);
            txtTotal.Text = txtTotal.Text + "+";
            displayText = "";
        }

        private void button34_Click(object sender, EventArgs e)
        {
            // Verificar si displayText está vacío o nulo
            if (string.IsNullOrEmpty(displayText))
            {
                txtTotal.Text = "ERROR";
                DisableButtons();
                return;
            }
            operation = "-";
            num1 = double.Parse(displayText);
            txtTotal.Text = txtTotal.Text + "-";
            displayText = "";
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(displayText))
            {
                txtTotal.Text = "ERROR";
                DisableButtons();
                return;
            }
            operation = "*";
            num1 = double.Parse(displayText);
            txtTotal.Text = txtTotal.Text + "x";
            displayText = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(displayText))
            {
                txtTotal.Text = "ERROR";
                DisableButtons();
                return;
            }
            operation = "÷";
            num1 = double.Parse(displayText);
            txtTotal.Text = txtTotal.Text + "÷";
            displayText = "";
        }

        private void button23_Click(object sender, EventArgs e)
        { // boton de borrar ultimo
            if (txtTotal.Text.Length > 0)
            {
                txtTotal.Text = txtTotal.Text.Substring(0, txtTotal.Text.Length - 1);
                displayText = displayText.Substring(0, displayText.Length - 1);
            }
        }

        private void button21_Click(object sender, EventArgs e)
        { // boton de limpiar
            txtTotal.Clear();
            displayText = "";
            num1 = 0;
            num2 = 0;
            operation = "";
            result = 0;
            EnableButtons();
        }

        private void button22_Click(object sender, EventArgs e)
        { // boton de limpiar todo
            if (num1 == 0)
            {
                txtTotal.Clear();
                displayText = "";
                num1 = 0;
                num2 = 0;
                operation = "";
                result = 0;
                EnableButtons();
            }
            else
            {
                displayText = "";
                txtTotal.Text = num1.ToString() + operation;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            //±
            if (!string.IsNullOrEmpty(displayText) && !displayText.StartsWith("-"))
            {
                displayText = "-" + displayText;
                txtTotal.Text = displayText;
            }
            else if (displayText.StartsWith("-"))
            {
                displayText = displayText.Substring(1);
                txtTotal.Text = displayText;
            }
            EnableButtons();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            // Boton raiz cuadrada
            if (string.IsNullOrEmpty(displayText))
            {
                txtTotal.Text = "ERROR";
                DisableButtons();
                return;
            }
            double number = double.Parse(displayText);
            if (number < 0)
            {
                txtTotal.Text = "ERROR";
                DisableButtons();
                return;
            }
            double sqrtResult = Math.Sqrt(number);
            txtTotal.Text = sqrtResult.ToString();
            displayText = sqrtResult.ToString();
        }

        private void DisableButtons()
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button && control.Name != "button21" && control.Name != "button22")
                {
                    control.Enabled = false;
                }
            }
        }

        private void EnableButtons()
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    control.Enabled = true;
                }
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            savednum = 0;
            displayText = "";
        }

        private void button26_Click(object sender, EventArgs e)
        {
            savednum = int.Parse(displayText);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            txtTotal.Text = savednum.ToString();
            displayText = savednum.ToString();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            savednum = savednum + int.Parse(displayText);
            displayText = savednum.ToString();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            savednum = savednum - int.Parse(displayText);
            displayText = savednum.ToString();
        }

        private void button39_Click(object sender, EventArgs e)
        {
            // Verificar si hay un número en displayText
            if (string.IsNullOrEmpty(displayText))
            {
                txtTotal.Text = "ERROR";
                DisableButtons();
                return;
            }

            // Convertir displayText a double
            double num = double.Parse(displayText);

            // Verificar que el número no sea cero
            if (num == 0)
            {
                txtTotal.Text = "ERROR";
                DisableButtons();
                return;
            }
            double inverso = 1 / num;
            txtTotal.Text = inverso.ToString();
            displayText = inverso.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(displayText))
            {
                txtTotal.Text = "ERROR";
                DisableButtons();
                return;
            }

            double valor = double.Parse(displayText);

            double porcentaje = (valor * num2) / 100; // Puedes cambiar el 20 por el porcentaje que desees

            // Mostrar el resultado en txtTotal
            txtTotal.Text = porcentaje.ToString();

            // Actualizar displayText con el resultado
            displayText = porcentaje.ToString();
        }
    }
}

