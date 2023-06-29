using System;
using System.Collections.Generic;
using System.Linq;
using TBYFastFoodApp.Data.Context;
using TBYFastFoodApp.Data;

namespace TBYFastFoodApp.Data.Services
{
    public class ClienteService : IClienteService
    {
        private readonly TBYFastFoodDbContext _dbContext;

        public ClienteService(TBYFastFoodDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Cliente> ObtenerClientes()
        {
            return _dbContext.Clientes.ToList();
        }

        public Cliente ObtenerCliente(int id)
        {
            return _dbContext.Clientes.FirstOrDefault(c => c.Id == id);
        }

        public void AgregarCliente(Cliente cliente)
        {
            _dbContext.Clientes.Add(cliente);
            _dbContext.SaveChanges();
        }

        public void ActualizarCliente(int id, Cliente cliente)
        {
            var clienteExistente = _dbContext.Clientes.FirstOrDefault(c => c.Id == id);

            if (clienteExistente == null)
            {
                throw new Exception("El cliente seleccionado no existe.");
            }

            clienteExistente.Nombre = cliente.Nombre;
            clienteExistente.Apellido = cliente.Apellido;
            clienteExistente.Direccion = cliente.Direccion;
            clienteExistente.Telefono = cliente.Telefono;

            _dbContext.SaveChanges();
        }

        public void EliminarCliente(int id)
        {
            var clienteExistente = _dbContext.Clientes.FirstOrDefault(c => c.Id == id);

            if (clienteExistente != null)
            {
                _dbContext.Clientes.Remove(clienteExistente);
                _dbContext.SaveChanges();
            }
        }
    }
}
