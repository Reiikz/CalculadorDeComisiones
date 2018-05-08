using Calculador_de_resistencias;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadorDeComisiones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcular()
        {
            SIU s = new SIU();
            double dinero_entrada = s.getRealNumber(txtEntrada.Text);
            double porcentaje_comision = Convert.ToDouble(nudComision.Value) / 100;
            double comision_extra = s.getRealNumber(txtComisionExtra.Text);
            double iva = Convert.ToDouble(nudIVA.Value) / 100;
            double valor_de_comision = (dinero_entrada * porcentaje_comision) + comision_extra;
            double comision_mas_iva = valor_de_comision + (valor_de_comision * iva);
            comision_mas_iva += dinero_entrada;
            if (comision_mas_iva % 1 == 0)
                txtSalida.Text = Math.Round(comision_mas_iva, 2).ToString();
            else
                txtSalida.Text = (Math.Round(comision_mas_iva, 2) + 0.01).ToString();
        }

        private void txtEntrada_TextChanged(object sender, EventArgs e)
        {
            calcular();
        }

        private void nudComision_ValueChanged(object sender, EventArgs e)
        {
            calcular();
        }

        private void txtComisionExtra_TextChanged(object sender, EventArgs e)
        {
            calcular();
        }

        private void nudIVA_ValueChanged(object sender, EventArgs e)
        {
            calcular();
        }

        private void txtSalida_TextChanged(object sender, EventArgs e)
        {
            calcular();
        }
    }
}
