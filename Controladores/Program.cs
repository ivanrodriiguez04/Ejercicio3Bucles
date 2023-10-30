using Ejercicio3Bucles.Servicios;

namespace Ejercicio3Bucles.Controladores
{
    /// <summary>
    /// Clase principal de la aplicacion
    /// 30102023 -> irm
    /// </summary>
    class Program
    {
        /// <summary>
        /// Metodo principal de la aplicacion
        /// 30102023 -> irm
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Creamos los objetos
            PiramideInterfaz pI = new PiramideImplementacion();

            //Llamamos a los metodos
            pI.mostrarPiramide();
        }
    }
}