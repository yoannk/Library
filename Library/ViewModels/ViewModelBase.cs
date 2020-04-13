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
