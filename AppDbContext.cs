using ControleDeHoras.Models;
using Microsoft.EntityFrameworkCore;

namespace ControleDeHoras;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Registro>? Registros { get; set; }
}
