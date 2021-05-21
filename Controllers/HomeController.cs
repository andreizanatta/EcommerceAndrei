using EcommerceAndrei2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceAndrei2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Produto> Produtos = new List<Produto>();
            Produto p = new Produto("Wacom Bamboo Tablet", 100.99, "https://cdnx.jumpseller.com/bootstrap/image/429444/resize/255/320?1614272621");
            Produtos.Add(p);
            Produto p1 = new Produto("Smartphone MTK6572", 500.99, "https://cdnx.jumpseller.com/bootstrap/image/429445/resize/255/320?1439529548");
            Produtos.Add(p1);
            Produto p2 = new Produto("iMac Desktop Computer", 1.200, "https://cdnx.jumpseller.com/bootstrap/image/429446/resize/255/320?1439529839");
            Produtos.Add(p2);
            Produto p3 = new Produto("DualShock Controller for PlayStation 4", 11.200, "https://cdnx.jumpseller.com/bootstrap/image/429450/resize/255/320?1439530709");
            Produtos.Add(p3);
            Produto p4 = new Produto("Camara Nikon Reflex D7200 + Lente 18-140", 541.200, "https://cdnx.jumpseller.com/bootstrap/image/6221140/resize/255/320?1564681025");
            Produtos.Add(p4);
            Produto p5 = new Produto("Notebook Asus X507UA Intel Core i3 4GB RAM", 16.200, "https://cdnx.jumpseller.com/bootstrap/image/6221126/resize/255/320?1564681003");
            Produtos.Add(p5);
            Produto p6 = new Produto("Out of stock", 11.200, "https://cdnx.jumpseller.com/bootstrap/image/429451/resize/255/320?1439530880");
            Produtos.Add(p6);
            Produto p7 = new Produto("Asus Transformer Pad Tablet", 541.200, "https://cdnx.jumpseller.com/bootstrap/image/429448/resize/255/320?1439530289");
            Produtos.Add(p7);
            ViewBag.Produtos = Produtos;
            return View();
        }

        public JsonResult AdicionarProdutoCesta(string Nome, string Preco)
        {
            return Json(new { Titulo = "Sucesso", Texto = "Produto adicionado na cesta.", Tempo = 4000, css = "success", Sucesso = true });
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Cesta()
        {
            return View();
        }

        public IActionResult FinalizarCompra()
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
