using MySql.Data.MySqlClient;
using Project2.Models;

namespace Project2.Repository
{
    public class ItemRepository : IItemRepository
    {

        private readonly string _conexaoMySql;

        public ItemRepository(IConfiguration conf)
        {
            _conexaoMySql = conf.GetConnectionString("ConexaoMySql");
        }

        public void Cadastrar(Itens item)
        {
            using (var conexao = new MySqlConnection(_conexaoMySql))
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand("insert into itensEmp values(default, @codEmp, @codLivro)", conexao);

                cmd.Parameters.Add("@codEmp", MySqlDbType.VarChar).Value = item.codEmp;
                cmd.Parameters.Add("@codLivro", MySqlDbType.VarChar).Value = item.codLivro;
                cmd.ExecuteNonQuery();
                conexao.Close();
            }
        }

        public void Atualizar(Itens item)
        {
            throw new NotImplementedException();
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public Itens ObterItens(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Itens> ObterTodosItems()
        {
            throw new NotImplementedException();
        }
    }
}
