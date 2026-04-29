
using MySql.Data.MySqlClient;
using Project2.Models;
using Project2.Repository.Contract;

namespace Project2.Repository
{
    public class EmprestimoRepository : IEmprestimoRepository
    {
        private readonly string _conexaoMySql; 

        public EmprestimoRepository(IConfiguration conf)
        {
            _conexaoMySql = conf.GetConnectionString("ConexaoMySql");
        }
        public void Atualizar(Emprestimo emprestimo)
        {
            throw new NotImplementedException();
        }

        public void buscarIdEmp(Emprestimo emprestimo)
        {
            using (var conexao = new MySqlConnection(_conexaoMySql))
            {
                conexao.Open();
                MySqlDataReader dr;
                MySqlCommand cmd = new MySqlCommand("SELECT codEmp FROM tbEmprestimo ORDER BY codEmp DESC limit 1", conexao);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    emprestimo.codEmp = dr[0].ToString();
                }
                conexao.Close();
            }
        }

        public void cadastrar(Emprestimo emprestimo)
        {
            using (var conexao = new MySqlConnection(_conexaoMySql))
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand("insert into tbEmprestimo values(default, @dtEmpre, @dtDev , @codUsu)", conexao);

                cmd.Parameters.Add("@dtEmpre", MySqlDbType.VarChar).Value = emprestimo.dtEmpre;
                cmd.Parameters.Add("@dtDev", MySqlDbType.VarChar).Value = emprestimo.dtDev;
                cmd.Parameters.Add("@codUsu", MySqlDbType.VarChar).Value = emprestimo.codUsu;
                cmd.ExecuteNonQuery();
                conexao.Close();
            }
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public Emprestimo ObterEmprestimos(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Emprestimo> ObterTodosEmprestimos()
        {
            throw new NotImplementedException();
        }
    }
}
