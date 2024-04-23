//using BlazorApp1Tut.Shared.Services;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Text.Json.Nodes;
//using System.Threading.Tasks;

//namespace BlazorAppTut.Shared.Services
//{
//    public class ClientOperatorService
//    {
//        private readonly HttpClient _httpClient;
//        public ClientOperatorService(HttpClient httpClient)
//        {
//            _httpClient = httpClient;
//        }

//        public async Task<HttpResponseMessage> GetInstances() 
//        {
//            var result = await _httpClient.GetAsync("/api/operation");
//            return result;
//        }
//    }
//}
