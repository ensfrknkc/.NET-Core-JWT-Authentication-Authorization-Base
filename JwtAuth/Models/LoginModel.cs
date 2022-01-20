using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JwtAuth.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage ="Kullanıcı adı zorunludur")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Şifre zorunludur")]
        public string Password { get; set; }
    }
}
