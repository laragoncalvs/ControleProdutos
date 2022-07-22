using CADASTRO_PRODUTOS.Models;
using CADASTRO_PRODUTOS.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CADASTRO_PRODUTOS.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly IProdutoRepository _produto;

        public ProdutoController(IProdutoRepository produtoRepository)
        {
            _produto = produtoRepository;
        }

        public IActionResult Index()
        {
            var produtos = _produto.Listar();
            return View(produtos);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ProdutoModel produto)
        {
            if (ModelState.IsValid)
            {
                _produto.Adicionar(produto);
                return RedirectToAction("Index");
            }
            return View();
        }


        public IActionResult Edit(int id)
        {
            ProdutoModel produto = _produto.ListarId(id);
            return View(produto);
        }

        public IActionResult Details(int id)
        {
            ProdutoModel produto = _produto.ListarId(id);
            return View(produto);
        }

        public IActionResult DeleteAction(int id)
        {
            _produto.Apagar(id);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            ProdutoModel produto = _produto.ListarId(id);
            return View(produto);
        }



    }
}
