using News_App_using_.NET_MAUI.MVVM.Models;
using News_App_using_.NET_MAUI.MVVM.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News_App_using_.NET_MAUI.MVVM.ViewModels
{
    public class NewsViewModel
    {

        public List<Article> ArticleList { get; set; } = new List<Article>();

        public async Task<List<Article>> LoadNews()
        {
            var RootNews = await APIData.GetNews();
            foreach (var item in RootNews.Articles)
            {
                ArticleList.Add(item);
            }
            return ArticleList;

        }
    }
}
