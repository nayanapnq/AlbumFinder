using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Album.Models
{
    public class Albums
    {
        public int UserId { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public Users Users { get; set; }
        public string FirstThumbNail { get; set; }

    }
}