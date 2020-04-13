using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public abstract class ViewModelBase
    {
        public ViewModelBase(string pageTitle = "")
        {
            PageTitle = pageTitle;
        }

        public string PageTitle { get; set; }
    }
}
