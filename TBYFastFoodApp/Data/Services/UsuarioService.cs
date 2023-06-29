using TBYFastFoodApp.Data.Context;
using TBYFastFoodApp.Data.Services;
using TBYFastFoodApp.Data;

public class UsuarioService : IUsuarioService
{
    private readonly TBYFastFoodDbContext _dbContext;

    public UsuarioService(TBYFastFoodDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void RegistrarUsuario(Usuario usuario)
    {
        _dbContext.Usuarios.Add(usuario);
        _dbContext.SaveChanges();
    }

    public List<Usuario> ObtenerUsuarios()
    {
        return _dbContext.Usuarios.ToList();
    }

    public void EliminarUsuario(int id)
    {
        var usuarioExistente = _dbContext.Usuarios.FirstOrDefault(c => c.Id == id);

        if (usuarioExistente != null)
        {
            _dbContext.Usuarios.Remove(usuarioExistente);
            _dbContext.SaveChanges();
        }
    }

    public Usuario ObtenerUsuarioPorNombre(string nombre)
    {
        return _dbContext.Usuarios.FirstOrDefault(u => u.Nombre == nombre);
    }
}

