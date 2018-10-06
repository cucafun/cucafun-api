using Microsoft.EntityFrameworkCore;
using CucaFunApi.Models;

namespace CucaFunApi.Models
{
    public class CucafunContext : DbContext
    {
        public CucafunContext(DbContextOptions<CucafunContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}