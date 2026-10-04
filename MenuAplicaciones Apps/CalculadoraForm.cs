using System;
using System.Globalization;
using System.Windows.Forms;

namespace Calculadora.WForms
{
    public partial class CalculadoraForm : Form
    {
        private double primerNumero;        

        private string operacion = string.Empty;

        private bool nuevaOperacion;

        
        private bool TryGetDisplayedNumber(out double value)
        {
            string text = txtResultado?.Text?.Trim() ?? string.Empty;
            return double.TryParse(text, NumberStyles.Number, CultureInfo.CurrentCulture, out value);
        }



        public CalculadoraForm() => InitializeComponent();

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {
            
        }

        ////////////////////////////////////////////////////////////////////
        //BOTONES
        ///////////////////////////////////////////////////////////////////
        private void Numeros_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;

            if (nuevaOperacion)
            {
                if (txtResultado != null)
                    txtResultado.Text = string.Empty;
                nuevaOperacion = false;
            }

            string current = txtResultado?.Text ?? string.Empty;

            if (boton.Text == "." && current.Contains("."))
            {
                return;
            }

            if (txtResultado != null)
                txtResultado.Text = current + boton.Text;
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            if (!TryGetDisplayedNumber(out primerNumero))
            {
                MessageBox.Show("Valor inválido.");
                return;
            }

            operacion = "+";
            nuevaOperacion = true;
        }
 
        private void btnResta_Click(object sender, EventArgs e)
        {
            if (!TryGetDisplayedNumber(out primerNumero))
            {
                MessageBox.Show("Valor inválido.");
                return;
            }

            operacion = "-";
            nuevaOperacion = true;
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            if (!TryGetDisplayedNumber(out primerNumero))
            {
                MessageBox.Show("Valor inválido.");
                return;
            }

            operacion = "*";
            nuevaOperacion = true;
        }

        private void BtnDivision_Click(object sender, EventArgs e)
        {
            if (!TryGetDisplayedNumber(out primerNumero))
            {
                MessageBox.Show("Valor inválido.");
                return;
            }

            operacion = "/";
            nuevaOperacion = true;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (!TryGetDisplayedNumber(out double segundoNumero))
            {
                MessageBox.Show("Valor inválido.");
                return;
            }

            double resultado = 0;

            switch (operacion)
            {
                case "+":
                    // suma
                    resultado = primerNumero + segundoNumero;
                    break;

                case "-":
                    // resta
                    resultado = primerNumero - segundoNumero;
                    break;

                case "*":
                    // multiplicación
                    resultado = primerNumero * segundoNumero;
                    break;

                case "/":
                    // división
                    if (segundoNumero == 0)
                    {
                        MessageBox.Show("No se puede dividir entre cero.");
                        return;
                    }

                    resultado = primerNumero / segundoNumero;
                    break;

            }

           

            
            txtResultado.Text = resultado.ToString();
            nuevaOperacion = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = string.Empty;
            primerNumero = 0;
            operacion = string.Empty;
            nuevaOperacion = false;
        }

    }
}
