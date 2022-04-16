using eTickets.Models.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class MovieController : Controller
    {
        private readonly AppDbContext Db;

        public MovieController(AppDbContext _Db)
        {
            Db = _Db;
        }
        public async Task< IActionResult> Index()
        {
            var AllMovies =  await Db.Movies.Include(m=>m.Cinema).ToListAsync();
            return View(AllMovies);
        }
    }
}
