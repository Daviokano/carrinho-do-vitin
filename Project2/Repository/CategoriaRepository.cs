using MySql.Data.MySqlClient;
using System.Data;
using Project2.Models;
using Project2.Repository.Contract;

namespace Project2.Repository
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly string _conexaoMySql;

        public CategoriaRepository(IConfiguration conf)
        {
            _conexaoMySql = conf.GetConnectionString("ConexaoMySql");
        }

        public IEnumerable<Categoria> ObterTodosCategorias()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Categoria> ObterTodasCategorias()
        {
            List<Categoria> catList = new List<Categoria>();
            using (var conexao = new MySqlConnection(_conexaoMySql))
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM Categoria", conexao);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                conexao.Close();

                foreach (DataRow dr in dt.Rows)
                {
                    catList.Add(
                        new Categoria
                        {
                            Id = Convert.ToInt32(dr["Id"]),
                            Nome = (string)(dr["Nome"]),
                        });
                }
                return catList;
            }
        }
    }
}
