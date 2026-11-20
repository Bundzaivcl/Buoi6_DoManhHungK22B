using Microsoft.EntityFrameworkCore;

public class Buoi6Context(DbContextOptions<Buoi6Context> options) : DbContext(options)
{
    public DbSet<Buoi6.Models.Product> Product { get; set; } = default!;
}
