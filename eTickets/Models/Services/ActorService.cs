using eTickets.Models.Data;
using Microsoft.EntityFrameworkCore;


namespace eTickets.Models.Services
{
    public class ActorService : IActorsService
    {

        private readonly AppDbContext _context;

        public ActorService(AppDbContext context)
        {
            _context = context;
        }
       
        public void Create(Actor actor)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task< IEnumerable<Actor>> GetAllActors()
        {
            var AllActors = await _context.Actors.ToListAsync();
            return AllActors;
            
        }

        public Actor GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public Actor Update(int Id, Actor NewActor)
        {
            throw new NotImplementedException();
        }
    }
}
