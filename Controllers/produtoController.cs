using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using fun_com.Models;
using Microsoft.AspNetCore.Http;

namespace fun_com.Controllers
{
  public class ProdutoController : Controller
  {
    private readonly dbContext _context;

    public ProdutoController(dbContext context)
    {
      _context = context;
    }

    public IActionResult listar()
    {
      return View(_context.Produtos);
    }

    public IActionResult create()
    {
      return View();
    }

    [HttpPost]
    public IActionResult create([Bind("Nome, Tipo, Local, Valor")] Produto produtos)
    {
      try
      {
        _context.Add(produtos);
        _context.SaveChanges();
        return RedirectToAction("listar");
      }
      catch
      {
        Debug.WriteLine("catch @Controller create");
        return View();
      }
    }
  }
}
