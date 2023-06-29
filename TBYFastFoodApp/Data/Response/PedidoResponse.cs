namespace TBYFastFoodApp.Data.Response
{
    public class PedidoResponse
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string TipoEntrega { get; set; }
        public int IdServicio { get; set; }
        public int IdCliente { get; set; }
        public decimal Total { get; set; }
    }
}
