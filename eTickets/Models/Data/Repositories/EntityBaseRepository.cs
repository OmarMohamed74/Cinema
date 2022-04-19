using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace eTickets.Models.Data.Repositories
{
    public class EntityBaseRepository<T> : IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {

        private readonly AppDbContext _Context;
        public EntityBaseRepository(AppDbContext Context)
        {
            _Context = Context;
        }
        public async Task Create(T entity)
        {
            _Context.Set<T>().Add(entity);
           await _Context.SaveChangesAsync();
        }

        public async Task DeleteById(int Id)
        {
            var Result = await _Context.Set<T>().FirstOrDefaultAsync(n => n.Id == Id);

            EntityEntry entityEntry = _Context.Entry<T>(Result);
            entityEntry.State = EntityState.Deleted;
            await _Context.SaveChangesAsync();

        }

        public async Task<IEnumerable<T>> GetAllActors()
        {
            var Result = await _Context.Set<T>().ToListAsync();
            return Result;

        }

        public async Task<T> GetById(int Id)
        {
            var Result = await _Context.Set<T>().FirstOrDefaultAsync(n => n.Id == Id);
            return Result;
        }

        public async Task Update(int Id, T entity)
        {
            EntityEntry entityEntry =  _Context.Entry<T>(entity);
            entityEntry.State = EntityState.Modified;
            await _Context.SaveChangesAsync();


        }
    }
}
