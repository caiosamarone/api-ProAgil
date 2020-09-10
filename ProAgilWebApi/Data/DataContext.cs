using Microsoft.EntityFrameworkCore;
using ProAgilWebApi.Model;

namespace ProAgilWebApi.Data
{
    public class DataContext : DbContext    
    {
        public DataContext (DbContextOptions<DataContext> options) : base (options) {} 

        public DbSet<Evento> Eventos { get; set; }
    }
}