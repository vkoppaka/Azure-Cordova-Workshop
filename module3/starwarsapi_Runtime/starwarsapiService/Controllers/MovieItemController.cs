using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using Microsoft.Azure.Mobile.Server;
using starwarsapiService.DataObjects;
using starwarsapiService.Models;

namespace starwarsapiService.Controllers
{
    public class MovieItemController : TableController<MovieItem> 
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        { 
            base.Initialize(controllerContext);
            starwarsapiContext context = new starwarsapiContext();
            DomainManager = new EntityDomainManager<MovieItem>(context, Request);
        }

        // GET tables/MovieItem
        public IQueryable<MovieItem> GetAllTodoItems()
        {
            return  Query().OrderBy(movie=>movie.SortOrder);
        }

        // GET tables/MovieItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<MovieItem> GetTodoItem(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/MovieItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<MovieItem> PatchTodoItem(string id, Delta<MovieItem> patch)
        {
            return UpdateAsync(id, patch);
        }

        // POST tables/MovieItem
        public async Task<IHttpActionResult> PostTodoItem(MovieItem item)
        {
            MovieItem current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/TodoItem/48D68C86-6EA6-4C25-AA33-223FC9A27959 
        public Task DeleteTodoItem(string id) 
        {
            return DeleteAsync(id);
        }
    }
}