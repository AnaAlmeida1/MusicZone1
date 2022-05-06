using Microsoft.AspNetCore.Mvc;
using MusicZone1.Models;

namespace MusicZone1.Controllers
{
    public class BandasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult NovaBanda()
        {
            return View();//isso mostra a view com o formulário por preencher
        }

        [HttpPost] 
        public IActionResult NovaBanda (Banda banda)   
        {
          return View("BandaConfirmada", banda);//aqui envia o objeto banda criado
        }
    }
}
