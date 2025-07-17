using sistemaDeViajesV3.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaDeViajesV3.Interfaces
{
    internal interface IReservasRepositorio
    {
        List<CLSReserva> GetAllReservas();
        void AddReserva(CLSReserva reserva);
    }
}
