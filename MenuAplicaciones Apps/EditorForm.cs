using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculadora.WForms
{
    public partial class EditorForm : Form
    {
        private string archivoActual = string.Empty;
        public EditorForm()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtEditor.Clear();
            archivoActual = string.Empty;
        }


        private void btnAbrir_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                archivoActual = openFileDialog1.FileName;
                txtEditor.Text = File.ReadAllText(archivoActual);
            }
        }

        private void btnGuardarComo_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                archivoActual = saveFileDialog1.FileName;
                File.WriteAllText(archivoActual, txtEditor.Text);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(archivoActual))
            {
                btnGuardarComo_Click(sender, e);
            }
            else
            {
                File.WriteAllText(archivoActual, txtEditor.Text);
            }
        }



    }

}
