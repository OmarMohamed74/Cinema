
using eTickets.Models;
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

        //Get:Actor/create/
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Create([Bind("FullName,ProfilePictureURL,Bio")]Actor actor)
        {

            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            _service.Create(actor);
            return RedirectToAction("index");
        }

        //Get:actor/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var ActroDetails = await _service.GetById(id);
            if (ActroDetails == null) return View("NotFound");
            return View(ActroDetails);
        }

        //Get:
        public async Task< IActionResult> Edit(int id)
        {

            var ActroDetails = await _service.GetById(id);
            if (ActroDetails == null) return View("NotFound");
            return View(ActroDetails);
        }

        [HttpPost]

        public async Task<IActionResult> Edit(int id, Actor actor)
        {

            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            await _service.UpdateAsync(id, actor);
            return RedirectToAction("index");
        }
    }
}
