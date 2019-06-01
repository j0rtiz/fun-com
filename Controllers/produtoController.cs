using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using fun_com.Models;

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
  }
}
