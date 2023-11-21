using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using WebPortfolio.ViewModels;

namespace WebPortfolio.Controllers
{
    public class HomeController : Controller
    {
		private readonly IWebHostEnvironment _webHostEnvironment;
		private readonly IUnitOfWork<Owner> _owner;
		private readonly IUnitOfWork<PortfolioItem> _portfolio;


		public HomeController(IWebHostEnvironment webHostEnvironment, IUnitOfWork<Owner> owner , IUnitOfWork<PortfolioItem> portfolio)
        {
			_webHostEnvironment = webHostEnvironment;
			_owner = owner;   
            _portfolio = portfolio;
        }
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                Owner =_owner.Entity.GetAll().First(),
                PortfolioItems = _portfolio.Entity.GetAll().ToList()
            };
            
            return View(homeViewModel);
        }

		public IActionResult DownloadCV()
		{
			var filePath = Path.Combine(_webHostEnvironment.WebRootPath, "files", "ShathaHroub_CV.pdf");
			var contentType = "application/pdf";
			var filename = "ShathaHroub_CV.pdf";

			var fileBytes = System.IO.File.ReadAllBytes(filePath);
			return File(fileBytes, contentType, filename);
		}


	}
}
