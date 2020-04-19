using System.Collections.Generic;

namespace Library.ViewModels.Catalog
{
    public class CatalogIndexViewModel : ViewModelBase
    {
        public IEnumerable<AssetModel> Assets { get; set; }
    }
}
