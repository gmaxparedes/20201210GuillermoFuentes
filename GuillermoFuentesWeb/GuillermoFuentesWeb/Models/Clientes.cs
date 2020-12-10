using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GuillermoFuentesWeb.Models
{
    public class Clientes
    {
        [Key]
        public int IdCliente { get; set; }
        [Required]
        public string NombreCliente { get; set; }
        [Required]
        public string ApellidosCliente { get; set; }
        public DateTime Nacimiento { get; set; }
        [Required]
        public string Direccion { get; set; }
        public string Telefono { get; set; }
    }
}
