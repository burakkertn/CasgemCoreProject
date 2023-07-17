using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PizzaPan.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzapan.DataAccessLayer.Concrete
{
    public class Context: IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=BURAK\\SQLEXPRESS;database= CasgemDbPizzaPan;integrated security = true");
            
        }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Testimonial> Testimonials { get; set; }

        public DbSet<Discount> discounts { get; set; }

        public DbSet<ProductImage> ProductImages { get; set; }

    }
}
