using MiniProyecto.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace MiniProyecto.Controllers.api
{
    public class CommentsController : ApiController
    {
        // GET: api/Comments
        [HttpGet]
        public async Task<IEnumerable<CommentsModel>> Get(int id)
        {
            IEnumerable<CommentsModel> result = new CommentsModel[] { };

            using (var client = new HttpClient())
            {
                var list = JsonConvert.DeserializeObject<List<CommentsModel>>(await client.GetStringAsync("http://jsonplaceholder.typicode.com/comments"));
                result = list.Where(x => x.postId == id);
            }

            return result;
        }

        // POST: api/Comments
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Comments/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Comments/5
        public void Delete(int id)
        {
        }
    }
}
