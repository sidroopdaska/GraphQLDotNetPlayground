using GraphQLDemo.Models;
using System.Collections.Generic;

namespace GraphQLDemo.Data
{
    public interface IBookRepository
    {
        Book BookByIsbn(string isbn);
        IEnumerable<Book> AllBooks();

        Author AuthorById(int id);
        IEnumerable<Author> AllAuthors();

        Publisher PublisherById(int id);
        IEnumerable<Publisher> AllPublishers();
    }
}