using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;
using Album.Models;
using Newtonsoft.Json;
using Album.ViewModel;

namespace Album.Controllers
{
    public class AlbumController : Controller
    {
        //Getting Data 
        public ActionResult Albums()
        {
            WebClient wc = new WebClient();
            string urlAlbums = "https://jsonplaceholder.typicode.com/albums";
            string jsonDataAlbums = wc.DownloadString(urlAlbums);
            List<Albums> AlbumRecords = JsonConvert.DeserializeObject<List<Albums>>(jsonDataAlbums);
            string urlUsers = "https://jsonplaceholder.typicode.com/users";
            string jsonDataUsers = wc.DownloadString(urlUsers);
            List<Users> userDetails = JsonConvert.DeserializeObject<List<Users>>(jsonDataUsers);
            string urlPhotos = "https://jsonplaceholder.typicode.com/photos";
            string jsonDataPhotos = wc.DownloadString(urlPhotos);
            List<Photos> photos = JsonConvert.DeserializeObject<List<Photos>>(jsonDataPhotos);
            wc.Dispose();
            
                foreach (var record in AlbumRecords)
                {
                    record.Users = userDetails.FirstOrDefault(c => c.Id == record.UserId);
                    record.FirstThumbNail = photos.First(C => C.AlbumId == record.Id).ThumbNailUrl;
                }

                var viewModel = new AlbumViewModel()
                {
                    AlbumUser = userDetails,
                    AlbumSet = AlbumRecords

                };
                return View(viewModel);
         
        }


    }
}