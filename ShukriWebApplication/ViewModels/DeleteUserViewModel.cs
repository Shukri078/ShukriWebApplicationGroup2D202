using System.ComponentModel.DataAnnotations;

namespace ShukriWebApplication.ViewModels
{
    public class DeleteUserViewModel
    {
        public string Id { get; set; }

        [Required]
        public string UserName { get; set; }

        public string Email { get; set; }

    }
}
