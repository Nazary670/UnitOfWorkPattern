using Microsoft.EntityFrameworkCore;
using System.Security.Principal;
using UnitOfWorkPattern.Models.Entities;

namespace UnitOfWorkPattern.Context
{
    public class ApplicationDbContext: DbContext
    {
        #region Constructor
        public ApplicationDbContext(DbContextOptions options)
        : base(options)
        {
        }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
            var entitiesAssembly = typeof(IEntity).Assembly;
            var entityTypes = entitiesAssembly.GetTypes()
                .Where(t => t.IsClass && !t.IsAbstract && typeof(IEntity).IsAssignableFrom(t))
                .ToList();

            foreach (var entityType in entityTypes)
            {
                modelBuilder.Entity(entityType);
            }

        }


    }
    //The end.
}
