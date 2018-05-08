using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaXpert.Comunes
{
    public class ProcesarArchivo
    {
        public static void CrearArchivoTxt(string nombreArchivo, List<string> datos)
        {
            // Esta ruta se cambia de acuerdo en que parte se quiere guardar los archivos
            // Los .txt de salida se estan guardando en la carpeta archivos
            string ruta = @"C:/Users/Camilo/Desktop/PruebaXpert/PruebaXpert/Archivos/" + nombreArchivo+".txt";

            if (!File.Exists(ruta) && !string.IsNullOrEmpty(ruta) && datos.Count()!=0)
            {
                // Crea el archivo y despues se escribe en el
                using (StreamWriter sw = File.CreateText(ruta))
                {
                    foreach (string dato in datos)
                    {
                        sw.WriteLine(dato);
                    }
                }
            }
        }
    }
}
