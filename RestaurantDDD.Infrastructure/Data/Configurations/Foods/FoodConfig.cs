using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestaurantDDD.Domain.Entities;
using RestaurantDDD.Infrastructure.Constants;

namespace RestaurantDDD.Infrastructure.Data.Configurations.Foods
{
    class FoodConfig : IEntityTypeConfiguration<Food>
    {
        public void Configure(EntityTypeBuilder<Food> builder)
        {
            // Properties:
            builder.Property(x => x.Title).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Price).HasColumnType(SqlTypes.Price).HasDefaultValue(0);
            builder.Property(x => x.Description).HasMaxLength(500).IsRequired(false);
            builder.Property(x => x.IsActive).HasDefaultValue(true);

            // Indexes:
            builder.HasIndex(x => x.Title).IsUnique();

            builder.ToTable("Foods");
        }
    }
}
