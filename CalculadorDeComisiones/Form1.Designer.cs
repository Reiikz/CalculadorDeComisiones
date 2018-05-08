namespace CalculadorDeComisiones
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudComision = new System.Windows.Forms.NumericUpDown();
            this.nudIVA = new System.Windows.Forms.NumericUpDown();
            this.txtComisionExtra = new System.Windows.Forms.TextBox();
            this.txtSalida = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudComision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIVA)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dinero de entrada";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Extra de comisión";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(328, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "IVA";
            // 
            // nudComision
            // 
            this.nudComision.DecimalPlaces = 1;
            this.nudComision.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudComision.Location = new System.Drawing.Point(118, 25);
            this.nudComision.Name = "nudComision";
            this.nudComision.Size = new System.Drawing.Size(117, 20);
            this.nudComision.TabIndex = 5;
            this.nudComision.Value = new decimal(new int[] {
            25,
            0,
            0,
            65536});
            this.nudComision.ValueChanged += new System.EventHandler(this.nudComision_ValueChanged);
            // 
            // nudIVA
            // 
            this.nudIVA.DecimalPlaces = 1;
            this.nudIVA.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudIVA.Location = new System.Drawing.Point(331, 26);
            this.nudIVA.Name = "nudIVA";
            this.nudIVA.Size = new System.Drawing.Size(120, 20);
            this.nudIVA.TabIndex = 6;
            this.nudIVA.Value = new decimal(new int[] {
            22,
            0,
            0,
            0});
            this.nudIVA.ValueChanged += new System.EventHandler(this.nudIVA_ValueChanged);
            // 
            // txtComisionExtra
            // 
            this.txtComisionExtra.Location = new System.Drawing.Point(244, 26);
            this.txtComisionExtra.Name = "txtComisionExtra";
            this.txtComisionExtra.Size = new System.Drawing.Size(81, 20);
            this.txtComisionExtra.TabIndex = 7;
            this.txtComisionExtra.Text = "0.5";
            this.txtComisionExtra.TextChanged += new System.EventHandler(this.txtComisionExtra_TextChanged);
            // 
            // txtSalida
            // 
            this.txtSalida.Location = new System.Drawing.Point(12, 64);
            this.txtSalida.Name = "txtSalida";
            this.txtSalida.Size = new System.Drawing.Size(439, 20);
            this.txtSalida.TabIndex = 8;
            this.txtSalida.Text = "0";
            this.txtSalida.TextChanged += new System.EventHandler(this.txtSalida_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Salida";
            // 
            // txtEntrada
            // 
            this.txtEntrada.Location = new System.Drawing.Point(12, 24);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(100, 20);
            this.txtEntrada.TabIndex = 10;
            this.txtEntrada.Text = "0";
            this.txtEntrada.TextChanged += new System.EventHandler(this.txtEntrada_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Porcentaje comision";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(346, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Recuerda que el valor de la tarjeta de débito puede ser 1 decimal mayor";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 91);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEntrada);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSalida);
            this.Controls.Add(this.txtComisionExtra);
            this.Controls.Add(this.nudIVA);
            this.Controls.Add(this.nudComision);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "calculador de Mierda :v";
            ((System.ComponentModel.ISupportInitialize)(this.nudComision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIVA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudComision;
        private System.Windows.Forms.NumericUpDown nudIVA;
        private System.Windows.Forms.TextBox txtComisionExtra;
        private System.Windows.Forms.TextBox txtSalida;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
    }
}

