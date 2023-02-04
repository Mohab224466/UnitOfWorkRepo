using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository_pattern_with_UOW.core.Models;
using Repository_pattern_with_UOW.core.Repository;

namespace Repository_pattern_with_UOW.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBaseRepository<Book> _books;
        public BooksController(IBaseRepository<Book> book)
        {
            _books = book;
        }
        [HttpGet]
        public IActionResult GetById(int id)
        {
            return Ok(_books.GetById(id));
        }
    }
}
