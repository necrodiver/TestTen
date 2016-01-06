using PersonalWebSiteAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PersonalWebSiteAPI.Controllers
{
    public class PersionsController : ApiController
    {

        static readonly IProductRepository repository = new ProductRepository();
        public IEnumerable<Persion> GetAllPersions()
        {
            return repository.GetAll();
        }
        [HttpPost]
        public Persion GetPersion(int id)
        {
            Persion persion = repository.Get(id);
            if (persion == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return persion;
        }

        public HttpResponseMessage PostPersion(Persion item)
        {
            item = repository.Add(item);
            var response = Request.CreateResponse<Persion>(HttpStatusCode.Created, item);
            string uri = Url.Link("DefaultApi",new { id=item.Id});
            response.Headers.Location = new Uri(uri);
            return response;
        }

        public IEnumerable<Persion> GetPersion(string Name)
        {
            return repository.GetAll().Where(p => string.Equals(p.Name, Name, StringComparison.OrdinalIgnoreCase));
        }

        public void PutProduct(int id,Persion persion)
        {
            persion.Id = id;
            if (!repository.Update(persion))
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }

        public HttpResponseMessage DeleteProduct(int id)
        {
            repository.Remove(id);
            return new HttpResponseMessage(HttpStatusCode.NoContent);
        }
    }
}
