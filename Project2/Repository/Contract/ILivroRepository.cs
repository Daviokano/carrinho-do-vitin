using Project2.Models;
namespace Project2.Repository.Contract
{
    public interface ILivroRepository
    {
        IEnumerable<Livro> ObterTodosLivros();
        void Cadastrar(Livro livro);
        void Atualizar(Livro livro);
        Livro ObterLivros(int Id);
        void Excluir(int Id);
    }
  
}
