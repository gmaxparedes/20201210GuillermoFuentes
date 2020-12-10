using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GuillermoFuentesWeb.Models;
using System.Net.Http;
using GuillermoFuentesWeb.Helpers;
using Newtonsoft.Json;

namespace GuillermoFuentesWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        ClientesAPI _apiC = new ClientesAPI();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            List<Clientes> clientes = new List<Clientes>();
            HttpClient Client = _apiC.Initial();
            HttpResponseMessage res = await Client.GetAsync("api/clientes");

            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                clientes = JsonConvert.DeserializeObject<List<Clientes>>(results);
            }
            return View(clientes);
        }

        //Detalle
        public async Task<IActionResult> Details(int Id)
        {
            var cliente = new Clientes();
            HttpClient client = _apiC.Initial();
            HttpResponseMessage res = await client.GetAsync($"api/clientes/{Id}");

            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                cliente = JsonConvert.DeserializeObject<Clientes>(results);
            }
            return View(cliente);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Clientes clientes)
        {
            HttpClient client = _apiC.Initial();

            //HTTP POST            
            var postask = client.PostAsJsonAsync<Clientes>("api/clientes", clientes);
            postask.Wait();

            var result = postask.Result;

            if (result.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("Id", "Llene todo los datos obligatorios");
            return View();
        }

        public async Task<IActionResult> Edit(int Id)
        {
            var cliente = new Clientes();
            HttpClient client = _apiC.Initial();
            HttpResponseMessage res = await client.GetAsync($"api/clientes/{Id}");

            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                cliente = JsonConvert.DeserializeObject<Clientes>(results);
            }
            return View(cliente);
        }
        [HttpPost]
        public IActionResult Edit(Clientes clientes)
        {
            HttpClient client = _apiC.Initial();

            //HTTP PUT
            //var postask = client.PostAsJsonAsync<Clientes>("api/clientes", clientes);
            var postask = client.PutAsJsonAsync<Clientes>("api/clientes", clientes);
            postask.Wait();

            var result = postask.Result;

            if (result.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            //ModelState.AddModelError("Id", "Llene todo los datos obligatorios");
            return View();
        }

        public async Task<IActionResult> Delete(int Id)
        {
            
            HttpClient client = _apiC.Initial();
            HttpResponseMessage res = await client.DeleteAsync($"api/clientes/{Id}");

            if (res.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return Error();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
