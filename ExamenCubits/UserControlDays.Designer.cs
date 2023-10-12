namespace ExamenCubits
{
    partial class UserControlDays
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            lblDays = new Label();
            SuspendLayout();
            // 
            // lblDays
            // 
            lblDays.AutoSize = true;
            lblDays.Location = new Point(42, 43);
            lblDays.Name = "lblDays";
            lblDays.Size = new Size(25, 20);
            lblDays.TabIndex = 0;
            lblDays.Text = "00";
            lblDays.Click += lblDays_Click;
            // 
            // UserControlDays
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lblDays);
            Name = "UserControlDays";
            Size = new Size(112, 98);
            Load += UserControlDays_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDays;
    }
}
