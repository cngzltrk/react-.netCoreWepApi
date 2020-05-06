using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace wepApi.Models
{
        public class appContext : DbContext
        {
            public appContext(DbContextOptions<appContext> options)
                : base(options)
            { }
            public DbSet<User> Users { get; set; }
            public DbSet<Mesaj> Mesajs { get; set; }
        }
        public class User
        {
            public int ID { get; set; }
            public string userName { get; set; }
            public string userLastName { get; set; }
            public string email { get; set; }
            public string pass { get; set; }
            public ICollection<Mesaj> Mesajs{get;set;}
        }
         public class Mesaj
        {
            public int ID { get; set; }
            public string subject { get; set; }
            public string content { get; set; }
            public int isRead { get; set; }
            public int userID { get; set; }
        }
   
        public class userLogin
        {
            public string email { get; set; }
            public string pass { get; set; }

        }
}
