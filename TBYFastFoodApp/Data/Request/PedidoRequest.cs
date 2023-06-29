using System.ComponentModel.DataAnnotations;

namespace TBYFastFoodApp.Data.Request
{
    public class PedidoRequest
    {
        [Required(ErrorMessage = "El campo TipoEntrega es requerido.")]
        public string TipoEntrega { get; set; }

        [Required(ErrorMessage = "El campo IdServicio es requerido.")]
        public int IdServicio { get; set; }

        [Required(ErrorMessage = "El campo IdCliente es requerido.")]
        public int IdCliente { get; set; }
    }
}
