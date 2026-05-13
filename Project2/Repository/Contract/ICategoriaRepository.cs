using Project2.Models;

namespace Project2.Repository.Contract
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> ObterTodosCategorias();
    }
}
