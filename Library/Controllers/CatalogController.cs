using Library.Models.Catalog;
using LibraryData;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Controllers
{
    public class CatalogController : Controller
    {
        private ILibraryAsset _assets;

        public CatalogController(ILibraryAsset assets)
        {
            _assets = assets;
        }

        public IActionResult Index()
        {
            var listingResult = _assets.GetAll()
                .Select(result => new AssetIndexListingViewModel
                {
                    Id = result.Id,
                    ImageUrl = result.ImageUrl,
                    Title = result.Title,
                    AuthorOrDirector = _assets.GetAuthorOrDirector(result.Id),
                    Type = _assets.GetTitle(result.Id),
                    DeweyCallNumber = _assets.GetDeweyIndex(result.Id),
                    NumberOfCopies = result.NumberOfCopies
                });

            var viewModel = new AssetIndexViewModel()
            {
                Assets = listingResult
            };

            return View(viewModel);
        }
    }
}
