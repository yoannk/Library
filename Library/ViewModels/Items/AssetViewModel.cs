﻿namespace Library.ViewModels.Items
{
    public class AssetViewModel
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public string AuthorOrDirector { get; set; }
        public string Type { get; set; }
        public string DeweyCallNumber { get; set; }
        public int NumberOfCopies { get; set; }
    }
}
