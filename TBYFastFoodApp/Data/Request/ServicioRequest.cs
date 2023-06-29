using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;


namespace TBYFastFoodApp.Data.Request
{
    public class ServicioRequest
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public decimal Precio { get; set; }
       
    }
}
