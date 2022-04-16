using eTickets.Models.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class CinemaController : Controller
    {
        private readonly AppDbContext Db;

        public CinemaController(AppDbContext _Db)
        {
            Db = _Db;
        }
        public async Task< IActionResult> Index()
        {
            var AllCinemas = await Db.Cinemas.ToListAsync();
            return View(AllCinemas);
        }
    }
}
