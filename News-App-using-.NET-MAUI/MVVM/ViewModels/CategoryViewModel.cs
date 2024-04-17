
using News_App_using_.NET_MAUI.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News_App_using_.NET_MAUI.MVVM.ViewModels
{
    public class CategoryViewModel
    {
        public ObservableCollection<Category> ListOfCategory { get; set; }
        public CategoryViewModel()
        {
            LoadCategory();
        }

        private void LoadCategory()
        {
            ListOfCategory = new ObservableCollection<Category>()
            {
                new Category { Id = 1, Name = "general" },
                new Category { Id = 2, Name = "world" },
                new Category { Id = 3, Name = "nation" },
                new Category { Id = 4, Name = "business" },
                new Category { Id = 5, Name = "technology" },
                new Category { Id = 6, Name = "entertainment" },
                new Category { Id = 7, Name = "sports" },
                new Category { Id = 8, Name = "science" },
                new Category { Id = 9, Name = "health" },
            };
        }
    }
}
