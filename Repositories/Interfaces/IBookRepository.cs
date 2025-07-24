using Between_The_Covers___Backend.Entities;

namespace Between_The_Covers___Backend.Repositories.Interfaces
{
    public interface IBookRepository
    {
        public Book AddBook(Book book);
        public bool DeleteBook(int id);
        public Book UpdateBook(Book book, int id);
        public Book GetBook(int id);
        public List<Book> GetAllBooks();
        public List<Book> GetBooksByAuthor(string author);

    }
}
