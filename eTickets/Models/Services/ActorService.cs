using eTickets.Models.Data;
using eTickets.Models.Data.Repositories;
using Microsoft.EntityFrameworkCore;


namespace eTickets.Models.Services
{
    public class ActorService :EntityBaseRepository<Actor>,IActorsService
    {

        private readonly AppDbContext _context;

        public ActorService(AppDbContext context):base(context){}
       
      
    }
}
