using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Album.Models
{
    public class UserPosts
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public int Id { get; set; }
        public int UserId { get; set; }
        public Users Users { get; set; }
    }
}