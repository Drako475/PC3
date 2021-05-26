using System.Collections.Generic;

namespace PC3.Models
{
    public class Tecnologia
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public ICollection<Producto> Producto { get; set; }
    }
}