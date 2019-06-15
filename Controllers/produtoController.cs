using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using fun_com.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;

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
      var apiProdutos = new List<Produto>();
      var api = new WebClient();
      var url = "http://localhost:3000/api/Produtos";

      try
      {
        var res = api.DownloadString(url);
        JsonConvert.PopulateObject(res, apiProdutos);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }

      var produtos = _context.Produtos;

      foreach (var produto in produtos)
      {
        foreach (var apiProduto in apiProdutos)
        {
          if (produto.Nome == apiProduto.Nome)
          {
            if (apiProduto.Valor < produto.Valor)
            {
              produto.Valor = (90 * apiProduto.Valor) / 100;
              produto.Promo = true;
            }
          }
        }
      }

      return View(produtos);
    }

    public IActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public IActionResult Create([Bind("Nome, Tipo, Local, Valor")] Produto produto)
    {
      try
      {
        if (ModelState.IsValid)
        {
          _context.Add(produto);
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

    [HttpGet]
    public IActionResult Update(int? Id)
    {
      if (Id == null)
      {
        return NotFound();
      }

      var produto = _context.Produtos.Find(Id);

      if (produto == null)
      {
        return NotFound();
      }

      return View(produto);
    }

    [HttpPost]
    public IActionResult Update(int Id, [Bind("Id, Nome, Tipo, Local, Valor")] Produto produto)
    {
      if (Id != produto.Id)
      {
        return NotFound();
      }

      if (ModelState.IsValid)
      {
        try
        {
          _context.Update(produto);
          _context.SaveChanges();
          return RedirectToAction("Index");
        }
        catch (Exception e)
        {
          ModelState.AddModelError("", e.Message);
        }
      }
      return View();
    }
  }
}
