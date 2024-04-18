﻿using News_App_using_.NET_MAUI.MVVM.Models;
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
            var jsonData = await httpClient.GetStringAsync("https://gnews.io/api/v4/top-headlines?&apikey=a271f1e6475c9dfd5da595309295ae1d&lang=en&country=in&topic="+newsTopic.ToLower());
            var result = JsonConvert.DeserializeObject<Root>(jsonData);
            return result;
        }  
    }
}
