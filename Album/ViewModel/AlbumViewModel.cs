using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Album.Models;

namespace Album.ViewModel
{
    public class AlbumViewModel
    {
        public List<Albums> AlbumSet { get; set; }
        public List<Users> AlbumUser { get; set; }
      // public List<Photos> AlbumPhotos{ get; set; }
    }
}