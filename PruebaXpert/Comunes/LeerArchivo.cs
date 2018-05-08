using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaXpert.Comunes
{
    public class LeerArchivo
    {
        public List<string> LeerArchivoDat(string ruta)
        {
            StreamReader Fichero = new StreamReader(ruta);
            string dato = "";
            List<string> ListaDatos = new List<string>();

            while (dato != null)
            {
                dato = Fichero.ReadLine();
                if (dato != null)
                    ListaDatos.Add(dato);
            }

            Fichero.Close();
            return ListaDatos;
        }
    }
}
