using LanchesMAC.Repositories.Interfaces;
using LanchesMAC.Models;
using LanchesMAC.Context;

namespace LanchesMAC.Repositories
{   
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;
        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}