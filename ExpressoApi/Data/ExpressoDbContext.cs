using ExpressoApi.Data.DbInitializers.MenuInitializers;
using ExpressoApi.Data.DbInitializers.SubMenuInitializers;
using ExpressoApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpressoApi.Data
{
    public class ExpressoDbContext : DbContext
    {
        public ExpressoDbContext(DbContextOptions<ExpressoDbContext>options):base(options)
        {

        }

        public DbSet<Menu> Menus { get; set; }
        public DbSet<SubMenu> SubMenus { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MenuInitializerConfiguration());
            modelBuilder.ApplyConfiguration(new SubMenuInitializerConfiguration());
        }

    }
}
