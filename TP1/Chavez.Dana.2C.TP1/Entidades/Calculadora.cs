using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Valida que la cadena ingresada sea un operador vàlido.
        /// </summary>
        /// <param name="operador"> cadena a validar</param>
        /// <returns> Retorna el operador un operador vàlido o + si no es un operador vàlido </returns>
        
        private static string ValidarOperador(string operador)
        {
            string signo;

            if (operador == "+" || operador == "-" || operador == "/" || operador == "*")
            {

                signo = operador;

            }
            else
            {
                signo = "+";

            }

            return signo;

        }
        /// <summary>
        /// Valida y realiza la operaciòn pedida entre ambos nùmeros.
        /// </summary>
        /// <param name="num1"> primer nùmero de la operaciòn</param>
        /// <param name="num2"> segundo nùmero de la operaciòn</param>
        /// <param name="operador"></param>
        /// <returns> Retorna el resultado de la operaciòn </returns>

        public static double Operar(Numero num1, Numero num2, string operador)
        {
            double resultado = 0;

            switch (ValidarOperador(operador))
            {
                case "+":
                    resultado = num1 + num2;
                    break;

                case "-":
                    resultado = num1 - num2;
                    break;

                case "*":
                    resultado = num1 * num2;
                    break;
                case "/":
                    resultado = num1 / num2;
                    break;

            }

            return resultado;

        }

    }
}
