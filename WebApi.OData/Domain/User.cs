using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.OData.Domain
{
    public class User
    {
        public virtual int Id { get; set; }
        public string UserName { get; set; }
    }
}