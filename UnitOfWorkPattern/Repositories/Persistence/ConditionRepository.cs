using Microsoft.EntityFrameworkCore;
using UnitOfWorkPattern.Context;
using UnitOfWorkPattern.Contracts.Persistence;
using UnitOfWorkPattern.Models.Entities;
using UnitOfWorkPattern.Repositories.Common;

namespace UnitOfWorkPattern.Repositories.Persistence
{
    internal class ConditionRepository
        (ApplicationDbContext dbContext)
        : BaseAsyncRepository<Condition>(dbContext)
        , IConditionRepository
    {
        public async Task<IEnumerable<Condition>> GetAllConditionsAsync()
        {
            return await TableNoTracking
                .AsSplitQuery()
                .ToListAsync();
        }
    }
    //The end.
}
