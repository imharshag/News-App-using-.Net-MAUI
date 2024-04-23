using News_App_using_.NET_MAUI.MVVM.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News_App_using_.NET_MAUI.MVVM.Services
{
    public static class APIData
    {
        public static async Task<Root> GetNews(string newsTopic)
        { 
            var httpClient = new HttpClient();
            var jsonData = await httpClient.GetStringAsync("https://gnews.io/api/v4/search?q=example&apikey=7a3ff9f29c4b39ac2221c6b483c348cd&lang=en&country=in&topic=" + newsTopic.ToLower());
            var result = JsonConvert.DeserializeObject<Root>(jsonData);
            return result;
        }  
    }
}
