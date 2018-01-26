using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FridayLunch.Models
{
    public class UserModel
    {
        public ObjectId Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Floor { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public bool IsAdmin { get; set; }
    }
}