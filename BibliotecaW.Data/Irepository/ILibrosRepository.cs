using Biblioteca.Data;
using Biblioteca.Data.Models;


namespace Biblioteca.Data.IRepository;

public interface ILibrosRepository<TId, TEntity>
where TId: struct
where TEntity : BaseEntity<TId>
{
    Task AddAsync(TEntity Libros);
    Task<TEntity> FindAsync(TId id);
    Task<IEnumerable<TEntity>> GetAllAsync();
}