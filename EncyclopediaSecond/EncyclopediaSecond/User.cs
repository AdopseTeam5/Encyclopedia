//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EncyclopediaSecond
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public User(int user_ID, string first_Name, string last_Name, string email, string password, bool admin)
        {
            User_ID = user_ID;
            First_Name = first_Name;
            Last_Name = last_Name;
            Email = email;
            Password = password;
            Admin = admin;
        }

        public int User_ID { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Admin { get; set; }

        
    }
   
   
    
}
