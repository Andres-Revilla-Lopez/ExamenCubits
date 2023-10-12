namespace ExamenCubits
{
    partial class Calendario
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
            ContenedorDias = new FlowLayoutPanel();
            btnSiguiente = new Button();
            btnAnterior = new Button();
            lblDomingo = new Label();
            lblLunes = new Label();
            lblMartes = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            lbldate = new Label();
            SuspendLayout();
            // 
            // ContenedorDias
            // 
            ContenedorDias.Location = new Point(11, 99);
            ContenedorDias.Name = "ContenedorDias";
            ContenedorDias.Size = new Size(846, 640);
            ContenedorDias.TabIndex = 0;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Location = new Point(720, 757);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(94, 29);
            btnSiguiente.TabIndex = 1;
            btnSiguiente.Text = "Siguente";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.Location = new Point(604, 757);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(94, 29);
            btnAnterior.TabIndex = 2;
            btnAnterior.Text = "Anterior";
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // lblDomingo
            // 
            lblDomingo.AutoSize = true;
            lblDomingo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDomingo.Location = new Point(31, 65);
            lblDomingo.Name = "lblDomingo";
            lblDomingo.Size = new Size(95, 28);
            lblDomingo.TabIndex = 3;
            lblDomingo.Text = "Domingo";
            // 
            // lblLunes
            // 
            lblLunes.AutoSize = true;
            lblLunes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLunes.Location = new Point(162, 65);
            lblLunes.Name = "lblLunes";
            lblLunes.Size = new Size(61, 28);
            lblLunes.TabIndex = 4;
            lblLunes.Text = "Lunes";
            // 
            // lblMartes
            // 
            lblMartes.AutoSize = true;
            lblMartes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMartes.Location = new Point(273, 65);
            lblMartes.Name = "lblMartes";
            lblMartes.Size = new Size(72, 28);
            lblMartes.TabIndex = 5;
            lblMartes.Text = "Martes";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(384, 65);
            label4.Name = "label4";
            label4.Size = new Size(96, 28);
            label4.TabIndex = 6;
            label4.Text = "Miercoles";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(516, 65);
            label5.Name = "label5";
            label5.Size = new Size(68, 28);
            label5.TabIndex = 7;
            label5.Text = "Jueves";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(625, 65);
            label6.Name = "label6";
            label6.Size = new Size(75, 28);
            label6.TabIndex = 8;
            label6.Text = "Viernes";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(735, 65);
            label7.Name = "label7";
            label7.Size = new Size(79, 28);
            label7.TabIndex = 9;
            label7.Text = "Sabado";
            // 
            // lbldate
            // 
            lbldate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbldate.Location = new Point(240, 9);
            lbldate.Name = "lbldate";
            lbldate.Size = new Size(392, 36);
            lbldate.TabIndex = 10;
            lbldate.Text = "MES ANO";
            lbldate.TextAlign = ContentAlignment.TopCenter;
            // 
            // Calendario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 791);
            Controls.Add(lbldate);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lblMartes);
            Controls.Add(lblLunes);
            Controls.Add(lblDomingo);
            Controls.Add(btnAnterior);
            Controls.Add(btnSiguiente);
            Controls.Add(ContenedorDias);
            Name = "Calendario";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel ContenedorDias;
        private Button btnSiguiente;
        private Button btnAnterior;
        private Label lblDomingo;
        private Label lblLunes;
        private Label lblMartes;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label lbldate;
    }
}