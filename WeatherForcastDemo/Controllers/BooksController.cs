using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WeatherForcastDemo.DbContexts;
using WeatherForcastDemo.Entities;

namespace WeatherForcastDemo.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly BookShopDbContext _bookShopDbContext;

        public BooksController(BookShopDbContext bookShopDbContext)
        {
            _bookShopDbContext = bookShopDbContext;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetAll()
        {
            var bookRepo = _bookShopDbContext.Books;
            List<Book> all = bookRepo.AsNoTracking().ToList();
            if (all.Count > 0)
            {
                return Ok(all);
            }
            return NotFound(new List<Book>());

        }
    }
}
