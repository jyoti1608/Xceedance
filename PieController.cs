using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using pie_backery.Models;
using pie_backery.ViewModels;

namespace pie_backery.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult List()
        {   
            PiesListViewModel piesListViewModel = new PiesListViewModel();
            piesListViewModel.Pies = _pieRepository.AllPies;

          
            piesListViewModel.CurrentCategory = "Cheese cakes";
            return View(piesListViewModel);
        }
        public IActionResult showPie(int id=1)
        {
            return View(_pieRepository.GetPieById(id));
        }
        //public IActionResult Detail(int pieId)
        //{
        //    DetailListViewModel piesListViewModel = new DetailListViewModel();
        //    piesListViewModel.Pies = _pieRepository.AllPies;

        //    foreach (var pie in piesListViewModel.Pies)
        //    {
        //        int p1 = Convert.ToInt32(pie.PieId);

        //        if (p1 == pieId)
        //        {
        //            return 
        //        }

        //    }
        //   return View(piesListViewModel);
        //}
    }
}