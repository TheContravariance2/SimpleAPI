using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SimpleAPI
{
   public class ValuesController : ControllerBase
    {
        // GET: api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "soap", "Sampoo" };
        }

        // GET: api/values/5
        public string Get(int id)
        {
            return "Hi There, executed successfully";
        }

        // // POST: api/values
        // public void Post([FromBody]string value)
        // {
        // }

        // // PUT: api/values/5
        // public void Put(int id, [FromBody]string value)
        // {
        // }

        // // DELETE: api/values/5
        // public void Delete(int id)
        // {
        // }
    }
}