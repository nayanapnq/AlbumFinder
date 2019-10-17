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
    public class UserController : Controller
    {
        // GET: User
        
        public ActionResult Details(int Id)
        {
            WebClient wc = new WebClient();
            
                string urlPosts = "https://jsonplaceholder.typicode.com/posts";
                string jsonDataPosts = wc.DownloadString(urlPosts);
                List<UserPosts> post = JsonConvert.DeserializeObject<List<UserPosts>>(jsonDataPosts);
                string urlUser = "https://jsonplaceholder.typicode.com/Users";
                string jsonDataUser = wc.DownloadString(urlUser);
            wc.Dispose();
            List<Users> user = JsonConvert.DeserializeObject<List<Users>>(jsonDataUser);
            List<UserPosts> postsOfUser = post.Where(C => C.UserId == Id).ToList();
            var userDetails = user.SingleOrDefault(C => C.Id == Id);
            var viewModel = new PostsAndUserDetails()
            {
                UserPosts = postsOfUser,
                UserDetails= userDetails
            };
            return View(viewModel);
        }
    }
}