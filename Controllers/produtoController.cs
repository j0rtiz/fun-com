using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using fun_com.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace fun_com.Controllers
{
  public class ProdutoController : Controller
  {
    private readonly Context _context;

    public ProdutoController(Context context)
    {
      _context = context;
    }

    public IActionResult Index()
    {
      return View(_context.Produtos);
    }

    public IActionResult Create()
    {
      return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create([Bind("Nome, Tipo, Local, Valor")] Produto Produtos)
    {
      try
      {
        if (ModelState.IsValid)
        {
          _context.Add(Produtos);
          _context.SaveChanges();
          return RedirectToAction("Index");
        }
      }
      catch (Exception e)
      {
        ModelState.AddModelError("", e.Message);
      }
      return View(Produtos);
    }
  }
}
