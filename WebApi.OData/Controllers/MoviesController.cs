using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Objects;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.OData.Models;
using WebApi.OData.Repositories;
using WebApi.OData.Services;

namespace WebApi.OData.Controllers
{
    public class MoviesController : System.Web.Http.OData.EntitySetController<MoviePresentationModel, int>
    {
        static MovieService movieService = new MovieService(new MovieRepository());

        [Queryable]
        public override IQueryable<MoviePresentationModel> Get()
        {
            return movieService.Get();
        }
    }
}