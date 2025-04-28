using Biblioteca.Data.Models;

namespace Biblioteca.interfaces
{
    public interface ILibrosService
    {
        Task<Libros> AddLibros(Libros libros);
        Task<IEnumerable<Libros>> GetAllLibros();
        Task<Libros> GetProductById(int id);
    }
}
