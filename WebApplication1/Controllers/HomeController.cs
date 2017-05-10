using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc; 


namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public object MemoryCache { get; private set; }
        class Cat
        {
            // Auto-implemented properties.
            public int Age { get; set; }
            public string Name { get; set; }
            public string Date { get; set; }
        }

        [OutputCache(CacheProfile = "CacheMahsa")]
        public ActionResult Mahsa()
        {
            Cat cat = new Cat { Age = 10, Name = "Fluffy", Date = DateTime.Now.ToString() };
            ViewBag.Mahsa = cat.Date;
            return View();
        }

        public ActionResult Index()
        {
           
            return View();

            //if (System.Web.HttpContext.Current.Cache["Products"] != null)
            //    return View(System.Web.HttpContext.Current.Cache["Products"]);
            //else
            //{
            //    string products =DateTime.Now.ToString();
            //    System.Web.HttpContext.Current.Cache["Products"] = products;
            //    return View(products);
            //}


            //string data = MemoryCache.Default.Get("1") as string;
            //if (data == null)
            //{
            //    data = // actually get your data from the database here
            //    MemoryCache.Default.Add(MYCACHEKEY, data, DateTimeOffset.Now.AddHours(24));
            //}

            //ViewBag.Message = DateTime.Now.ToString();
            //ObjectCache cache = EnterpriseLibraryContainer.Current.GetInstance<ObjectCache>(
            //"CacheName");



            //object valueToSet = new Object(); // Set this to the value to add to the cache

            //// Example of an absolute expiration policy. 
            //// Item will expire in 2 minutes, regardless if it is accessed or not
            //var absoluteExpirationPolicy = new CacheItemPolicy { AbsoluteExpiration = DateTime.Now.AddMinutes(2) };

            //// Example of a sliding expiration cache item policy
            //// item will expire if not accessed for more than 2 minutes
            //var slidingExpirationPolicy = new CacheItemPolicy { SlidingExpiration = new TimeSpan(0, 0, 2, 0) };

            //// Example of a policy that defines that item will not expire. It will only be    // removed.
            //// if the cache becomes full. 
            //var notExpiringPolicy = new CacheItemPolicy();

            //// The add method will only add the item if it doesn't already exist
            //bool added = cache.Add("CacheKey", valueToSet, notExpiringPolicy);

            //// The set method will add or overwrite an item. 
            //cache.Set("CacheKey", valueToSet, notExpiringPolicy);

            //// When setting a cache item using the indexer, it will always be set to 
            //// infinite expiration
            //cache["CacheKey"] = valueToSet;

            //// The AddOrGetExisting method will try to add it if it doesn't already 
            //// exist. If it has added it, then it will return the added item
            //// else it will return the already cached item. 
            //var cachedValueOrValueToSet = cache.AddOrGetExisting("CacheKey", valueToSet,
            //    notExpiringPolicy);


            //string date1 = DateTime.Now.ToString();
            //if (ControllerContext.HttpContext.Cache["MyKey"] == null)
            //{
            //    //ControllerContext.HttpContext.Cache.Insert.Items.Add("user" ,"lkl");
            //    ControllerContext.HttpContext.Cache.Insert("MyKey", date1, null, DateTime.Now.AddHours(1), System.Web.Caching.Cache.NoSlidingExpiration);
            ////    HttpRuntime.Cache.Insert(
            ////"MyKey", date1,
            ////null,
            ////DateTime.Now.AddMinutes(1440),
            ////System.Web.Caching.Cache.NoSlidingExpiration);

            //}
            //else
            //{
            //   string s = ControllerContext.HttpContext.Cache["MyKey"].ToString();
            //}
            //return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}