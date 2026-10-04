namespace Calculadora.WForms
{
    partial class PaintForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelDibujo = new Panel();
            btnRojo = new Button();
            btnAzul = new Button();
            btnAmarillo = new Button();
            btnVerde = new Button();
            btnElegir = new Button();
            colorDialog1 = new ColorDialog();
            SuspendLayout();
            // 
            // panelDibujo
            // 
            panelDibujo.Location = new Point(42, 31);
            panelDibujo.Name = "panelDibujo";
            panelDibujo.Size = new Size(716, 274);
            panelDibujo.TabIndex = 0;
            panelDibujo.MouseDown += panelDibujo_MouseDown;
            panelDibujo.MouseMove += panelDibujo_MouseMove;
            panelDibujo.MouseUp += panelDibujo_MouseUp;
            // 
            // btnRojo
            // 
            btnRojo.BackColor = Color.FromArgb(192, 0, 0);
            btnRojo.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnRojo.ForeColor = SystemColors.ButtonHighlight;
            btnRojo.Location = new Point(54, 334);
            btnRojo.Name = "btnRojo";
            btnRojo.Size = new Size(94, 87);
            btnRojo.TabIndex = 1;
            btnRojo.Text = "Rojo";
            btnRojo.UseVisualStyleBackColor = false;
            btnRojo.Click += btnRojo_Click;
            // 
            // btnAzul
            // 
            btnAzul.BackColor = SystemColors.ActiveCaption;
            btnAzul.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnAzul.ForeColor = SystemColors.ButtonHighlight;
            btnAzul.Location = new Point(186, 334);
            btnAzul.Name = "btnAzul";
            btnAzul.Size = new Size(94, 87);
            btnAzul.TabIndex = 2;
            btnAzul.Text = "Azul";
            btnAzul.UseVisualStyleBackColor = false;
            btnAzul.Click += btnAzul_Click;
            // 
            // btnAmarillo
            // 
            btnAmarillo.BackColor = Color.Khaki;
            btnAmarillo.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnAmarillo.ForeColor = SystemColors.ButtonHighlight;
            btnAmarillo.Location = new Point(325, 334);
            btnAmarillo.Name = "btnAmarillo";
            btnAmarillo.Size = new Size(94, 87);
            btnAmarillo.TabIndex = 3;
            btnAmarillo.Text = "Amarillo";
            btnAmarillo.UseVisualStyleBackColor = false;
            btnAmarillo.Click += btnAmarillo_Click;
            // 
            // btnVerde
            // 
            btnVerde.BackColor = Color.FromArgb(192, 192, 0);
            btnVerde.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnVerde.ForeColor = SystemColors.ButtonHighlight;
            btnVerde.Location = new Point(466, 334);
            btnVerde.Name = "btnVerde";
            btnVerde.Size = new Size(94, 87);
            btnVerde.TabIndex = 4;
            btnVerde.Text = "Verde";
            btnVerde.UseVisualStyleBackColor = false;
            btnVerde.Click += btnVerde_Click;
            // 
            // btnElegir
            // 
            btnElegir.BackColor = Color.Ivory;
            btnElegir.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnElegir.Location = new Point(630, 334);
            btnElegir.Name = "btnElegir";
            btnElegir.Size = new Size(128, 87);
            btnElegir.TabIndex = 5;
            btnElegir.Text = "Elegir Color";
            btnElegir.UseVisualStyleBackColor = false;
            btnElegir.Click += btnElegir_Click;
            // 
            // PaintForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = MenuVariasApps.Properties.Resources.theme_picture__p;
            ClientSize = new Size(800, 450);
            Controls.Add(btnElegir);
            Controls.Add(btnVerde);
            Controls.Add(btnAmarillo);
            Controls.Add(btnAzul);
            Controls.Add(btnRojo);
            Controls.Add(panelDibujo);
            Name = "PaintForm";
            Text = "PaintForm";
            Load += PaintForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel panelDibujo;
        private Button btnRojo;
        private Button btnAzul;
        private Button btnAmarillo;
        private Button btnVerde;
        private Button btnElegir;
        private ColorDialog colorDialog1;
    }
}