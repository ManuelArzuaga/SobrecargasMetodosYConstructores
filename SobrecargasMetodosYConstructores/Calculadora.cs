using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobrecargasMetodosYConstructores
{
    ///<summary>
    ///Crea un summary que es una descripcion que aparece cuando pones el cursor sobre la clase
    ///tiene que estar por encima de una clase
    /// </summary>
    /// <param name="Nombre">Ingresar el nombre</param> aparece el comentario al poner el cursor sobre la clase
    class Calculadora
    {
        //sobrecarga de constructores
        //se pueden tener varios constructores, lo unico que tienen que tener diferente son los parametros que recibe
        /// <summary>
        /// Construcotor vacio
        /// </summary>

        #region Constructores
        public Calculadora()
        {
            
        }

        /// <summary>
        /// Constructor de la clase con dos parametros a y b
        /// </summary>
        /// <param name="a">Primer numero a sumar</param>
        /// <param name="b">Segundo numero a sumar</param>
        public Calculadora(int a, int b)
        {
            
        }

        /// <summary>
        /// constructor con dos parametros decimales
        /// </summary>
        /// <param name="a">Primer numero a sumar</param>
        /// <param name="b">Segundo numero a sumar</param>
        public Calculadora(double a, double b)
        {
            
        }

        /// <summary>
        /// constructor con tres parametros a sumar
        /// </summary>
        /// <param name="a">Primer numero a sumar</param>
        /// <param name="b">Segundo numero a sumar</param>
        /// <param name="c">Tercer numero a sumar</param>
        public Calculadora(int a, int b, int c)
        {
            
        }

        #endregion

        //para hacer una region se pone #region nombredelaregion donde empieza y endregion donde termina la region

        //sobrecarga de metodos
        //permite tener varios metodos con el mismo nombre pero tiene que recibir diferentes parametros
        #region Funciones
        /// <summary>
        /// metodo que suma dos numeros enteros
        /// </summary>
        /// <param name="a">Primer numero a sumar</param>
        /// <param name="b">Segundo numero a sumar</param>
        /// <returns>Retorna la sumatoria entre a y b</returns>
        public int Sumar(int a,int b)
        {
            return a + b;
        }

        /// <summary>
        /// metodo que suma dos numeros decimales
        /// </summary>
        /// <param name="a">Primer numero a sumar</param>
        /// <param name="b">Segundo numero a sumar</param>
        /// <returns>Retorna la sumatoria de a y b</returns>
        public double Sumar(double a, double b)
        {
            return a + b;
        }
        /// <summary>
        /// sumatoria de tres enteros
        /// </summary>
        /// <param name="a">primer numero a sumar</param>
        /// <param name="b">segundo numero a sumar</param>
        /// <param name="c">tercer numero a sumar</param>
        /// <returns>retorna la sumatoria entre a, b y c</returns>
        public int Sumar(int a, int b, int c)
        {
            return a + b + c;
        }
        #endregion

        //sobrecarga varios metodos con el mismo nombre pero que reciben distintos parametros
    }
}
