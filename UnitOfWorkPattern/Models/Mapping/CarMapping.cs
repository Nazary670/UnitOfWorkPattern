using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UnitOfWorkPattern.Models.Entities;

namespace UnitOfWorkPattern.Models.Mapping
{
    public class CarMapping : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.ToTable("Cars", "Vehicle")
                .HasKey(X => X.Id);

            builder.Property(x => x.MakerName)
                .HasMaxLength(125);

            builder.Property(X => X.ModelName)
                .HasMaxLength(125);

            builder.HasQueryFilter(X => !X.IsDeleted);
        }
    }
    //The end.
}
