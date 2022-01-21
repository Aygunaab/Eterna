using Eterna.Data;
using Eterna.Models;
using Eterna.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eterna.Controllers
{
    public class PortfolioController : Controller
    {
        private readonly AppDbContext _context;
        public PortfolioController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            HomeVM model = new HomeVM
            {
                Portfolios = _context.Portfolios.ToList(),
                Categories = _context.Categories.ToList(),
                Clients = _context.Clients.ToList()
            };
            return View(model);
        }
        public IActionResult Details(int id)
        {
            HomeVM model = new HomeVM
            {
                Portfolios = _context.Portfolios.ToList(),
                Categories = _context.Categories.ToList()
            };

            Portfolio portfolio = _context.Portfolios.Include(p => p.portfolioImages).FirstOrDefault(p => p.Id == id);
            if (portfolio == null) return NotFound();
            
            return View(portfolio);
        }
    }
}
