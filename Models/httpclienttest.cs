using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Headers;

namespace httpclient
{
    public class httpclienttest
    {
        static HttpClient client = new HttpClient();

        public async Task<string> GetProductAsync(string path)
        {

            string Hello = null;
            client.BaseAddress = new Uri("http://139.59.248.207:5501/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            try 
            {
                HttpResponseMessage response = await client.GetAsync(path);
                if (response.IsSuccessStatusCode)
                {
                    Hello = await response.Content.ReadAsStringAsync();
                }
            }catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return Hello;
        }
    }
}
