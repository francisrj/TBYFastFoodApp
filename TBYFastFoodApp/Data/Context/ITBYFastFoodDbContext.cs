using Microsoft.EntityFrameworkCore;
using TBYFastFoodApp.Data;
using TBYFastFoodApp.Data;

namespace TBYFastFoodApp.Data.Context
{
    public interface ITBYFastFoodDbContext
    {
        public DbSet<Servicio> Servicios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
