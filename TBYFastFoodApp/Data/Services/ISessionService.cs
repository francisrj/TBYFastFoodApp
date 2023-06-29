using System.Collections.Generic;
using TBYFastFoodApp.Data;

public interface ISessionService
{
    bool IsAuthenticated { get; }
    Usuario AuthenticatedUser { get; }

    bool Login(string nombreUsuario, string contraseña);
    void Logout();
    Usuario ObtenerUsuarioAutenticado();
}
