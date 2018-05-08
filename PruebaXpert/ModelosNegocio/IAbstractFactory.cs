using PruebaXpert.LogicaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaXpert.ModelosNegocio
{
    public interface IAbstractFactory
    {
        Equino CrearEquino();
        Bovino CrearBovino();
        
    }
}
