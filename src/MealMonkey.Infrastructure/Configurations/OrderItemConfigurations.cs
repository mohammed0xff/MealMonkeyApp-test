﻿/*using MealMonkey.Domain.Entities.CartEntities;
using MealMonkey.Domain.Entities.MealEntities;
using MealMonkey.Domain.Entities.OrderEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MealMonkey.Infrastructure.Configurations
{
    internal class OrderItemConfigurations : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            // Properties
            builder.Property(orderItem => orderItem.Quantity).IsRequired();
            builder.Property(orderItem => orderItem.SupTotal).IsRequired();

            // Relationships with

            // Order
            builder.HasOne<Order>()
                .WithMany(order => order.OrderItems)
                .HasForeignKey(orderItem => orderItem.OrderId)
                .IsRequired();

            // Meal
            builder.HasOne<Meal>(orderItem => orderItem.Meal)
                .WithOne()
                .HasForeignKey<CartItem>(orderItem => orderItem.MealId)
                .IsRequired();
        }
    }
}
*/