namespace Calculadora.WForms
{
    partial class CalculadoraForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtResultado = new TextBox();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            BtnDivision = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnMultiplicacion = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnResta = new Button();
            btn0 = new Button();
            btnBorrar = new Button();
            btnIgual = new Button();
            btnSuma = new Button();
            btnDecimal = new Button();
            SuspendLayout();
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(72, 55);
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(415, 27);
            txtResultado.TabIndex = 0;
            txtResultado.TextAlign = HorizontalAlignment.Right;
            txtResultado.TextChanged += txtResultado_TextChanged;
            // 
            // btn7
            // 
            btn7.Location = new Point(15, 210);
            btn7.Name = "btn7";
            btn7.Size = new Size(105, 106);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += Numeros_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(140, 210);
            btn8.Name = "btn8";
            btn8.Size = new Size(105, 106);
            btn8.TabIndex = 2;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += Numeros_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(271, 210);
            btn9.Name = "btn9";
            btn9.Size = new Size(105, 106);
            btn9.TabIndex = 3;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += Numeros_Click;
            // 
            // BtnDivision
            // 
            BtnDivision.BackColor = Color.Khaki;
            BtnDivision.Location = new Point(399, 210);
            BtnDivision.Name = "BtnDivision";
            BtnDivision.Size = new Size(105, 106);
            BtnDivision.TabIndex = 4;
            BtnDivision.Text = "÷";
            BtnDivision.UseVisualStyleBackColor = false;
            BtnDivision.Click += BtnDivision_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(15, 335);
            btn4.Name = "btn4";
            btn4.Size = new Size(105, 106);
            btn4.TabIndex = 5;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += Numeros_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(140, 335);
            btn5.Name = "btn5";
            btn5.Size = new Size(105, 106);
            btn5.TabIndex = 6;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += Numeros_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(271, 335);
            btn6.Name = "btn6";
            btn6.Size = new Size(105, 106);
            btn6.TabIndex = 7;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += Numeros_Click;
            // 
            // btnMultiplicacion
            // 
            btnMultiplicacion.BackColor = Color.Khaki;
            btnMultiplicacion.Location = new Point(399, 335);
            btnMultiplicacion.Name = "btnMultiplicacion";
            btnMultiplicacion.Size = new Size(105, 106);
            btnMultiplicacion.TabIndex = 8;
            btnMultiplicacion.Text = "x";
            btnMultiplicacion.UseVisualStyleBackColor = false;
            btnMultiplicacion.Click += btnMultiplicacion_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(15, 463);
            btn1.Name = "btn1";
            btn1.Size = new Size(105, 106);
            btn1.TabIndex = 9;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += Numeros_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(140, 463);
            btn2.Name = "btn2";
            btn2.Size = new Size(105, 106);
            btn2.TabIndex = 10;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += Numeros_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(271, 463);
            btn3.Name = "btn3";
            btn3.Size = new Size(105, 106);
            btn3.TabIndex = 11;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += Numeros_Click;
            // 
            // btnResta
            // 
            btnResta.BackColor = Color.Khaki;
            btnResta.Location = new Point(399, 463);
            btnResta.Name = "btnResta";
            btnResta.Size = new Size(105, 106);
            btnResta.TabIndex = 12;
            btnResta.Text = "-";
            btnResta.UseVisualStyleBackColor = false;
            btnResta.Click += btnResta_Click;
            // 
            // btn0
            // 
            btn0.BackColor = Color.Khaki;
            btn0.Location = new Point(15, 591);
            btn0.Name = "btn0";
            btn0.Size = new Size(105, 106);
            btn0.TabIndex = 13;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += Numeros_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.Khaki;
            btnBorrar.Location = new Point(126, 591);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(97, 106);
            btnBorrar.TabIndex = 14;
            btnBorrar.Text = "C";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnLimpiar_Click;
            // 
            // btnIgual
            // 
            btnIgual.BackColor = Color.Khaki;
            btnIgual.Location = new Point(229, 591);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(79, 106);
            btnIgual.TabIndex = 15;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = false;
            btnIgual.Click += btnIgual_Click;
            // 
            // btnSuma
            // 
            btnSuma.BackColor = Color.Khaki;
            btnSuma.Location = new Point(399, 591);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new Size(105, 106);
            btnSuma.TabIndex = 16;
            btnSuma.Text = "+";
            btnSuma.UseVisualStyleBackColor = false;
            btnSuma.Click += btnSuma_Click;
            // 
            // btnDecimal
            // 
            btnDecimal.BackColor = Color.Khaki;
            btnDecimal.Location = new Point(314, 591);
            btnDecimal.Name = "btnDecimal";
            btnDecimal.Size = new Size(79, 106);
            btnDecimal.TabIndex = 17;
            btnDecimal.Text = ".\r\n";
            btnDecimal.UseVisualStyleBackColor = false;
            btnDecimal.Click += Numeros_Click;
            // 
            // CalculadoraForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = MenuVariasApps.Properties.Resources.download;
            ClientSize = new Size(521, 754);
            Controls.Add(btnDecimal);
            Controls.Add(btnSuma);
            Controls.Add(btnIgual);
            Controls.Add(btnBorrar);
            Controls.Add(btn0);
            Controls.Add(btnResta);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnMultiplicacion);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(BtnDivision);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(txtResultado);
            Name = "CalculadoraForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResultado;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button BtnDivision;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnMultiplicacion;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnResta;
        private Button btn0;
        private Button btnBorrar;
        private Button btnIgual;
        private Button btnSuma;
        private Button btnDecimal;
    }
}

