using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Vue2Spa.Models;

namespace Vue2Spa.Data
{
    public class CustomerManager
    {
        private readonly IConfiguration configuration;

        public CustomerManager(IConfiguration config)
        {
            this.configuration = config;
        }

        public List<Customer> GetAll()
        {
            using (SqlConnection connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                
            }

            return new List<Customer>();
        }
    }
}
