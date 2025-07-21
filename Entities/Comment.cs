namespace Between_The_Covers___Backend.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public string Description { get; set; }
    }
}
