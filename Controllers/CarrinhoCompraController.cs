using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LanchesMAC.Models;
using LanchesMAC.Repositories.Interfaces;
using LanchesMAC.ViewModels;
namespace LanchesMAC.Controllers
{
    public class CarrinhoCompraController : Controller
    {
        private readonly ILancheRepository _lancheRepository;
        private readonly CarrinhoCompra _carrinhoCompra;

        public CarrinhoCompraController(ILancheRepository lancheRepository, CarrinhoCompra carrinhoCompra)
        {
            _lancheRepository = lancheRepository;
            _carrinhoCompra = carrinhoCompra;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}