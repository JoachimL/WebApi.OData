using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.OData.Domain
{
    public class Movie
    {
        public virtual int Id { get; set; }
        public virtual string Title { get; set; }
        public virtual DateTime Released { get; set; }
        public virtual ICollection<Person> Directors { get; set; }
        public virtual ICollection<Person> Actors { get; set; }
        public virtual ICollection<UserRating> Ratings { get; set; }
        public virtual Administrator AddedBy { get; set; }
        public virtual byte[] CoverImage { get; set; }
    }
}