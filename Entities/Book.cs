namespace Between_The_Covers___Backend.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public List<string> Images { get; set; }
        public ICollection<Category> Categories { get; set; }

    }
}
