using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.ASPNet.Core5.API.Models.Request;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace WebAPI.ASPNet.Core5.API.Controllers
{
    [Route("api/cliente")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        [HttpPost()]
        public void Post(ClienteModel clienteModel)
        {

        }

        [HttpPut()]
        public void Put(ClienteModel clienteModel)
        {

        }

        [HttpDelete()]
        public void Delete(ClienteModel clienteModel)
        {

        }

        [HttpGet()]
        public dynamic Get([FromBody] ClienteModel clienteModel)
        {
            IDbConnection dbConnection = new SqlConnection("connection string");
            dbConnection.Open();

            Dictionary<string, object> keyValuePairs = new Dictionary<string, object>(0)
            {
                { "Nome", "teste" }
            };

            var resultado = dbConnection.Query<ClienteModel>("userProcr", keyValuePairs, commandType: CommandType.StoredProcedure);
            var resultadoUnico = dbConnection.QueryFirstOrDefault<ClienteModel>("select * from tabela where Nome = @Nome", keyValuePairs);
            dbConnection.Dispose();

            return resultado;
        }
    }
}
