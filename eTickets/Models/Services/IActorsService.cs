namespace eTickets.Models.Services
{
    public interface IActorsService
    {
        Task< IEnumerable<Actor>> GetAllActors();

        Actor GetById(int Id);

        void DeleteById(int Id);

        Actor Update(int Id, Actor NewActor);

        void Create(Actor actor);

        
    }
}
