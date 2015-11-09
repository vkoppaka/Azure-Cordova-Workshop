using System;
using Microsoft.Azure.Mobile.Server;

namespace starwarsapi2Service.DataObjects
{
    public class MovieItem : EntityData
    {
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ImageUrl { get; set; }
        public int SortOrder { get; set; }
        public string Episode { get; set; }
    }
}