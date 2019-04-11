using Models.Entities;
using System.Data.Entity;

namespace Models.Entities_DBContext
{
    public class MovieDBContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}
