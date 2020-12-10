using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuillermoFuentesWeb.Models
{
    public class Libros
    {
        public int id { get; set; }
        public string book_title { get; set; }
        public string book_author { get; set; }
        public string publisher { get; set; }
        public string publisher_date { get; set; }
        public string lang { get; set; }
        public string keyword { get; set; }
        public string book_title_index { get; set; }
    }
}
