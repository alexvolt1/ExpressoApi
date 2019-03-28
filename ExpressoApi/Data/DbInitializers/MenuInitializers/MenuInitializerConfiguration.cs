using ExpressoApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpressoApi.Data.DbInitializers.MenuInitializers
{
    public class MenuInitializerConfiguration : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder.Property(e => e.Id).IsRequired();

            var menus = new Menu[]
{
                new Menu { Id = 1, Name = "Coffee", Image = "https://i.imgur.com/32myl6t.jpg" },
                new Menu { Id = 2, Name = "Tea", Image = "https://i.imgur.com/BbJvKUl.jpg" },
                new Menu { Id = 3, Name = "Cold Drinks", Image = "https://i.imgur.com/Rfvwsti.jpg" }

};
            builder.HasData(menus);
        }

    }
}
