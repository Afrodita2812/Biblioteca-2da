using Biblioteca.Data;
using Biblioteca.Data.IRepository;
using Biblioteca.Data.Models;
using Microsoft.EntityFrameworkCore;

public class LibrosRepository<TId, TEntity> : ILibrosRepository<TId, TEntity>
where TId : struct
where TEntity : BaseEntity<TId>
{
    internal BibliotecaBDContext _context;
    internal DbSet<TEntity> _dbSet;
    
    public LibrosRepository(BibliotecaBDcontext context)
    {
        _context = context;
        _dbSet = context.Set<TEntity>();
    }
    
    public async Task AddAsync(TEntity Libros)
    {
        await _dbSet.AddAsync(Libros);
        await _context.SaveChangesAsync();
    }

    public async Task<TEntity> FindAsync(TId id)
    {
        return await _dbSet.FindAsync(id);
    }

    public async Task<IEnumerable<TEntity>> GetAllAsync()
    {
        return await _dbSet.ToListAsync();
    }
}