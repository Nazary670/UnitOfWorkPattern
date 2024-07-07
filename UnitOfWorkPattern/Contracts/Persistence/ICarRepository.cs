using UnitOfWorkPattern.Models.Entities;

namespace UnitOfWorkPattern.Contracts.Persistence
{
    public interface ICarRepository
    {
        Task<IEnumerable<Car>> GetCarsAsync();

    }
    //The end.
}
