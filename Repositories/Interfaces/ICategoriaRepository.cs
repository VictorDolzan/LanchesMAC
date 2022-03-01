using LanchesMAC.Models;

namespace LanchesMAC.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get;}
    }
}