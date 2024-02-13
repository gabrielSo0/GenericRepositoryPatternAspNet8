using Microsoft.AspNetCore.Mvc;
using RepositoryPatternExample.Models;
using RepositoryPatternExample.Services;

namespace RepositoryPatternExample.Controllers
{
    [ApiController]
    [Route("api/v1")]
    public class BookController : ControllerBase
    {
        private readonly ILogger<BookController> _logger;
        private readonly IBookService _bookService;

        public BookController(ILogger<BookController> logger, IBookService bookService)
        {
            _logger = logger;
            _bookService = bookService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _bookService.GetBooks();

            return Ok(result);
        }

        [HttpGet("id")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _bookService.GetBookById(id);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Book book)
        {
            await _bookService.AddBook(book);

            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Put(Book book)
        {
            await _bookService.UpdateBook(book);

            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _bookService.DeleteBook(id);

            return NoContent();
        }
    }
}
