﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Dtos
{
    //DTO = Data Transformation Object
   public class UserForLoginDto:IDto
    {
        
        public string Password { get; set; }
    }
   public class UserForLoginWithUsernameDto : UserForLoginDto
   {
       public string Username { get; set; }
   }
    public class UserForLoginWithEmailDto : UserForLoginDto
   {
       public string Email { get; set; }
    }
}
