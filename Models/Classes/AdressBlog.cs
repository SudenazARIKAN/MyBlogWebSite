using System.ComponentModel.DataAnnotations;

namespace travelproject.Models.Classes
{
    public class AdressBlog
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Başlık boş bırakılamaz")]
        [StringLength(100, ErrorMessage = "Başlık en fazla 100 karakter olabilir")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Açıklama boş bırakılamaz")]
        [StringLength(1000, ErrorMessage = "Açıklama en fazla 1000 karakter olabilir")]
        public string Explanation { get; set; }

        [Required(ErrorMessage = "Adres boş bırakılamaz")]
        [StringLength(250, ErrorMessage = "Adres en fazla 250 karakter olabilir")]
        public string Adres { get; set; }

        [Required(ErrorMessage = "Telefon numarası boş bırakılamaz")]
        [RegularExpression(@"^\+?[1-9]\d{7,14}$", 
            ErrorMessage = "Geçerli bir GSM numarası giriniz (örn: +905551112233 veya 5551112233)")]
        [StringLength(20, ErrorMessage = "Telefon numarası en fazla 20 karakter olabilir")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Konum bilgisi boş bırakılamaz")]
        [StringLength(100, ErrorMessage = "Konum en fazla 100 karakter olabilir")]
        public string Location { get; set; }
    }
}
