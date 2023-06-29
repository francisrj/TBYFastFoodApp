using System.Collections.Generic;
using TBYFastFoodApp.Data;

namespace TBYFastFoodApp.Data.Services
{
    public interface IClienteService
    {
        List<Cliente> ObtenerClientes();
        Cliente ObtenerCliente(int id);
        void AgregarCliente(Cliente cliente);
        void ActualizarCliente(int id, Cliente cliente);
        void EliminarCliente(int id);
    }
}
