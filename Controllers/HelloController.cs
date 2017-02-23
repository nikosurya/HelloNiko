using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;


namespace hello.Controllers
{
    [Route("api/niko/[controller]")]
    public class HelloController : Controller
    {
        
        string address = "http://139.59.248.207:5502/api/rifki/hello";

        // GET api/values
        [HttpGet]
        public async Task< IEnumerable<string>> Get()
        {
            
          
          var hello = await  GetProductAsync(address);
          
          return new string[] { "Hello Niko Memanggil service",hello};
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        public async Task<string> GetProductAsync(string path)
        {
            HttpClient client = new HttpClient();
            string Hello = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                Hello = await response.Content.ReadAsStringAsync();
            }
            return Hello;
        }
    }
}
