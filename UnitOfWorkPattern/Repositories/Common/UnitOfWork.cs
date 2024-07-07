
using UnitOfWorkPattern.Context;
using UnitOfWorkPattern.Contracts.Common;
using UnitOfWorkPattern.Contracts.Persistence;
using UnitOfWorkPattern.Repositories.Persistence;

namespace UnitOfWorkPattern.Repositories.Common
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;

        public ICarRepository CarRepository { get; }
        public IConditionRepository conditionRepository { get; }

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;

            CarRepository = new CarRepository(_db);
            conditionRepository = new ConditionRepository(_db);

        }

        

        public Task CommitAsync()
        {
            return _db.SaveChangesAsync();
        }

        public ValueTask RollBackAsync()
        {
            return _db.DisposeAsync();
        }
    }
}