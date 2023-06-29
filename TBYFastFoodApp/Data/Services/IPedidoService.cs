using System.Collections.Generic;

namespace TBYFastFoodApp.Data.Services
{
    public interface IPedidoService
    {
        List<Pedido> ObtenerPedidos();
        Pedido ObtenerPedido(int pedidoId);
        void AgregarPedido(Pedido pedido);
        void EliminarPedido(int pedidoId);
    }
}
