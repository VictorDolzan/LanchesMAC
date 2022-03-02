using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LanchesMAC.Models;
using LanchesMAC.Repositories.Interfaces;

namespace LanchesMAC.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheRepository _lancheRepository;
        public LancheController(ILancheRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }
        public IActionResult List()
        {
            ViewData["Titulo"] = "Todos os lanches";
            ViewData["Data"] = DateTime.Now;

            var lanche = _lancheRepository.Lanches;
            var totalLanches = lanche.Count();

            ViewBag.Total = "Total de Lanches:";
            ViewBag.TotalLanches = totalLanches;

            return View(lanche);
        }
    }
}