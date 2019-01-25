using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.WebUI.Models
{
    public class Category : IDisposable
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
