using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace travelproject.Models.Classes
{
    public class Contact
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Ad Soyad boş bırakılamaz")]
        [StringLength(100, ErrorMessage = "Ad Soyad en fazla 100 karakter olabilir")]
        public string NameSurname { get; set; }

        [Required(ErrorMessage = "E-posta boş bırakılamaz")]
        [EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi giriniz")]
        [StringLength(100, ErrorMessage = "E-posta adresi en fazla 100 karakter olabilir")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Konu boş bırakılamaz")]
        [StringLength(100, ErrorMessage = "Konu en fazla 100 karakter olabilir")]
        public string Topic { get; set; }

        [Required(ErrorMessage = "Mesaj boş bırakılamaz")]
        [Column(TypeName = "text")]
        public string Message { get; set; }
    }
}
