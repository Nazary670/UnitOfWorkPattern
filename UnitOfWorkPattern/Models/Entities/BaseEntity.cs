namespace UnitOfWorkPattern.Models.Entities
{
    public interface IEntity
    {

    }

    public abstract class BaseEntity/*<TKey>*/
    {
        //public TKey Id { get; set; }

        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsDisplayToClient { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime? ModifiedDate { get; set; }

    }
    //The end.
}
