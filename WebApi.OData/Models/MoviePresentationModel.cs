using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.OData.Models
{
    public class MoviePresentationModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int YearOfRelease { get; set; }
        public double AverageRating { get; set; }
        public IEnumerable<string> Actors { get; set; }
     }
}