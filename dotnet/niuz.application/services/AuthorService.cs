using niuz.application.entities;
using niuz.application.repositories;

namespace niuz.application.services
{
    public class AuthorService
    {
        private readonly IAuthorRepository authors;

        public AuthorService(IAuthorRepository authors)
        {
            this.authors = authors;
        }

        public void Save(string authorId, string authorName, string bankAccount)
        {
            authors.Save(new Author(authorId, authorName, bankAccount));
        }
    }
}