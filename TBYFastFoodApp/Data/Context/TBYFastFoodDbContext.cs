using Microsoft.EntityFrameworkCore;
using TBYFastFoodApp.Data;
using TBYFastFoodApp.Pages;

namespace TBYFastFoodApp.Data.Context
{
    public class TBYFastFoodDbContext : DbContext, ITBYFastFoodDbContext
    {
        private readonly IConfiguration config;

        public TBYFastFoodDbContext(IConfiguration config)
        {
            this.config = config;
        }
        public DbSet<Servicio> Servicios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var conexion = config.GetConnectionString("MySQL");
            optionsBuilder.UseMySql(conexion, ServerVersion.AutoDetect(conexion));
        }


        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
