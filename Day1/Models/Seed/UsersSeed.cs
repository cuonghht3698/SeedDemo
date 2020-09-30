using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day1.Models.Seed
{
    public static class UsersSeed
    {
        public static void SeedUser(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                   new Product
                   {
                       Id = 11282221,
                       Name = "cuaodkas"
                   }, new Product
                   {
                       Id = 11222371,
                       Name = "cuong bAAro"
                   },
                    new Product
                    {
                        Id = 1128221,
                        Name = "cuaoasfafafafafdkas"
                    }, new Product
                    {
                        Id = 11832221,
                        Name = "cuong afafafafbAAro"
                    }
               );
        }
    }
}
