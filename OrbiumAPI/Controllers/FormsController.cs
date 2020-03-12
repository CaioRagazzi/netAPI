using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Dapper;
using OrbiumAPI.Model;

namespace OrbiumAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FormsController : ControllerBase
    {
        private IConfiguration _config;

        public FormsController(IConfiguration configuration)
        {
            _config = configuration;
        }

        [HttpGet]
        public IEnumerable<Forms> Get()
        {
            using (SqlConnection conexao = new SqlConnection(_config.GetConnectionString("ExemplosDapper")))
            {
                return conexao.Query<Forms>("SELECT * FROM orb_forms");
            }
        }
    }
}