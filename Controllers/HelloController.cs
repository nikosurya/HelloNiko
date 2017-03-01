using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Net.Http.Headers;


namespace hello.Controllers
{
    [Route("api/niko/[controller]")]
    public class HelloController : Controller
    {
       

        // GET api/values
        [HttpGet]
        public async Task< IEnumerable<string>> Get()
        {
        
        
          string hello = "";
          HttpClient client = new HttpClient();
          HttpResponseMessage hasil = await client.GetAsync("http://172.18.0.4:5000/api/rifki/hello");
          try
          {
            hello = await hasil.Content.ReadAsStringAsync();
          
          }
          catch
          {
            hello = ""+hasil.RequestMessage + hasil.StatusCode;
          }
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
    }
}
