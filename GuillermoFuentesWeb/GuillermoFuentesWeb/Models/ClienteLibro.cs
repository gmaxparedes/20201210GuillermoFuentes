using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GuillermoFuentesWeb.Models
{
    public class ClienteLibro
    {
        [Key]
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public int IdLibro { get; set; }
        public DateTime FechaEntrega { get; set; }
        public DateTime FechaRegreso { get; set; }

    }
}
