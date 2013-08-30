using StackExchange.Profiling;
using StackExchange.Profiling.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebApi.OData.EntityFramework;

namespace WebApi.OData.Repositories
{
    public class MovieRepository
    {
        static Context context = new Context();

        internal IQueryable<Domain.Movie> GetAll()
        {
            return context.Movies;
        }
    }
}