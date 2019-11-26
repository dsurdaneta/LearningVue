using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Vue2Spa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : BaseController
    {
        // GET: api/Items
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [Route("GetAllItems")]
        [HttpGet]
        public List<string> GetAllItems()
        {
            var data = new List<string>();
            for(int i = 0; i <10; i++)
            {
                data.Add($"{i}");
            }

            return data;
        }

        // GET: api/Items/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Items
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Items/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
