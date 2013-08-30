using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.OData.Domain
{
    public class Person
    {
        public int Id { get; set; }
        public virtual string Name { get; set; }
    }
}