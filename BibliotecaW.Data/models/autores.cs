namespace Biblioteca.Data.Models
{
    public class Autor
    {
          public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Feccha_nacimiento { get; set; } = string.Empty;
        public string Nacionalidad { get; set; } = string.Empty;

         public ICollection<LibroAutor> LibroAutors { get; set; } = new List<LibroAutor>(); 
    }
}

