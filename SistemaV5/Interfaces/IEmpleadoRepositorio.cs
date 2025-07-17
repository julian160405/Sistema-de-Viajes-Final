using sistemaDeViajesV3.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaDeViajesV3.Interfaces
{
    internal interface IEmpleadoRepositorio
    {
        List<CLSEmpleado> GetAllEmpleados();
    }
}
