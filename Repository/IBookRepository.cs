using RepositoryPatternExample.Models;
using RepositoryPatternExample.Repository.Generic;

namespace RepositoryPatternExample.Repository
{
    public interface IBookRepository : IRepository<Book>
    {
        void SpecificBookMethodRepository();
    }
}
