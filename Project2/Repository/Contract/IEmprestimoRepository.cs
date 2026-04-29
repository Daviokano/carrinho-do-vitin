using Project2.Models; 

namespace Project2.Repository.Contract
{
    public interface IEmprestimoRepository
    {
        IEnumerable<Emprestimo> ObterTodosEmprestimos();
        void cadastrar(Emprestimo emprestimo);
        void Atualizar (Emprestimo emprestimo);
        Emprestimo ObterEmprestimos(int Id); 
        void buscarIdEmp(Emprestimo emprestimo);
        void Excluir(int id);
    }
}
