using Microsoft.EntityFrameworkCore;
using CSharpPlayground.Models;

namespace CSharpPlayground.Data
{
    public class MedicineContext : DbContext
    {
        public MedicineContext(DbContextOptions<MedicineContext> options)
            : base(options)
        {
        }

        public DbSet<Medicine> Medicine { get; set; }
    }
}