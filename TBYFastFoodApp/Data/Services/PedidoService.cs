using System.Collections.Generic;
using TBYFastFoodApp.Data.Context;
using Microsoft.EntityFrameworkCore;


namespace TBYFastFoodApp.Data.Services
{
    public class PedidoService : IPedidoService
    {
        private readonly TBYFastFoodDbContext _dbContext;

        public PedidoService(TBYFastFoodDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Pedido> ObtenerPedidos()
        {
            return _dbContext.Pedidos.Include(p => p.Cliente).Include(p => p.Servicio).ToList();
        }

        public Pedido ObtenerPedido(int pedidoId)
        {
            return _dbContext.Pedidos.Include(p => p.Cliente).Include(p => p.Servicio).FirstOrDefault(p => p.Id == pedidoId);
        }

        public void AgregarPedido(Pedido pedido)
        {
            _dbContext.Pedidos.Add(pedido);
            _dbContext.SaveChanges();
        }

        public void EliminarPedido(int pedidoId)
        {
            var pedido = _dbContext.Pedidos.FirstOrDefault(p => p.Id == pedidoId);
            if (pedido != null)
            {
                _dbContext.Pedidos.Remove(pedido);
                _dbContext.SaveChanges();
            }
        }
    }
}
