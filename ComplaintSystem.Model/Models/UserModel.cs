﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplaintSystem.Model.Models
{
    public class UserModel
    {
        public int Id { get; set; } 
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }    
        public string Role { get; set; }
       
    }
}