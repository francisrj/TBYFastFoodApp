using System.ComponentModel.DataAnnotations;

namespace TBYFastFoodApp.Data.Request
{
    public class UsuarioRequest
    {
        [Required(ErrorMessage = "El campo Nombre de usuario es requerido.")]
        public string NombreUsuario { get; set; }

        [Required(ErrorMessage = "El campo Contraseña es requerido.")]
        public string Contrasena { get; set; }
    }
}
