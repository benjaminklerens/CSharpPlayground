using CSharpPlayground.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpPlayground.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MedicineContext(serviceProvider.GetRequiredService<DbContextOptions<MedicineContext>>())){
                if (context.Medicine.Any()) { return; }


                context.Medicine.AddRange(
                    new Medicine
                    {
                        Name = "Paracetamol",
                        DateReleased = DateTime.Parse("1970-1-1"),
                        Price = 10

                    }, 
                    new Medicine
                    {
                        Name = "Rybelsus",
                        DateReleased = DateTime.Parse("1970-1-1"),
                        Price = 40
                    },
                    new Medicine
                    {
                        Name = "Brilinta",
                        DateReleased = DateTime.Parse("1970-1-1"),
                        Price = 25
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
