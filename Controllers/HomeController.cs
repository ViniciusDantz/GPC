using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GPC.Models;
using GPC.Services;

namespace GPC.Controllers
{
    public class HomeController : Controller
    {
        private readonly PlacarService _placarService;
        public HomeController(PlacarService placarService)
        {
            _placarService = placarService;
        }

        public async Task<IActionResult> Index()
        {
            var placares = await _placarService.FindAllAsync();
            //placares.where(obj => obj.Pontos);
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
