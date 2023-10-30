using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3Bucles.Servicios
{
    /// <summary>
    /// Clase que implementa a la interfaz PiramideInterfaz
    /// 30102023 -> irm
    /// </summary>
    internal class PiramideImplementacion : PiramideInterfaz
    {
        public void mostrarPiramide()
        {
            int num = pedirNum();
            string  aux="";
            
            for (int i = 1; i <= num; i++) 
            {
                aux = aux + i;
                Console.WriteLine(aux);
            }
        }
        /// <summary>
        /// Metodo que pide al usuario el numero deseado
        /// 30102023 -> irm
        /// </summary>
        /// <returns></returns>
        private int pedirNum() 
        {
            int num;
            Console.WriteLine("Introduzca el numero deseado:");
            num=Convert.ToInt32(Console.ReadLine());

            return num;
        }
    }
}
