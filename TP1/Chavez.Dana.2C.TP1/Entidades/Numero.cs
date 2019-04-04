using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        #region Atributos

        private double numero;

        #endregion

        #region Constructores

        /// <summary>
        /// Constructor por defecto inicializa el atributo numero en 0.
        /// </summary>
        public Numero()
        { }

        /// <summary>
        /// Constructor de instancia inicializa el atributo numero.
        /// </summary>
        /// <param name="numero">valor que recibe</param>
        public Numero(double numero):this()
        {
            this.numero = numero;
        }

        /// <summary>
        /// Constructor de instancia con cadena a nùmero,
        /// </summary>
        /// <param name="strNumero">string que recibe</param>
        public Numero(string strNumero)
        {
            this.SetNumero = strNumero;

        }

        #endregion

        #region Propiedades

        /// <summary>
        /// Asigna un valor a atributo nùmero, previa validaciòn. 
        /// </summary>
        public string SetNumero
        {
            set
            {
                this.numero = ValidarNumero(value);

            }
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Comprueba que el valor recibido como cadena sea numerico.
        /// </summary>
        /// <param name="strNumero">cadena a validar</param>
        /// <returns>Numero flotante resultado de la conversiòn, devuelve 0 si no se pudo realizar la conversion</returns>
        private double ValidarNumero(string strNumero)
        {

            if (double.TryParse(strNumero, out double numeroDouble))
            {
                return numeroDouble;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// Método que convierte un binario en un número decimal.
        /// </summary>
        /// <param name="binario">Binario a convertir.</param>
        /// <returns>Numero decimal resultado de la conversión.</returns>
        public  string BinarioDecimal(string binario)
        {
            double numero = 0;
            string cadena = "";

            if(int.TryParse(binario, out int entero))
            {
                
                for (int i = 1; i <= binario.Length; i++)
                {
                    numero += int.Parse(binario[i - 1].ToString()) * (int)Math.Pow(2, binario.Length - i);
                }

                cadena = Convert.ToString(numero);
               
            }       
            else
            {
                cadena = "Valor inválido!!";
            }

            return cadena;
        }

        /// <summary>
        /// Método que convierte un número decimal en un binario ASCII
        /// </summary>
        /// <param name="numero">Número a convertir</param>
        /// <returns>Valor binario resultado de la conversión sino puede convertir devuelve "Valor invàlido".</returns>
        public string DecimalBinario(double numero)
        {
            string binario = "";
            
           if (int.TryParse(numero.ToString(), out int nro))
            {
                while (nro > 0)
                {
                    binario = (nro % 2).ToString() + binario;
                    nro = nro / 2;
                }

            }
            else
            {
                binario = "Valor inválido!!";

            }

            return binario;

        }

        /// <summary>
        /// Método que convierte un número decimal a binario.
        /// </summary>
        /// <param name="numero">cadena a convertir</param>
        /// <returns>Valor binario resultado de la conversión.</returns>
        public string DecimalBinario(string numero)
        {
            double nro = 0;

            if (double.TryParse(numero, out nro))
            {
                return DecimalBinario(nro);
            }
            else
            {
                return "Valor inválido!!";

            }
   

        }

        #endregion

        #region Sobrecargas

        /// <summary>
        /// Realiza la suma entre dos nùmeros.
        /// </summary>
        /// <param name="n1">Primer nùmero de la operaciòn</param>
        /// <param name="n2">Segundo nùmero de la operaciòn</param>
        /// <returns>Resultado de la operaciòn.</returns>
        public static double operator +(Numero n1, Numero n2)
        {
            double retorno = 0;

            retorno = n1.numero + n2.numero;

            return retorno;

        }
        /// <summary>
        /// Realiza la resta entre dos nùmeros.
        /// </summary>
        /// <param name="n1">Primer nùmero de la operaciòn</param>
        /// <param name="n2">Segundo nùmero de la operaciòn</param>
        /// <returns>Resultado de la operaciòn.</returns>
        public static double operator -(Numero n1, Numero n2)
        {
            double retorno = 0;

            retorno = n1.numero - n2.numero;

            return retorno;

        }
        /// <summary>
        /// Realiza la multiplicaciòn entre dos nùmeros.
        /// </summary>
        /// <param name="n1">Primer nùmero de la operaciòn</param>
        /// <param name="n2">Segundo nùmero de la operaciòn</param>
        /// <returns>Resultado de la operaciòn.</returns>
        public static double operator *(Numero n1, Numero n2)
        {
            double retorno = 0;

            retorno = n1.numero * n2.numero;

            return retorno;

        }
        /// <summary>
        /// Realiza la divisiòn entre dos nùmeros.
        /// </summary>
        /// <param name="n1">Primer nùmero de la operaciòn.</param>
        /// <param name="n2">Segundo nùmero de la operaciòn.</param>
        /// <returns>Resultado de la operaciòn.</returns>
        public static double operator /(Numero n1, Numero n2)
        {
            double retorno = 0;

            if (n2.numero == 0)
            {
                retorno = double.MinValue;
            }

            retorno = n1.numero / n2.numero;

            return retorno;

        }

        #endregion

    }
}
