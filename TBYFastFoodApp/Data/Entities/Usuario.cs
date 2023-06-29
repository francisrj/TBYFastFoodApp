using System.ComponentModel.DataAnnotations;

namespace TBYFastFoodApp.Data
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Contraseña { get; set; }
        public string Privilegio { get; set; }


    }

}
