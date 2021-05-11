using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using API.BO;
using API.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace API.Controllers
{
    [Route("api")]
    [ApiController]
    public class Controller : ControllerBase
    {
        [HttpGet]
        [Route("GET")]
        public string GetGlobal()
        {
            String json = "{'client':{['Id':1,'Nom':'Borget','Prénom':'Axel','Date_Creation':'2016-02-28 14:53:04']}}";
            return json;
        }

        /*[HttpGet]
        [Route("GET")]
        public string GetById()
        {
            return "GetById";
        }*/

        [HttpPut]
        [Route("PUT")]
        public string InsertGlobal([FromBody] string value)
        {
            //int id = 9;
            //string str = "{\"id\": " + id + "}";
            //var u = JsonSerializer.Deserialize<User>(str);

            value = "{'client':{['Id':1,'Nom':'Borget','Prénom':'Axel','Date_Creation':'2016-02-28 14:53:04']}}";

            List<Client> Test = JsonConvert.DeserializeObject<List<Client>>(value);
            return value; 
        }

        [HttpPost]
        [Route("POST")]
        public string UpdateGlobal([FromBody] string value)
        {
            using (var context = new ApiContext())
            {
                var clientupdate = JsonConvert.DeserializeObject<Client>(value);
                context.Clients.Attach(clientupdate);
                context.SaveChanges();
            }
            return "UpdateGlobal";
        }

        [HttpDelete]
        [Route("DELETE")]
        public string DeleteGlobal(int id)
        {
            using (var context = new ApiContext())
            {
                var clientdelete = new Client { Id = id };
                context.Clients.Attach(clientdelete);
                context.Clients.Remove(clientdelete);
                context.SaveChanges();
            }
            return "DeleteGlobal";
        }
    }
}
