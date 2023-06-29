using System.Collections.Generic;
using TBYFastFoodApp.Data;

namespace TBYFastFoodApp.Data.Services
{
    public interface IUsuarioService
    {
        List<Usuario> ObtenerUsuarios();
        void RegistrarUsuario(Usuario usuario);
        void EliminarUsuario(int usuarioId);

        Usuario ObtenerUsuarioPorNombre(string nombre);



    }
}
