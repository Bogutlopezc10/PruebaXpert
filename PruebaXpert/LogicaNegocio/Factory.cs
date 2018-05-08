using PruebaXpert.ModelosNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaXpert.LogicaNegocio
{
    public class Factory: IAbstractFactory
    {
        static private Equino singletonEquino= null;
        static private Bovino singletonBovino= null;

        public virtual Equino CrearEquino()
        {
            if (singletonEquino== null)
            {
                singletonEquino= new Equino();
            }
            return singletonEquino;
        }

        public virtual Bovino CrearBovino()
        {
            if (singletonBovino== null)
            {
                singletonBovino = new Bovino();
            }
            return singletonBovino;
        }
    }
}
