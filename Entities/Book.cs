namespace Between_The_Covers___Backend.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public List<string> Images { get; set; }
        public virtual ICollection<Category> Categories { get; set; } = new List<Category>();
        public string LinkToPDF { get; set; }
        public Guid UserID { get; set; }



    }
}
