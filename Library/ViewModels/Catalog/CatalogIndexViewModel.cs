using Library.Models;
using Library.ViewModels.Items;
using LibraryData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.ViewModels.Catalog
{
    public class CatalogIndexViewModel : ViewModelBase
    {
        public IEnumerable<AssetViewModel> Assets { get; set; }
    }
}
