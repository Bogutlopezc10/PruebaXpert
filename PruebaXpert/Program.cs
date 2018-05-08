using PruebaXpert.Comunes;
using PruebaXpert.LogicaNegocio;
using PruebaXpert.ModelosNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaXpert
{
    class Program
    {
        static void Main(string[] args)
        {
            LeerArchivo lectura = new LeerArchivo();
            List<string> datos=new List<string>();

            try
            {
                // Se debe cambiar la ruta del archivo y en la capa comunes -> clase ProcesarArchivo cambiar la direccion para guardar el archivo 
                datos = lectura.LeerArchivoDat("C:/Users/Camilo/Desktop/PruebaXpert/PruebaXpert/Archivos/EQUNOSBOVINOS.DAT");
            }
            catch(Exception e)
            {
                // Se trata la excepcion
                // Si la ruta no existe no genera los .txt de salida
            }

            IAbstractFactory factory = new Factory();

            factory.CrearEquino().ClasificarAnimal(datos);
            factory.CrearBovino().ClasificarAnimal(datos);

        }
    }
}
