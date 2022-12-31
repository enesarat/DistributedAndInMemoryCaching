using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InMemoryApp.Web.Controllers
{
    public class ProductController : Controller
    {
        private IMemoryCache _memoryCache;

        public ProductController(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }

        public IActionResult Index()
        {
            // Method 1 to check the existence of the related key's variance in the memory
            if (String.IsNullOrEmpty(_memoryCache.Get<string>("Time")))
            {
                _memoryCache.Set<string>("Time", DateTime.Now.ToString());

            }

            // Method 2 to check the existence of the related key's variance in the memory  
            if (_memoryCache.TryGetValue("Time", out string timeCache))
            {
                _memoryCache.Set<string>("Time", DateTime.Now.ToString());
            }

            return View();
        }

        public IActionResult GetDataFromCache()
        {
            // To remove data from cache according to key
            //_memoryCache.Remove("Time");

            // To get data from cache or create into cache according to key
            ViewBag.time = _memoryCache.GetOrCreate<string>("Time", entry =>
            {
                return DateTime.Now.ToString();
            });

            //ViewBag.time = _memoryCache.Get<string>("Time");
            return View();
        }
    }
}
