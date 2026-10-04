using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculadora.WForms
{
    public partial class PaintForm : Form
    {
        public PaintForm()
        {
            InitializeComponent();
        }


        /// //////////////////////////////////////////////////////////////////
        /// BOTONES DE COLORES
        private void btnRojo_Click(object sender, EventArgs e)
        {
            panelDibujo.BackColor = Color.Red;
            colorActual = Color.Red;
        }

        private void btnAzul_Click(object sender, EventArgs e)
        {
            panelDibujo.BackColor = Color.Blue;
            colorActual = Color.Blue;
        }

        private void btnAmarillo_Click(object sender, EventArgs e)
        {
            panelDibujo.BackColor = Color.Yellow;
            colorActual = Color.Yellow;
        }

        private void btnVerde_Click(object sender, EventArgs e)
        {
            panelDibujo.BackColor = Color.Green;
            colorActual = Color.Green;
        }

        private void btnElegir_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                panelDibujo.BackColor = colorDialog1.Color;
            }
        }

        ////////////////////////////////////////////////////////////////////

        private bool dibujando = false;
        private Point puntoAnterior;
        private Color colorActual = Color.Black;

        private void panelDibujo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dibujando = true;
                puntoAnterior = e.Location;
            }
        }

        /// /////////////////////////////////
        /// ajustar el color del lápiz según el color de fondo

        private void panelDibujo_MouseMove(object sender, MouseEventArgs e)
        {
            if (dibujando)
            {
                using (Graphics g = panelDibujo.CreateGraphics())
                {
                    using (Pen lapiz = new Pen(colorActual, 3))
                    {
                        g.DrawLine(lapiz, puntoAnterior, e.Location);
                    }
                }

                puntoAnterior = e.Location;
            }
        }

        /// 
        /// Finaliza el dibujo cuando se suelta el botón del ratón
        /// 
        private void panelDibujo_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dibujando = false;
            }
        }

        private void PaintForm_Load(object sender, EventArgs e)
        {

        }
    }


}
