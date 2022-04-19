namespace eTickets.Models.Data.Repositories
{
    public interface IEntityBaseRepository<T> where T:class,IEntityBase,new()

    {
        Task<IEnumerable<T>> GetAllActors();

        Task<T> GetById(int Id);

        Task DeleteById(int Id);

        Task UpdateAsync(int Id, T entity);

        Task Create(T entity);

    }
}
