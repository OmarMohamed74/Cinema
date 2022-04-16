using eTickets.Models.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class ProducerController : Controller
    {
        private readonly AppDbContext Db;

        public ProducerController(AppDbContext _Db)
        {
            Db = _Db;
        }
        public async Task<IActionResult> Index()
        {
            var AllProducers = await Db.Producers.ToListAsync();
            return View(AllProducers);
        }
    }
}
