﻿using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Headers;

namespace httpclient
{
    
    public class httpclienttest
    {
        
        public string Hello ;
        public async Task<string> GetProductAsync(string path)
        {
             HttpClient client = new HttpClient();
            
            client.BaseAddress = new Uri("http://139.59.248.207:5502");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
             
            try 
            {
                HttpResponseMessage response =  client.GetAsync(path).Result;
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
