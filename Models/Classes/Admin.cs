using System.ComponentModel.DataAnnotations;

namespace travelproject.Models.Classes
{
    public class Admin
    {
        [Key]
        public int ID { get; set; }


        [Required(ErrorMessage = "Kullanıcı adı boş bırakılamaz")]
        [StringLength(50, ErrorMessage = "Kullanıcı adı en fazla 50 karakter olabilir")]
        public string User { get; set; }
        
        [Required(ErrorMessage = "Şifre boş bırakılamaz")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Şifre 6-100 karakter arasında olmalıdır")]
        public string Password { get; set; }
    
}
}