using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using GuillermoFuentesWeb.Helpers;
using GuillermoFuentesWeb.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace GuillermoFuentesWeb.Controllers
{
    public class LibrosController : Controller
    {
        ClientesAPI _apiC = new ClientesAPI();
        // GET: LibrosController
        public async Task<IActionResult> Index(int? Cliente)
        {
            //libros = JsonConvert.DeserializeObject<List<Libros>>("https://www.etnassoft.com/api/v1/get/?category=libros_programacion&criteria=most_viewed");
            List<Libros> libros = new List<Libros>();
            HttpClient Client = _apiC.Initial();
            HttpResponseMessage res = await Client.GetAsync("https://www.etnassoft.com/api/v1/get/?category=libros_programacion&criteria=most_viewed");

            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                libros = JsonConvert.DeserializeObject<List<Libros>>(results);
            }
            ViewBag.Cliente = Cliente;
            return View(libros);
        }

        
        public IActionResult Prestar(int Cliente, int IdLibro)
        {
            HttpClient client = _apiC.Initial();
            ClienteLibro cl = new ClienteLibro();
            cl.IdLibro = IdLibro;
            cl.IdCliente = Cliente;
            //HTTP POST            
            var postask = client.PostAsJsonAsync<ClienteLibro>("api/clienteLibros", cl);
            postask.Wait();

            var result = postask.Result;

            if (result.IsSuccessStatusCode)
            {
                return RedirectToAction("Details");
            }
            ModelState.AddModelError("Id", "Error");
            return View();
        }

        public async Task<IActionResult> Details(int Id)
        {
            List<ClienteLibro> cl = new List<ClienteLibro>();
            HttpClient client = _apiC.Initial();
            HttpResponseMessage res = await client.GetAsync($"api/clienteLibros/{Id}");

            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                cl = JsonConvert.DeserializeObject<List<ClienteLibro>>(results);
            }
            return View(cl);
        }

        //RegresarLibro
        public IActionResult RegresarLibro(int Id)
        {
            HttpClient client = _apiC.Initial();
            ClienteLibro cl = new ClienteLibro();
            cl.Id = Id;
            //HTTP PUT
            //var postask = client.PostAsJsonAsync<Clientes>("api/clientes", clientes);
            var postask = client.PutAsJsonAsync<ClienteLibro>("api/clienteLibros", cl);
            postask.Wait();

            var result = postask.Result;

            if (result.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "Home");
            }
            //ModelState.AddModelError("Id", "Llene todo los datos obligatorios");
            return View();
        }
    }
}
