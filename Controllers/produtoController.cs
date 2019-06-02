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

    [HttpGet]
    public IActionResult Index()
    {
      return View(_context.Produtos);
    }

    public IActionResult Create()
    {
      return View();
    }

    [HttpPost]
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
      return View();
    }

    [HttpGet]
    public IActionResult Delete(int? Id)
    {
      if (Id == null)
      {
        return NotFound();
      }

      var produto = _context.Produtos.AsNoTracking().FirstOrDefault(p => p.Id == Id);

      if (produto == null)
      {
        return NotFound();
      }

      return View(produto);
    }

    [HttpPost]
    public IActionResult Delete(int Id)
    {
      var produto = _context.Produtos.Find(Id);

      if (produto == null)
      {
        return RedirectToAction("Index");
      }

      try
      {
        _context.Produtos.Remove(produto);
        _context.SaveChanges();
        return RedirectToAction("Index");
      }
      catch (Exception e)
      {
        ModelState.AddModelError("", e.Message);
      }
      return View();
    }
  }
}
