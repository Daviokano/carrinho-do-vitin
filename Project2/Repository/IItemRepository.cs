using Project2.Models;
namespace Project2.Repository
{
    public interface IItemRepository
    {
        IEnumerable<Itens> ObterTodosItems();
        void Cadastrar(Itens item);
        void Atualizar(Itens item);
        Itens ObterItens(int id); 
        void Excluir(int id);
    }
}
