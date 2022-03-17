using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LanchesMAC.Models;
using LanchesMAC.Repositories.Interfaces;
using LanchesMAC.ViewModels;

namespace LanchesMAC.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheRepository _lancheRepository;

        public LancheController(ILancheRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }
        public IActionResult List(string categoria)
        {
            IEnumerable<Lanche> lanches;
            string categoriaAtual = string.Empty;

            if(string.IsNullOrEmpty(categoria))
            {
                lanches = _lancheRepository.Lanches.OrderBy(l => l.LancheId);
                categoriaAtual = "Todos os lanches";
            }
            else
            {
            //    if(string.Equals("Normal", categoria, StringComparison.OrdinalIgnoreCase))
            //    {
            //        lanches = _lancheRepository.Lanches.Where(l => l.Categoria.CategoriaNome.Equals("Normal"))
            //                                           .OrderBy(l => l.Name);
            //    }
            //    else
            //    {
            //        lanches = _lancheRepository.Lanches.Where(l => l.Categoria.CategoriaNome == "Natural")
            //                                           .OrderBy(l => l.Name);
            //    }
               lanches = _lancheRepository.Lanches
                        .Where(l => l.Categoria.CategoriaNome.Equals(categoria))
                        .OrderBy(c => c.Name);
                        
               categoriaAtual = categoria;
            }

            var lanchesListViewModel = new LancheListViewModel
            {
                Lanches = lanches,
                CategoriaAtual = categoriaAtual
            };

            return View(lanchesListViewModel);
        } 
    }
} 