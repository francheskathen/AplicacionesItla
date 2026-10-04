namespace Calculadora.WForms
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            lblTitulo = new Label();
            btnCalculadora = new Button();
            btnPain = new Button();
            btnEditor = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BorderStyle = BorderStyle.FixedSingle;
            lblTitulo.Font = new Font("Showcard Gothic", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.ButtonHighlight;
            lblTitulo.Image = (Image)resources.GetObject("lblTitulo.Image");
            lblTitulo.Location = new Point(137, 93);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(347, 61);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "APLICACIONES";
            // 
            // btnCalculadora
            // 
            btnCalculadora.BackColor = Color.BurlyWood;
            btnCalculadora.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculadora.ForeColor = SystemColors.ButtonHighlight;
            btnCalculadora.Location = new Point(229, 210);
            btnCalculadora.Name = "btnCalculadora";
            btnCalculadora.Size = new Size(140, 80);
            btnCalculadora.TabIndex = 1;
            btnCalculadora.Text = "CALCULADORA";
            btnCalculadora.UseVisualStyleBackColor = false;
            btnCalculadora.Click += btnCalculadora_Click;
            // 
            // btnPain
            // 
            btnPain.BackColor = Color.BurlyWood;
            btnPain.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPain.ForeColor = SystemColors.ButtonHighlight;
            btnPain.Location = new Point(229, 312);
            btnPain.Name = "btnPain";
            btnPain.Size = new Size(140, 80);
            btnPain.TabIndex = 2;
            btnPain.Text = "PAINT";
            btnPain.UseVisualStyleBackColor = false;
            btnPain.Click += btnPain_Click;
            // 
            // btnEditor
            // 
            btnEditor.BackColor = Color.BurlyWood;
            btnEditor.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditor.ForeColor = SystemColors.ButtonHighlight;
            btnEditor.Location = new Point(229, 413);
            btnEditor.Name = "btnEditor";
            btnEditor.Size = new Size(140, 80);
            btnEditor.TabIndex = 3;
            btnEditor.Text = "EDITOR";
            btnEditor.UseVisualStyleBackColor = false;
            btnEditor.Click += btnEditor_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(497, 559);
            button3.Name = "button3";
            button3.Size = new Size(102, 44);
            button3.TabIndex = 4;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(630, 643);
            Controls.Add(button3);
            Controls.Add(btnEditor);
            Controls.Add(btnPain);
            Controls.Add(btnCalculadora);
            Controls.Add(lblTitulo);
            Name = "MenuForm";
            Text = "MenuForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button btnCalculadora;
        private Button btnPain;
        private Button btnEditor;
        private Button button3;
    }
}