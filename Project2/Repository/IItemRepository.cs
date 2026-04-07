namespace Project2.Repository
{
    public interface IItemRepository
    {
        IEnumerable<Item> ObterTodosItems();
        void Cadastrar(Item item);
        void Atualizar(Item item);
        Item ObterItens(int id); 
        void Excluir(int id);
    }
}
