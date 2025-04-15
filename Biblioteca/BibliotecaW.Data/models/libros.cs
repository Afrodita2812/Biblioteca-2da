namespace Biblioteca.Data.Models
{
    public class Libros
    {
        public int Id { get; set; }
        public string titulo { get; set; } = string.Empty;
        public string fecha_Lanzamiento { get; set; } = string.Empty;

      
        public int AutorId { get; set; }

     
        public Autor Autor { get; set; } = null!;
    }
}
