namespace ExamenCubits
{
    partial class Captura
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
            label1 = new Label();
            label2 = new Label();
            cmbFechaIn = new ComboBox();
            cmbDia = new ComboBox();
            btnBsc = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 112);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 0;
            label1.Text = "Fecha de Inicio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(162, 199);
            label2.Name = "label2";
            label2.Size = new Size(32, 20);
            label2.TabIndex = 1;
            label2.Text = "Dia";
            // 
            // cmbFechaIn
            // 
            cmbFechaIn.FormattingEnabled = true;
            cmbFechaIn.Location = new Point(327, 112);
            cmbFechaIn.Name = "cmbFechaIn";
            cmbFechaIn.Size = new Size(151, 28);
            cmbFechaIn.TabIndex = 2;
            cmbFechaIn.SelectedIndexChanged += cmbFechaIn_SelectedIndexChanged;
            cmbFechaIn.Click += cmbFechaIn_Click;
            // 
            // cmbDia
            // 
            cmbDia.FormattingEnabled = true;
            cmbDia.Location = new Point(327, 196);
            cmbDia.Name = "cmbDia";
            cmbDia.Size = new Size(151, 28);
            cmbDia.TabIndex = 3;
            cmbDia.Click += cmbDia_Click;
            // 
            // btnBsc
            // 
            btnBsc.Location = new Point(230, 295);
            btnBsc.Name = "btnBsc";
            btnBsc.Size = new Size(94, 29);
            btnBsc.TabIndex = 4;
            btnBsc.Text = "Buscar";
            btnBsc.UseVisualStyleBackColor = true;
            btnBsc.Click += btnBsc_Click;
            // 
            // Captura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 384);
            Controls.Add(btnBsc);
            Controls.Add(cmbDia);
            Controls.Add(cmbFechaIn);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Captura";
            Text = "Captura";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cmbFechaIn;
        private ComboBox cmbDia;
        private Button btnBsc;
    }
}