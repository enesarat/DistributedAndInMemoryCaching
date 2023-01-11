using DistributedCacheRedisApp.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistributedCacheRedisApp.Web.Controllers
{
    public class ProductsController : Controller
    {
        private IDistributedCache _distributedCache;

        public ProductsController(IDistributedCache distributedCache)
        {
            _distributedCache = distributedCache;
        }
        public IActionResult Index()
        {
            // We can define options of data which wil be cached.
            DistributedCacheEntryOptions cacheEntryOptions = new DistributedCacheEntryOptions();
            // We set a absolute time for life time of cached data.
            cacheEntryOptions.AbsoluteExpiration = DateTime.Now.AddMinutes(1);



            // We can serialize and hold on cache our datas that complex type.
            var product1 = new Product
            {
                ProductId = 1,
                Name = "Kalem 1",
                Price = 10
            };

            string jsonSerializedProduct = JsonConvert.SerializeObject(product1);
            _distributedCache.SetString("kalem/1",jsonSerializedProduct,cacheEntryOptions);

            // Optional, we can convert data to byte format
            //Byte[] byteProduct = Encoding.UTF8.GetBytes(jsonSerializedProduct);
            //_distributedCache.Set("kalem/1", byteProduct, cacheEntryOptions);

            // We use SetString method to cache a string variable.
            _distributedCache.SetString("name", "EnesArat", cacheEntryOptions);
            return View();
        }

        public IActionResult ShowFromCache()
        {
            // We use GetString method to get data form cache whick saved as string.
            string name = _distributedCache.GetString("name");

            // We can deserialize any complex object from cache memory.
            string jsonSerializedProduct = _distributedCache.GetString("kalem/1");
            Product deserializedProduct= JsonConvert.DeserializeObject<Product>(jsonSerializedProduct);

            // Optional, we can convert data from byte format
            //Byte[] byteProduct = _distributedCache.Get("kalem/1");
            //string jsonProduct = Encoding.UTF8.GetString(byteProduct);

            ViewBag.name = name;
            ViewBag.complexTypeProduct = deserializedProduct;
            return View();
        }

        public IActionResult RemoveFromCache()
        {
            // We use Remove method to remove data from cache according to given key.
            _distributedCache.Remove("name");
            return View();
        }
    }
}
