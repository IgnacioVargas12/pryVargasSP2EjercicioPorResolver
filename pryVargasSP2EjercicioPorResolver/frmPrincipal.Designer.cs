namespace pryVargasSP2EjercicioPorResolver
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            lblDistancia = new Label();
            lblCantidadDias = new Label();
            nudCantidadDias = new NumericUpDown();
            mtbDistancia = new MaskedTextBox();
            btnCalcular = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)nudCantidadDias).BeginInit();
            SuspendLayout();
            // 
            // lblDistancia
            // 
            lblDistancia.AutoSize = true;
            lblDistancia.Font = new Font("Segoe UI", 12F);
            lblDistancia.Location = new Point(7, 12);
            lblDistancia.Name = "lblDistancia";
            lblDistancia.Size = new Size(350, 21);
            lblDistancia.TabIndex = 0;
            lblDistancia.Text = "Distancia hasta la localidad destino en kilómetros";
            // 
            // lblCantidadDias
            // 
            lblCantidadDias.AutoSize = true;
            lblCantidadDias.Font = new Font("Segoe UI", 12F);
            lblCantidadDias.Location = new Point(7, 50);
            lblCantidadDias.Name = "lblCantidadDias";
            lblCantidadDias.Size = new Size(206, 21);
            lblCantidadDias.TabIndex = 1;
            lblCantidadDias.Text = "Cantidad de días de estancia";
            // 
            // nudCantidadDias
            // 
            nudCantidadDias.Enabled = false;
            nudCantidadDias.Font = new Font("Segoe UI", 12F);
            nudCantidadDias.Location = new Point(219, 48);
            nudCantidadDias.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            nudCantidadDias.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidadDias.Name = "nudCantidadDias";
            nudCantidadDias.Size = new Size(59, 29);
            nudCantidadDias.TabIndex = 2;
            nudCantidadDias.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidadDias.ValueChanged += nudCantidadDias_ValueChanged;
            // 
            // mtbDistancia
            // 
            mtbDistancia.Font = new Font("Segoe UI", 12F);
            mtbDistancia.Location = new Point(363, 12);
            mtbDistancia.Mask = "999999999";
            mtbDistancia.Name = "mtbDistancia";
            mtbDistancia.Size = new Size(103, 29);
            mtbDistancia.TabIndex = 3;
            mtbDistancia.ValidatingType = typeof(int);
            mtbDistancia.TextChanged += mtbDistancia_TextChanged;
            // 
            // btnCalcular
            // 
            btnCalcular.Enabled = false;
            btnCalcular.Font = new Font("Segoe UI", 12F);
            btnCalcular.Location = new Point(385, 118);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(81, 31);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 12F);
            btnCancelar.Location = new Point(283, 118);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(83, 31);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 170);
            Controls.Add(btnCancelar);
            Controls.Add(btnCalcular);
            Controls.Add(mtbDistancia);
            Controls.Add(nudCantidadDias);
            Controls.Add(lblCantidadDias);
            Controls.Add(lblDistancia);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Precio de boletos";
            ((System.ComponentModel.ISupportInitialize)nudCantidadDias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDistancia;
        private Label lblCantidadDias;
        private NumericUpDown nudCantidadDias;
        private MaskedTextBox mtbDistancia;
        private Button btnCalcular;
        private Button btnCancelar;
    }
}
