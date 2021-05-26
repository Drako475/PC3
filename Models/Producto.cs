using System.Collections.Generic;
namespace PC3.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Foto { get; set; }
        public string Descripcion { get; set; }
        public string Precio { get; set; }
        public string Comprador { get; set; }
        public string celular { get; set; }
        public string Lugar { get; set; }
        public ICollection<Tecnologia> Tipos { get; set; }
    }
}