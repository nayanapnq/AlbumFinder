using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Album.Models
{
    public class Photos
    {
        public string ThumbNailUrl { get; set; }
        public string Title { get; set; }
        public int Id { get; set; }
        public int AlbumId { get; set; }
        
    }
}