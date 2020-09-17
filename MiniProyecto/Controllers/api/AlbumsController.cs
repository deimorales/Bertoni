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
    public class AlbumsController : ApiController
    {
        // GET: api/Albums
        [HttpGet]
        public async Task<IEnumerable<AlbumModel>> Get()
        {
            var result = new List<AlbumModel>();

            using (var client = new HttpClient())
            {
                result =  JsonConvert.DeserializeObject<List<AlbumModel>>(await client.GetStringAsync("http://jsonplaceholder.typicode.com/Albums"));
            }

            return result;
        }

        // GET: api/Albums/5
        [HttpGet]
        public async Task<IEnumerable<PhotosModel>> Get(int id)
        {
            IEnumerable<PhotosModel> result = new PhotosModel[] { };

            using (var client = new HttpClient())
            {
                var list = JsonConvert.DeserializeObject<List<PhotosModel>>(await client.GetStringAsync("http://jsonplaceholder.typicode.com/photos"));
                result = list.Where(x => x.albumId == id);
            }

            return result;
        }

        // POST: api/Albums
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Albums/5
        [HttpPut]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Albums/5
        [HttpDelete]
        public void Delete(int id)
        {
        }
    }
}
