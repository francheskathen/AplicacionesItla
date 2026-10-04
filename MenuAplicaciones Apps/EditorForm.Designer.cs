namespace Calculadora.WForms
{
    partial class EditorForm
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
            txtEditor = new RichTextBox();
            btnNuevo = new Button();
            btnAbrir = new Button();
            btnGuardarComo = new Button();
            btnGuardar = new Button();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            SuspendLayout();
            // 
            // txtEditor
            // 
            txtEditor.BackColor = SystemColors.Info;
            txtEditor.Location = new Point(12, 67);
            txtEditor.Name = "txtEditor";
            txtEditor.Size = new Size(776, 469);
            txtEditor.TabIndex = 0;
            txtEditor.Text = "";
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = SystemColors.MenuBar;
            btnNuevo.Font = new Font("Palatino Linotype", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNuevo.Location = new Point(39, 22);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(94, 29);
            btnNuevo.TabIndex = 1;
            btnNuevo.Text = "Nuevo";
            btnNuevo.TextAlign = ContentAlignment.TopCenter;
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnAbrir
            // 
            btnAbrir.BackColor = SystemColors.MenuBar;
            btnAbrir.Font = new Font("Palatino Linotype", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAbrir.Location = new Point(155, 22);
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Size = new Size(94, 29);
            btnAbrir.TabIndex = 2;
            btnAbrir.Text = "Abrir";
            btnAbrir.TextAlign = ContentAlignment.TopCenter;
            btnAbrir.UseVisualStyleBackColor = false;
            btnAbrir.Click += btnAbrir_Click;
            // 
            // btnGuardarComo
            // 
            btnGuardarComo.BackColor = SystemColors.MenuBar;
            btnGuardarComo.Font = new Font("Palatino Linotype", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardarComo.Location = new Point(389, 22);
            btnGuardarComo.Name = "btnGuardarComo";
            btnGuardarComo.Size = new Size(142, 29);
            btnGuardarComo.TabIndex = 3;
            btnGuardarComo.Text = "Guardar como";
            btnGuardarComo.TextAlign = ContentAlignment.TopCenter;
            btnGuardarComo.UseVisualStyleBackColor = false;
            btnGuardarComo.Click += btnGuardarComo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.MenuBar;
            btnGuardar.Font = new Font("Palatino Linotype", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(271, 22);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.TopCenter;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            // 
            // EditorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = MenuVariasApps.Properties.Resources.download__2_;
            ClientSize = new Size(800, 558);
            Controls.Add(btnGuardar);
            Controls.Add(btnGuardarComo);
            Controls.Add(btnAbrir);
            Controls.Add(btnNuevo);
            Controls.Add(txtEditor);
            Name = "EditorForm";
            Text = "EditorForm";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox txtEditor;
        private Button btnNuevo;
        private Button btnAbrir;
        private Button btnGuardarComo;
        private Button btnGuardar;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}