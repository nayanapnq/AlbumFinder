using Album.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Album.ViewModel;

namespace Album.Controllers
{
    public class PhotosController : Controller
    {
        // GET: Photos
        
        public ActionResult Index(int Id)
        {
            WebClient wc = new WebClient();
            string urlPosts = "https://jsonplaceholder.typicode.com/photos";
            var jsonDataPosts = wc.DownloadString(urlPosts);
            List<Photos> photos = JsonConvert.DeserializeObject<List<Photos>>(jsonDataPosts);
            var FilteredPhotos = photos.Where(C => C.AlbumId == Id);
            return View(FilteredPhotos);
        }
    }
}