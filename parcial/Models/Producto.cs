using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web;

#nullable disable

namespace parcial.Models
{
    public partial class Producto
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Producto")]
        public string NombreProducto { get; set; }
        public string Categoria { get; set; }
        public int? Precio { get; set; }
        public int? Stock { get; set; }
    }
}
