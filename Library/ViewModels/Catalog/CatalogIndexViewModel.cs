using Library.Models;
using LibraryData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.ViewModels.Catalog
{
    public class CatalogIndexViewModel : ViewModelBase
    {
        public IEnumerable<ILibraryAsset> Assets { get; set; }
    }
}
