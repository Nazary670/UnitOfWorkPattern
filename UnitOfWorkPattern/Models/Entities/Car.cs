namespace UnitOfWorkPattern.Models.Entities
{
    public class Car: BaseEntity/*<Guid>*/
    {
        public string MakerName { get; set; }
        public string ModelName { get; set; }
        public int YearOfMade { get; set; }


    }
    //The end.
}
