﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2018
{
    /// <summary>
    /// No podrá tener clases heredadas.
    /// </summary>
    public sealed class Changuito
    {
        public enum ETipo
        {
            Dulce, Leche, Snacks, Todos
        }
        #region Atributos

        List<Producto> productos;
        int espacioDisponible;

        #endregion

        #region "Constructores"

        /// <summary>
        /// Constructor que inicializa la lista de productos.
        /// </summary>
        private Changuito()
        {
            this.productos = new List<Producto>();
        }

        /// <summary>
        /// Constructor que recibe el espacio disponible del changuito.
        /// </summary>
        /// <param name="espacioDisponible"></param>
        public Changuito(int espacioDisponible):this()
        {
            this.espacioDisponible = espacioDisponible;
        }
        #endregion

        #region "Sobrecargas"
        /// <summary>
        /// Muestro el Changuito y TODOS los Productos
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Mostrar(this, ETipo.Todos);
        }
        #endregion

        #region "Métodos"

        /// <summary>
        /// Expone los datos del elemento y su lista (incluidas sus herencias)
        /// SOLO del tipo requerido
        /// </summary>
        /// <param name="c">Elemento a exponer</param>
        /// <param name="ETipo">Tipos de ítems de la lista a mostrar</param>
        /// <returns></returns>
        public string Mostrar(Changuito c, ETipo tipo)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Tenemos {0} lugares ocupados de un total de {1} disponibles", c.productos.Count, c.espacioDisponible);
            sb.AppendLine("");
            foreach (Producto v in c.productos)
            {
                switch (tipo)
                {
                    case ETipo.Snacks:

                        if (v is Snacks)
                        {
                            sb.AppendLine(((Snacks)v).Mostrar());
                        }

                        break;

                    case ETipo.Dulce:
                        if (v is Dulce)
                        {
                            sb.AppendLine(((Dulce)v).Mostrar());
                        }

                        break;
                    case ETipo.Leche:

                        if (v is Leche)
                        {
                            sb.AppendLine(((Leche)v).Mostrar());
                        }

                        break;

                    case ETipo.Todos:

                        if (v is Snacks)
                        {
                            sb.AppendLine(((Snacks)v).Mostrar());
                        }
                        else if (v is Dulce)
                        {
                            sb.AppendLine(((Dulce)v).Mostrar());
                        }
                        else
                        {
                            sb.AppendLine(((Leche)v).Mostrar());
                        }

                        break;
                }
            }

            return sb.ToString();
        }
        #endregion

        #region "Operadores"
        /// <summary>
        /// Agregará un elemento a la lista
        /// </summary>
        /// <param name="c">Objeto donde se agregará el elemento</param>
        /// <param name="p">Objeto a agregar</param>
        /// <returns></returns>
        public static Changuito operator +(Changuito c, Producto p)
        {
            if (c.productos.Count >= c.espacioDisponible)
            {
                return c;
              
            }

            foreach (Producto v in c.productos)
            {
                if (v == p)
                {
                    return c;
                }
                   
            }

            c.productos.Add(p);


            return c;
        }
        /// <summary>
        /// Quitará un elemento de la lista
        /// </summary>
        /// <param name="c">Objeto donde se quitará el elemento</param>
        /// <param name="p">Objeto a quitar</param>
        /// <returns></returns>
        public static Changuito operator -(Changuito c, Producto p)
        {
            foreach (Producto v in c.productos)
            {
                if (v == p)
                {
                    c.productos.Remove(p);
                    break;
                }

               
            }

            return c;
        }
        #endregion
    }
}
