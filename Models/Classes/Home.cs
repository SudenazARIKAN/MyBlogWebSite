using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace travelproject.Models.Classes
{
    public class Home
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Başlık boş bırakılamaz")]
        [StringLength(100, ErrorMessage = "Başlık en fazla 100 karakter olabilir")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Açıklama boş bırakılamaz")]
        [Column(TypeName = "text")]
        public string Explanation { get; set; }
    }
}
