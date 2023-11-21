using Core.Entities;

namespace WebPortfolio.ViewModels
{
	public class HomeViewModel
	{
        public Owner Owner { get; set; }
        public List<PortfolioItem> PortfolioItems { get; set; }

    }
}
