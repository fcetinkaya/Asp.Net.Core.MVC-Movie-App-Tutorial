using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.WebUI.Models
{
    public class CategoryRepository : IDisposable
    {
        private static List<Category> categories = null;
        static CategoryRepository()
        {
            categories = new List<Category>()
                {
                new Category() { Id=1,Name="Aksiyon Filmleri"},
                new Category() { Id=2,Name="Macera Filmleri"},
                new Category() { Id=3,Name="Korku Filmleri"},
                new Category() { Id=4,Name="Aşk Filmleri"},
                new Category() { Id=5,Name="Duygusal Filmleri"}
            };

        }

        public static List<Category> Categories
        {
            get { return categories; }
        }

        public static void AddCategory(Category category)
        {
            categories.Add(category);
        }

        public static Category GetById(int id)
        {
            return categories.FirstOrDefault(f => f.Id == id);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
