using LanchesMAC.Models;

namespace LanchesMAC.Repositories.Interfaces
{
    public interface IPedidoRepository
    {
       void CriarPedido(Pedido pedido);
    }
}