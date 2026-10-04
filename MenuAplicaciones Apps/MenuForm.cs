using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculadora.WForms
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void btnCalculadora_Click(object sender, EventArgs e)
        {
            CalculadoraForm calculadora = new CalculadoraForm();
            calculadora.Show();
        }

        private void btnPain_Click(object sender, EventArgs e)
        {
            PaintForm paint = new PaintForm();
            paint.Show();
        }

        private void btnEditor_Click(object sender, EventArgs e)
        {
            EditorForm editor = new EditorForm();
            editor.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    
}
