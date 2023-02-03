using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Пожалуйста, введи имя")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введи e-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введи номер телефона")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Пожалуйста, укажи, примешь ли ты участие")]
        public bool? WillAttend { get; set; }
    }
}
