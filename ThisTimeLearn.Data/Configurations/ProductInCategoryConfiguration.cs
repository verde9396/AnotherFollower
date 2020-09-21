using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using ThisTimeLearn.Data.Entities;

namespace ThisTimeLearn.Data.Configurations
{
    public class ProductInCategoryConfiguration : IEntityTypeConfiguration<ProductInCategory>
    {
        public void Configure(EntityTypeBuilder<ProductInCategory> builder)
        {
            builder.HasKey(t => new { t.CategoryId, t.ProductId });
            builder.ToTable("ProductInCategories");
            builder.HasOne(c => c.Product).WithMany(c => c.ProductInCategories)
                .HasForeignKey(c => c.ProductId);
            builder.HasOne(c => c.Category).WithMany(c => c.ProductInCategories)
               .HasForeignKey(c => c.CategoryId);
        }
    }
}
