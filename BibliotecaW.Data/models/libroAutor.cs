namespace Biblioteca.Data.Models
{
    public class LibroAutor
    {
        public int LibroId { get; set; } 
        public Libros Libro { get; set; }  
    
        public int AutorId { get; set; }
        public Autor Autor { get; set; }
    }
}
