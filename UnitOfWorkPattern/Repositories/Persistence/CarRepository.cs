using Microsoft.EntityFrameworkCore;
using UnitOfWorkPattern.Context;
using UnitOfWorkPattern.Contracts.Persistence;
using UnitOfWorkPattern.Models.Entities;
using UnitOfWorkPattern.Repositories.Common;

namespace UnitOfWorkPattern.Repositories.Persistence
{
    internal class CarRepository
    (ApplicationDbContext dbContext)
        : BaseAsyncRepository<Car>(dbContext),
        ICarRepository
    {
        public async Task<IEnumerable<Car>> GetCarsAsync()
        {
            return await TableNoTracking
                .ToListAsync();
        }
    }
}
