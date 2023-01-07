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

        public IActionResult IndexWithExpiredCache()
        {
            MemoryCacheEntryOptions options1 = new MemoryCacheEntryOptions();


            // We can define absolute time for life time of cached data.
            options1.AbsoluteExpiration = DateTime.Now.AddSeconds(10);

            // We can define propert for cached data.
            options1.Priority = CacheItemPriority.High;

            // We can define callback information to understand reason of data which deleted from memory
            options1.RegisterPostEvictionCallback((key, value, reason, state)=> 
            {
                _memoryCache.Set("Callback 1",$"{key}=>{value} ----> Reason: {reason}");
            });

            _memoryCache.Set<string>("TimeWithAbsoluteExpireTime", DateTime.Now.ToString(), options1);

            return View();
        }
        public IActionResult IndexWithExpiredCache2()
        {
            MemoryCacheEntryOptions options2 = new MemoryCacheEntryOptions();


            // We can define sliding time for life time of cached data.
            options2.AbsoluteExpiration = DateTime.Now.AddSeconds(10);

            // We can define propert for cached data.
            options2.Priority = CacheItemPriority.Low;

            // We can define callback information to understand reason of data which deleted from memory
            options2.RegisterPostEvictionCallback((key, value, reason, state) =>
            {
                _memoryCache.Set("Callback 2", $"{key}=>{value} ----> Reason: {reason}");
            });

            _memoryCache.Set<string>("TimeWithSlidingExpireTime", DateTime.Now.ToString(), options2);


            return View();
        }

        public IActionResult IndexWithExpiredCache3()
        {
            MemoryCacheEntryOptions options3 = new MemoryCacheEntryOptions();


            // We can define absolute and sliding time for life time of cached data.
            options3.AbsoluteExpiration = DateTime.Now.AddSeconds(60);
            options3.SlidingExpiration = TimeSpan.FromSeconds(10);

            // We can define propert for cached data.
            options3.Priority = CacheItemPriority.Normal;

            // We can define callback information to understand reason of data which deleted from memory
            options3.RegisterPostEvictionCallback((key, value, reason, state) =>
            {
                _memoryCache.Set("Callback 3", $"{key}=>{value} ----> Reason: {reason}");
            });

            _memoryCache.Set<string>("TimeWithAbsoluteAndSlidingExpireTime", DateTime.Now.ToString(), options3);


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

            // We get cached time data which has expire property if available.
            _memoryCache.TryGetValue("TimeWithAbsoluteExpireTime", out string timeCache1);
            if (timeCache1 == null)
            {
                timeCache1 = "Time has expired!";
            }
            ViewBag.timeWithAbsoluteExpireTime = timeCache1;

            // We get cached time data which has expire property if available.
            _memoryCache.TryGetValue("TimeWithSlidingExpireTime", out string timeCache2);
            if (timeCache2 == null)
            {
                timeCache2 = "Time has expired!";
            }
            ViewBag.timeWithSlidingExpireTime = timeCache2;

            // We get cached time data which has expire property if available.
            _memoryCache.TryGetValue("TimeWithAbsoluteAndSlidingExpireTime", out string timeCache3);
            if (timeCache3 == null)
            {
                timeCache3 = "Time has expired!";
            }
            ViewBag.timeWithAbsoluteAndSlidingExpireTime = timeCache3;

            _memoryCache.TryGetValue<string>("Callback 1", out string callback1);
            _memoryCache.TryGetValue<string>("Callback 2", out string callback2);
            _memoryCache.TryGetValue<string>("Callback 3", out string callback3);

            ViewBag.callback1 = callback1;
            ViewBag.callback2 = callback2;
            ViewBag.callback3 = callback3;


            //ViewBag.time = _memoryCache.Get<string>("Time");
            return View();
        }

    }
}
