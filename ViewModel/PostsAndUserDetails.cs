using Album.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Album.ViewModel
{
    public class PostsAndUserDetails
    {
        public List<UserPosts> UserPosts  { get; set; }
        public Users UserDetails { get; set; }
    }
}