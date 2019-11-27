using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Vue2Spa.Data;
using Vue2Spa.Models;

namespace Vue2Spa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : BaseController
    {
        private ItemManager manager;

        public ItemsController(IConfiguration config) : base(config)
        {
            manager = new ItemManager(configuration);
        }

        // GET: api/Items
        [HttpGet]
        public IEnumerable<Item> Get()
        {
            return this.manager.GetAll();
        }

        //[Route("GetAllItems")]
        //[HttpGet]
        //public List<string> GetAllItems()
        //{
        //    var data = new List<string>();
        //    for(int i = 0; i <10; i++)
        //    {
        //        data.Add($"{i}");
        //    }

        //    return data;
        //}

        // GET: api/Items/5
        [HttpGet("{id}", Name = "Get")]
        public Item Get(int id)
        {
            return this.manager.GetById(id);
        }

        // POST: api/Items
        [HttpPost]
        public Item Post([FromBody] Item value)
        {
            this.manager.AddItem(value);
            return value;
        }

        // PUT: api/Items
        [HttpPut]
        public Item Put(int id, [FromBody] Item value)
        {
            this.manager.UpdateItem(value);
            return value;
        }

        // DELETE: api/Items/5
        [HttpDelete("{id}")]
        public int Delete(int id)
        {
            this.manager.DeleteItem(new Item {Id = id});
            return id;
        }

        //// DELETE: api/Items
        //[HttpDelete]
        //public List<Item> Delete([FromBody] List<Item> items)
        //{
        //    return items;
        //}
    }
}
