using System.ComponentModel.DataAnnotations;

namespace TBYFastFoodApp.Data
{
    public class Servicio
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
     

        public ICollection<Pedido> Pedidos { get; set; }
    }
}
