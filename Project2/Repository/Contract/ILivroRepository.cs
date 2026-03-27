using Project2.Models;

namespace Project2.Repository.Contract
{
    public class LivroRepository : ILivroRepository

    {
        private readonly string _conexaoMySQL;

        public LivroRepository(IConfiguration conf)
        {
            _conexaoMySQL = conf.GetConnectionString("ConexaoMySQL");
        }

        public void Atualizar(Livro livro)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Livro livro)
        {
            using (var conexao = new MySqlConnection(_conexaoMySQL))
            {
                conexao.Open();

                MySqlCommand cmd = new MySqlCommand("insert into tbLivro values(default, @NomeLivro, @ImagemLivro)", conexao);
                cmd.Parameters.Add
            }
        }

        public void Excluir(int Id)
        {
            throw new NotImplementedException();
        }

        public Livro ObterLivros(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Livro> ObterTodosLivros()
        {
            throw new NotImplementedException();
        }

     
    }
}
