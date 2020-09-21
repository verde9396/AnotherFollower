using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using ThisTimeLearn.Data.EF;

namespace ThisTimeLearn.Data.Configurations
{
    public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.ToTable("OrderDetail");
            builder.HasKey(x => new { x.OrderId, x.ProductId });
            builder.HasOne(w => w.Order).WithMany(w => w.OrderDetails).HasForeignKey(x => x.OrderId);
            builder.HasOne(w => w.Product).WithMany(w => w.OrderDetails).HasForeignKey(x => x.ProductId);
        }
    }
}
