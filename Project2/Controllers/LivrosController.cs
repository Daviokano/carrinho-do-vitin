using Microsoft.AspNetCore.Mvc;
using Project2.GerenciaArquivos;
using Project2.Models;
using Project2.Repository.Contract;

namespace Project2.Controllers
{
    public class LivrosController : Controller
    {
        private ILivroRepository _livroRepository;

        public LivrosController(ILivroRepository livroRepository)
        {
            _livroRepository = livroRepository;
        }
        public IActionResult cadLivro()
        {
            return View();
        }
        [HttpPost]
        public IActionResult cadLivro(Livro livro, IFormFile file)
        {
            var Caminho = GerenciadorArquivos.CadastrarImagemProduto(file); 

            livro.imagemLivro = Caminho;

            _livroRepository.Cadastrar(livro);

            ViewBag.msg = "Cadastro realizado";
            return View();
        }
    }
}
