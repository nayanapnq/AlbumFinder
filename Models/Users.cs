using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Album.Models
{
    public class Users
    {        
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public UserAddress Address { get; set; }        
    }
}