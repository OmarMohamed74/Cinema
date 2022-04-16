using eTickets.Models.Data;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class ActorController : Controller
    {
        private readonly AppDbContext Db;
        public ActorController(AppDbContext _Db)
        {
            Db = _Db;
        }
        public IActionResult Index()
        {
            var data = Db.Actors.ToList();
            return View(data);
        }
    }
}
