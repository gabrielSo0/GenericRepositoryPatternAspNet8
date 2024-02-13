using RepositoryPatternExample.Models;
using RepositoryPatternExample.Repository;
using RepositoryPatternExample.Repository.Generic;

namespace RepositoryPatternExample.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _repository;

        public BookService(IBookRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Book>> GetBooks()
        {
            try
            {
                return await _repository.GetAll();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Book> GetBookById(int id)
        {
            try
            {
                var book = await _repository.GetById(id);

                if(book == null)
                    return null;

                return book;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task AddBook(Book book)
        {
            try
            {
                await _repository.Add(book);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task UpdateBook(Book book)
        {
            try
            {
                await _repository.Update(book);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task DeleteBook(int id)
        {
            try
            {
                var book = await GetBookById(id);

                if(book == null)
                    return;

                await _repository.Delete(book);
            }
            catch (Exception)
            {

                throw;
            }
        }
    
        public void SpecificMethod()
        {
            _repository.SpecificBookMethodRepository();
        }
    }
}
