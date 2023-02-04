using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository_pattern_with_UOW.core.Models;
using Repository_pattern_with_UOW.core.Repository;

namespace Repository_pattern_with_UOW.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IBaseRepository<Author> _authors;
        public AuthorsController(IBaseRepository<Author> authors)
        {
            _authors = authors; 
        }
        [HttpGet]   
        public IActionResult GetById(int id)
        {
            return Ok(_authors.GetById(id));
        }

    }
}
