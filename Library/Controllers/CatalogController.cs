using Library.ViewModels.Catalog;
using Library.ViewModels.Items;
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
                .Select(result => new AssetModel()
                {
                    Id = result.Id,
                    ImageUrl = result.ImageUrl,
                    AuthorOrDirector = _assets.GetAuthorOrDirector(result.Id),
                    DeweyCallNumber = _assets.GetDeweyIndex(result.Id),
                    Title = result.Title,
                    Type = _assets.GetType(result.Id),
                    NumberOfCopies = result.NumberOfCopies
                });

            var viewModel = new CatalogIndexViewModel()
            {
                Assets = listingResult
            };

            return View(viewModel);
        }
    }
}
