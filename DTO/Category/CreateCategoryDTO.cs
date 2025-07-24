namespace Between_The_Covers___Backend.DTO.Category
{
    public class CreateCategoryDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<int> BooksId { get; set; }= new List<int>();
    }
}
