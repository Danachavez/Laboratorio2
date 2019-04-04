using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class LaCalculadora : Form
    {
        /// <summary>
        /// Constructor por defecto de la clase del formulario.
        /// </summary>
        public LaCalculadora()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Limpia todos los campos del formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            cmbOperador.Text = "";
            lblResultado.Text = "";

        }

        /// <summary>
        /// Realiza la operaciòn entre los dos valores que recibe como parametros llamando al mètodo Operar de la clase Calculadora.
        /// </summary>
        /// <param name="numero1">Primer valor de la operaciòn</param>
        /// <param name="numero2">Segundo valor de la operaciòn.</param>
        /// <param name="operador">Operador recibido </param>
        /// <returns>Resultado de la operaciòn</returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            Numero nro1 = new Numero(double.Parse(numero1));
            Numero nro2 = new Numero(double.Parse(numero2));

            return Calculadora.Operar(nro1, nro2, operador);

        }

        /// <summary>
        /// Refleja el resultado de el mètodo operar en el botòn de resultados.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
           lblResultado.Text = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text).ToString();
        }

        /// <summary>
        /// Cierra el formultario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Botòn que convierte un nùmero decimal a binario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {

            Numero n = new Numero();
            lblResultado.Text = n.DecimalBinario(lblResultado.Text);

        }

        /// <summary>
        /// Botòn que convierte un nùmero binario a decimal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Numero n = new Numero();
            lblResultado.Text = n.BinarioDecimal(lblResultado.Text);
        }
    }
}
