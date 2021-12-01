using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using static Teste.Controllers.Produtos;

namespace Teste.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult laboratorio()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult SalvarListaHtmlViaAjax( string produtos)
        {
            List<Produtos> lista = JsonConvert.DeserializeObject<List<Produtos>>(produtos);
            List<Produtos> listaAdicionar = new List<Produtos>();

            foreach (Produtos itemProduto in lista)
            {
                listaAdicionar.Add(itemProduto);
            }
            return Json(listaAdicionar, JsonRequestBehavior.AllowGet);
        }
    }
}