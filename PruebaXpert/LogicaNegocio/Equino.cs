﻿using PruebaXpert.Comunes;
using PruebaXpert.ModelosNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaXpert.LogicaNegocio
{
   public  class Equino: IAnimal
    {
        public virtual void ClasificarAnimal(List<string> datos)
        {
            List<string> ListaEquinos = new List<string>();

            foreach (string indice in datos)
            {
                if (indice[0] != 'b' && indice[0] != 'B')
                {
                    ListaEquinos.Add(indice);
                }
            }
            ProcesarArchivo.CrearArchivoTxt("Equinos", ListaEquinos);
        }
    }
}
