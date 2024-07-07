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
        public async Task DeleteAsync(int CarId)
        {
            await UpdateAsync(X => X.Id == CarId,
                P => P.SetProperty(D => D.IsDeleted, true));
        }

        public async Task<IEnumerable<Car>> GetCarsAsync()
        {
            return await TableNoTracking
                .ToListAsync();
        }
    }
}
