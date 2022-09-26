using Microsoft.EntityFrameworkCore;

namespace Mari.Data;

public class MariDbContext : DbContext
{
    public MariDbContext(DbContextOptions options) : base(options)
    {
    }
}