using RepositoryPatternExample.Data;
using RepositoryPatternExample.Models;
using RepositoryPatternExample.Repository.Generic;

namespace RepositoryPatternExample.Repository
{
    public class BookRepository : EfCoreRepository<Book>, IBookRepository
    {
        public BookRepository(DatabaseContext databaseContext) : base(databaseContext) {}

        public void SpecificBookMethodRepository()
        {
            Console.WriteLine("Specific method for BookRepository");
        }
    }
}
