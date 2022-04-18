
using eTickets.Models.Services;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class ActorController : Controller
    {
        private readonly IActorsService _service;

        public ActorController(IActorsService service)
        {
            _service = service;

        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllActors();
            return View(data);
        }
    }
}
