using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApi.OData.Domain;

namespace WebApi.OData.EntityFramework
{
    public class Context : DbContext
    {
        public Context()
            : base()
        {

        }
        
        public Context(DbConnection connection, bool contextOwnsConnection) : base(connection, contextOwnsConnection)
        {

        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<User> Users { get; set; }


        

    }
}