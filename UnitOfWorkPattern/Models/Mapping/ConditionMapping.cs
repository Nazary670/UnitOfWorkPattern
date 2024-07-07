using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UnitOfWorkPattern.Models.Entities;

namespace UnitOfWorkPattern.Models.Mapping
{
    internal class ConditionMapping : IEntityTypeConfiguration<Condition>
    {
        public void Configure(EntityTypeBuilder<Condition> builder)
        {
            builder.ToTable("Conditions", "Condition")
                .HasKey(X => X.Id);

            builder.Property(c => c.TagName)
                .HasMaxLength(15)
                .IsRequired(false);

            builder.Property(X => X.Title_En)
                .HasMaxLength(155)
                .IsRequired();

            builder.Property(X => X.Title_Jp)
                .HasMaxLength(155)
                .IsRequired(false);

            builder.HasQueryFilter(X => !X.IsDeleted);

            #region Relations
            builder.HasOne(X => X.ParentCondition)
                .WithMany(X => X.ChildCondition)
                .HasForeignKey(X => X.ParentConditionId);
            #endregion

            #region SeedData
            builder.HasData
                (
                new Condition { Id = 1, Title_En = "RUNNING STATUS", Title_Jp = null, TagName = "lbl", ParentConditionId = null, IsDisplayToClient = true, IsDeleted = false, CreatedTime = DateTime.Now },
                new Condition { Id = 2, Title_En = "IN/OUT CONDITION", Title_Jp = null, TagName = "lbl", ParentConditionId = null, IsDisplayToClient = true, IsDeleted = false, CreatedTime = DateTime.Now },
                new Condition { Id = 3, Title_En = "ACCIDENT", Title_Jp = null, TagName = "lbl", ParentConditionId = null, IsDisplayToClient = true, IsDeleted = false, CreatedTime = DateTime.Now },
                new Condition { Id = 4, Title_En = "LOADABILITY", Title_Jp = null, TagName = "lbl", ParentConditionId = null, IsDisplayToClient = true, IsDeleted = false, CreatedTime = DateTime.Now },
                new Condition { Id = 5, Title_En = "IS SELF-PROPELLED", Title_Jp = null, TagName = "lbl", ParentConditionId = 1, IsDisplayToClient = true, IsDeleted = false, CreatedTime = DateTime.Now },
                new Condition { Id = 6, Title_En = "SELF-PROPELLED", Title_Jp = null, TagName = "rdb", ParentConditionId = 5, IsDisplayToClient = true, IsDeleted = false, CreatedTime = DateTime.Now },
                new Condition { Id = 7, Title_En = "NOT SELF-PROPELLED", Title_Jp = null, TagName = "rdb", ParentConditionId = 5, IsDisplayToClient = true, IsDeleted = false, CreatedTime = DateTime.Now },
                new Condition { Id = 8, Title_En = "IS DRIVEABLE?", Title_Jp = null, TagName = "lbl", ParentConditionId = 1, IsDisplayToClient = true, IsDeleted = false, CreatedTime = DateTime.Now },
                new Condition { Id = 9, Title_En = "DRIVABLE", Title_Jp = null, TagName = "chk", ParentConditionId = 8, IsDisplayToClient = true, IsDeleted = false, CreatedTime = DateTime.Now },
                new Condition { Id = 10, Title_En = "NOT DRIVABLE", Title_Jp = null, TagName = "chk", ParentConditionId = 8, IsDisplayToClient = true, IsDeleted = false, CreatedTime = DateTime.Now },
                new Condition { Id = 11, Title_En = "ENGINE STATUS", Title_Jp = null, TagName = "chk", ParentConditionId = 1, IsDisplayToClient = true, IsDeleted = false, CreatedTime = DateTime.Now },
                new Condition { Id = 12, Title_En = "IN GOOD Condition", Title_Jp = null, TagName = "chk", ParentConditionId = 9, IsDisplayToClient = true, IsDeleted = false, CreatedTime = DateTime.Now },
                new Condition { Id = 13, Title_En = "STRANGE NOISE", Title_Jp = null, TagName = "chk", ParentConditionId = 9, IsDisplayToClient = true, IsDeleted = false, CreatedTime = DateTime.Now },
                new Condition { Id = 14, Title_En = "WHITE SMOKE", Title_Jp = null, TagName = "chk", ParentConditionId = 9, IsDisplayToClient = true, IsDeleted = false, CreatedTime = DateTime.Now },
                new Condition { Id = 15, Title_En = "ON BATTRY", Title_Jp = null, TagName = "chk", ParentConditionId = 9, IsDisplayToClient = true, IsDeleted = false, CreatedTime = DateTime.Now },
                new Condition { Id = 16, Title_En = "UNCONFIRMED", Title_Jp = null, TagName = "chk", ParentConditionId = 9, IsDisplayToClient = true, IsDeleted = false, CreatedTime = DateTime.Now },
                new Condition { Id = 17, Title_En = "TRANSMISSION", Title_Jp = null, TagName = "sl", ParentConditionId = 1, IsDisplayToClient = true, IsDeleted = false, CreatedTime = DateTime.Now },
                new Condition { Id = 18, Title_En = "IN GOOD ConditionN", Title_Jp = null, TagName = null, ParentConditionId = 17, IsDisplayToClient = true, IsDeleted = false, CreatedTime = DateTime.Now },
                new Condition { Id = 19, Title_En = "MALFUNCTION", Title_Jp = null, TagName = null, ParentConditionId = 17, IsDisplayToClient = true, IsDeleted = false, CreatedTime = DateTime.Now },
                new Condition { Id = 20, Title_En = "UNCONFIRMED", Title_Jp = null, TagName = null, ParentConditionId = 17, IsDisplayToClient = true, IsDeleted = false, CreatedTime = DateTime.Now },
                new Condition { Id = 21, Title_En = "IS CHECK LAMPS LIT", Title_Jp = null, TagName = "sl", ParentConditionId = 1, IsDisplayToClient = true, IsDeleted = false, CreatedTime = DateTime.Now },
                new Condition { Id = 22, Title_En = "YES", Title_Jp = null, TagName = null, ParentConditionId = 21, IsDisplayToClient = true, IsDeleted = false, CreatedTime = DateTime.Now },
                new Condition { Id = 23, Title_En = "NO", Title_Jp = null, TagName = null, ParentConditionId = 21, IsDisplayToClient = true, IsDeleted = false, CreatedTime = DateTime.Now },
                new Condition { Id = 24, Title_En = "UNCONFIRMED", Title_Jp = null, TagName = null, ParentConditionId = 21, IsDisplayToClient = true, IsDeleted = false, CreatedTime = DateTime.Now },
                new Condition { Id = 25, Title_En = "INTERIOR", Title_Jp = null, TagName = "lbl", ParentConditionId = 2, IsDisplayToClient = true, IsDeleted = false, CreatedTime = DateTime.Now },
                new Condition { Id = 26, Title_En = "DIRT/STAINS", Title_Jp = null, TagName = "sl", ParentConditionId = 25, IsDisplayToClient = true, IsDeleted = false, CreatedTime = DateTime.Now },
                new Condition { Id = 27, Title_En = "YES", Title_Jp = null, TagName = null, ParentConditionId = 26, IsDisplayToClient = true, IsDeleted = false, CreatedTime = DateTime.Now },
                new Condition { Id = 28, Title_En = "NO", Title_Jp = null, TagName = null, ParentConditionId = 26, IsDisplayToClient = true, IsDeleted = false, CreatedTime = DateTime.Now },
                new Condition { Id = 29, Title_En = "UNCONFIRMED", Title_Jp = null, TagName = null, ParentConditionId = 26, IsDisplayToClient = true, IsDeleted = false, CreatedTime = DateTime.Now },
                new Condition { Id = 30, Title_En = "TEARS IN SEAT", Title_Jp = null, TagName = "sl", ParentConditionId = 25, IsDisplayToClient = true, IsDeleted = false, CreatedTime = DateTime.Now },
                new Condition { Id = 31, Title_En = "YES", Title_Jp = null, TagName = null, ParentConditionId = 30, IsDisplayToClient = true, IsDeleted = false, CreatedTime = DateTime.Now },
                new Condition { Id = 32, Title_En = "NO", Title_Jp = null, TagName = null, ParentConditionId = 30, IsDisplayToClient = true, IsDeleted = false, CreatedTime = DateTime.Now },
                new Condition { Id = 33, Title_En = "UNCONFIRMED", Title_Jp = null, TagName = null, ParentConditionId = 30, IsDisplayToClient = true, IsDeleted = false, CreatedTime = DateTime.Now },
                new Condition { Id = 34, Title_En = "AIR CONDITIONING", Title_Jp = null, TagName = "sl", ParentConditionId = 25, IsDisplayToClient = true, IsDeleted = false, CreatedTime = DateTime.Now },
                new Condition { Id = 35, Title_En = "GOOD", Title_Jp = null, TagName = null, ParentConditionId = 34, IsDisplayToClient = true, IsDeleted = false, CreatedTime = DateTime.Now },
                new Condition { Id = 36, Title_En = "BAD", Title_Jp = null, TagName = null, ParentConditionId = 34, IsDisplayToClient = true, IsDeleted = false, CreatedTime = DateTime.Now },
                new Condition { Id = 37, Title_En = "NOT CONFIRMED", Title_Jp = null, TagName = null, ParentConditionId = 34, IsDisplayToClient = true, IsDeleted = false, CreatedTime = DateTime.Now },
                new Condition { Id = 38, Title_En = "EXTERIOR", Title_Jp = null, TagName = "ldl", ParentConditionId = 2, IsDisplayToClient = true, IsDeleted = false, CreatedTime = DateTime.Now },
                new Condition { Id = 39, Title_En = "SCRATCHES", Title_Jp = null, TagName = "sl", ParentConditionId = 38, IsDisplayToClient = true, IsDeleted = false, CreatedTime = DateTime.Now },
                new Condition { Id = 40, Title_En = "YES", Title_Jp = null, TagName = null, ParentConditionId = 39, IsDisplayToClient = true, IsDeleted = false, CreatedTime = DateTime.Now },
                new Condition { Id = 41, Title_En = "NO", Title_Jp = null, TagName = null, ParentConditionId = 39, IsDisplayToClient = true, IsDeleted = false, CreatedTime = DateTime.Now },
                new Condition { Id = 42, Title_En = "UNCONFIRMED", Title_Jp = null, TagName = null, ParentConditionId = 39, IsDisplayToClient = true, IsDeleted = false, CreatedTime = DateTime.Now },
                new Condition { Id = 43, Title_En = "DENT", Title_Jp = null, TagName = "sl", ParentConditionId = 38, IsDisplayToClient = true, IsDeleted = false, CreatedTime = DateTime.Now },
                new Condition { Id = 44, Title_En = "YES", Title_Jp = null, TagName = null, ParentConditionId = 43, IsDisplayToClient = true, IsDeleted = false, CreatedTime = DateTime.Now },
                new Condition { Id = 45, Title_En = "NO", Title_Jp = null, TagName = null, ParentConditionId = 43, IsDisplayToClient = true, IsDeleted = false, CreatedTime = DateTime.Now },
                new Condition { Id = 46, Title_En = "UNCONFIRMED", Title_Jp = null, TagName = null, ParentConditionId = 43, IsDisplayToClient = true, IsDeleted = false, CreatedTime = DateTime.Now },
                new Condition { Id = 47, Title_En = "PAINT PEELING", Title_Jp = null, TagName = "sl", ParentConditionId = 38, IsDisplayToClient = true, IsDeleted = false, CreatedTime = DateTime.Now },
                new Condition { Id = 48, Title_En = "YES", Title_Jp = null, TagName = null, ParentConditionId = 47, IsDisplayToClient = true, IsDeleted = false, CreatedTime = DateTime.Now },
                new Condition { Id = 49, Title_En = "NO", Title_Jp = null, TagName = null, ParentConditionId = 47, IsDisplayToClient = true, IsDeleted = false, CreatedTime = DateTime.Now },
                new Condition { Id = 50, Title_En = "UNCONFIRMED", Title_Jp = null, TagName = null, ParentConditionId = 47, IsDisplayToClient = true, IsDeleted = false, CreatedTime = DateTime.Now },
                new Condition { Id = 51, Title_En = "RUST", Title_Jp = null, TagName = "sl", ParentConditionId = 35, IsDisplayToClient = true, IsDeleted = false, CreatedTime = DateTime.Now },
                new Condition { Id = 52, Title_En = "YES", Title_Jp = null, TagName = null, ParentConditionId = 51, IsDisplayToClient = true, IsDeleted = false, CreatedTime = DateTime.Now },
                new Condition { Id = 53, Title_En = "NO", Title_Jp = null, TagName = null, ParentConditionId = 51, IsDisplayToClient = true, IsDeleted = false, CreatedTime = DateTime.Now },
                new Condition { Id = 54, Title_En = "UNCONFIRMED", Title_Jp = null, TagName = null, ParentConditionId = 51, IsDisplayToClient = true, IsDeleted = false, CreatedTime = DateTime.Now },
                new Condition { Id = 55, Title_En = "ENOUGH SPACE", Title_Jp = null, TagName = "chb", ParentConditionId = 4, IsDisplayToClient = true, IsDeleted = false, CreatedTime = DateTime.Now },
                new Condition { Id = 56, Title_En = "ONLY 2 TON TRUCKS", Title_Jp = null, TagName = "chb", ParentConditionId = 4, IsDisplayToClient = true, IsDeleted = false, CreatedTime = DateTime.Now }


                );

            #endregion
        }
        //The end.
    }
}
