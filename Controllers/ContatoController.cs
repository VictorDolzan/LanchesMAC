using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LanchesMAC.Models;
using LanchesMAC.Repositories.Interfaces;
using LanchesMAC.ViewModels;

namespace LanchesMAC.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}