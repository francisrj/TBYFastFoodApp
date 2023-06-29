using System.ComponentModel.DataAnnotations;

namespace TBYFastFoodApp.Data.Request
{
    public class ClienteRequest
    {
        [Required(ErrorMessage = "El campo Nombre es requerido.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El campo Apellido es requerido.")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "El campo Dirección es requerido.")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "El campo Teléfono es requerido.")]
        public string Telefono { get; set; }
    }
}
