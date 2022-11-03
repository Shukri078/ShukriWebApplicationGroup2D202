using System.Collections.Generic;
using System.Security.Claims;

namespace ShukriWebApplication.Models
{
    public class EditUser
    {
        public EditUser()
        {
            Claims = new List<string>();
            Roles = new List<string>();
        }

        public string Id { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public  List<string> Claims { get; set; }

        public  IList<string> Roles { get; set; }
    }
}
