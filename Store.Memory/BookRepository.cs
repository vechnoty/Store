
namespace Store.Memory
{
    public class BookRepository : IBookRepository
    {
        private readonly Book[] books = new[]
        {
            new Book(1, "First book"),
            new Book(2, "Second book"),
            new Book(3, "C Programming Language")
        };
        public Book[] GetByAllTitle(string titlePart)
        {
            return books.Where(book=>book.Title.Contains(titlePart)).ToArray();
        }
    }
}
