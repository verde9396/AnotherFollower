using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using ThisTimeLearn.Data.Entities;

namespace ThisTimeLearn.Data.Configurations
{
    public class CartConfiguration : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.ToTable("Carts");
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Product).WithMany(x => x.Carts).HasForeignKey(x => x.ProductId);
        }

     
    }
}