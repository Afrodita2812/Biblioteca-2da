using Biblioteca.Data;
using Bibliotecs.Data.IRepository;
using Biblioteca.Data.Models;

public class LibrosService : ILibrosService
{
    private readonly BibliotecaBDContext _context;
    private ILibrosRepository<int, Libros> _LibrosRepository;

    public LibrosService(BibliotecaBDcontext context)
    {
        _context = context;
        _LibrosRepository = new LibrosRepository<int, Libros>(_context);
    }
    
    public async Task<Libros> AddLibros(Libros libros)
    {
        await _LibrosRepository.AddAsync(libros);
        return libros;
    }

    public async Task<IEnumerable<LIbros>> GetAllLibros()
    {
        return await _LibrosRepository.GetAllAsync();
    }

    public async Task<Libros> GetProductById(int id)
    {
        throw new NotImplementedException();
    }


}