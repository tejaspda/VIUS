using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BusinessLib.Interface;

namespace UKChinaTravel
{
    public class HomeController : Controller
    {
        private readonly IRepository _repository;
        public HomeController(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<IActionResult> Index()
        {
            var Samples = Task.Run(()=> _repository.GetAllSample().OrderByDescending(x => x.Id));
            var result = await Samples;

            return  View(result);
        }

        public async Task<IActionResult> Login()
        {
            var Samples = Task.Run(() => _repository.GetAllSample().OrderByDescending(x => x.Id));
            var result = await Samples;

            return View(result);
        }

    }
}