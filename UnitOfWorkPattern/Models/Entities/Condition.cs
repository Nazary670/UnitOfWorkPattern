namespace UnitOfWorkPattern.Models.Entities
{
    public class Condition : BaseEntity/*<int>*/
    {
        public string Title_En { get; set; }
        public string? Title_Jp { get; set; }
        public string? TagName { get; set; }

        public int? ParentConditionId { get; set; }

        #region Relations
        public virtual Condition ParentCondition { get; set; }
        public virtual ICollection<Condition> ChildCondition { get; set; }

        #endregion

    }
    //The end.
}
