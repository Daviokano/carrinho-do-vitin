using Microsoft.AspNetCore.Mvc;
using Project2.CarrinhoCompra;
using Project2.Models;
using Project2.Repository;
using Project2.Repository.Contract;
using System.Diagnostics;

namespace Project2.Controllers
{
    public class HomeController : Controller
    {
        private ILivroRepository _livroRepository;
        private CookieCarrinhoCompra _cookieCarrinhoCompra;

        private IEmprestimoRepository _emprestimoRepository;
        private IItemRepository _itemRepository;

        private readonly ILogger<HomeController> _logger;

        public HomeController( ILivroRepository livroRepository,CookieCarrinhoCompra cookieCarrinhoCompra,
                               IEmprestimoRepository emprestimoRepository,IItemRepository itemRepository)
        {
            _livroRepository = livroRepository;
            _cookieCarrinhoCompra = cookieCarrinhoCompra;
            _emprestimoRepository = emprestimoRepository;
            _itemRepository = itemRepository;
        }
}
        public IActionResult Index()
        {
            return View(_livroRepository.ObterTodosLivros());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
