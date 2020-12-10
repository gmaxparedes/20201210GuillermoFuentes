using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace GuillermoFuentesWeb.Helpers
{
    public class LibrosAPI
    {
        public HttpClient Initial()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://www.etnassoft.com/api/v1/get/?category=libros_programacion&criteria=most_viewed");
            return client;
        }
    }
}
