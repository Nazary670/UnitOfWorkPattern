using UnitOfWorkPattern.Contracts.Persistence;

namespace UnitOfWorkPattern.Contracts.Common
{
    public interface IUnitOfWork
    {
        public ICarRepository CarRepository { get; }
        public IConditionRepository conditionRepository { get; }

        #region Common
        Task CommitAsync();
        ValueTask RollBackAsync();
        #endregion
    }
}