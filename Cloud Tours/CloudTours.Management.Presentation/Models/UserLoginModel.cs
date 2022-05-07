using System.ComponentModel.DataAnnotations;

namespace CloudTours.Management.Presentation.Models
{
    public class UserLoginModel
    {
        [Required(ErrorMessage ="Kullamıcı adı boş olamaz")]

        public string UserName { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage ="Şifre boş olamaz")]
        public string Password { get; set; }


    }
}
