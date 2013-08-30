using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.OData.Domain
{
    public class UserRating
    {
        public virtual int Id { get; set; }
        public virtual Movie Movie{ get; set; }
        public virtual User User { get; set; }
        public virtual double Rating { get; set; }
    }
}