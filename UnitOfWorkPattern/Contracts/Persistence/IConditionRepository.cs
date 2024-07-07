using UnitOfWorkPattern.Models.Entities;

namespace UnitOfWorkPattern.Contracts.Persistence
{
    public interface IConditionRepository
    {
        Task<IEnumerable<Condition>> GetAllConditionsAsync();

    }
    //The end.
}
