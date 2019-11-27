using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using Vue2Spa.Models;

namespace Vue2Spa.Data
{
    public class ItemManager
    {
        private readonly IConfiguration configuration;

        public ItemManager(IConfiguration config)
        {
            configuration = config;
        }

        public Item GetById(int id)
        {
            using (SqlConnection connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                return connection.Get<Item>(id);
            }
        }
        public List<Item> GetAll()
        {
            using (SqlConnection connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                return connection.GetAll<Item>().ToList();
            }
        }

        public long AddItem(Item items)
        {
            using (SqlConnection connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                return connection.Insert(items);
            }
        }
        public void UpdateItem(Item items)
        {
            using (SqlConnection connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Update(items);
            }
        }
        public void DeleteItem(Item items)
        {
            using (SqlConnection connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Delete(items);
            }
        }
    }
}
