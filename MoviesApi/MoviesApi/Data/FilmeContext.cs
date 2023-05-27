using Microsoft.EntityFrameworkCore;
using MoviesApi.Models;

namespace MoviesApi.Data
{
    public class FilmeContext : DbContext
    {
        public FilmeContext(DbContextOptions<FilmeContext> opts) : base(opts)
        {

        }

        public DbSet<Filme> Filmes { get; set; }
    }
}
