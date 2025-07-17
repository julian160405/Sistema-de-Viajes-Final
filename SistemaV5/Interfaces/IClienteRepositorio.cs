using sistemaDeViajesV3.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaDeViajesV3.Interfaces
{
    internal interface IClienteRepositorio
    {
        List<CLSCliente> GetAllClientes();
        void AddCliente(CLSCliente cliente);
        void DeleteCliente(int idcliente);
        void ModificarCliente(CLSCliente clienteModificado);

    }
}
