using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TBYFastFoodApp.Data
{
    public class Pedido
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        [Required]
        public TipoEntrega TipoEntrega { get; set; }

        [Required]
        public decimal Total { get; set; }

        // Relación con Cliente
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        // Relación con Servicio
        public int ServicioId { get; set; }
        public Servicio Servicio { get; set; }
    }

    public enum TipoEntrega
    {
        Fisica,
        Delivery
    }
}
