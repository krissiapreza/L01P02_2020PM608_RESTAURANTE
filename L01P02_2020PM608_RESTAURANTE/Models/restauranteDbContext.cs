using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.Identity.Client;
using L01P02_2020PM608_RESTAURANTE.Models;

namespace L01P02_2020PM608_RESTAURANTE.Models {
    public class restauranteDbContext : DbContext {
        public restauranteDbContext(DbContextOptions options ): base(options){
         
           
        }
        public DbSet<clientes> clientes { get; set; }
        public DbSet<pedidos> pedidos { get; set; }
        public DbSet<platos> platos { get; set; }
        public DbSet<motoristas> motoristas { get; set; }

    }
}
