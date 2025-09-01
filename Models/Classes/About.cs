using System.ComponentModel.DataAnnotations;

namespace travelproject.Models.Classes
{
    public class About
    {
        [Key]
        public int ID { get; set; }

         [Required(ErrorMessage = "Fotoğraf URL'si boş bırakılamaz")]
        [StringLength(500, ErrorMessage = "Fotoğraf URL'si en fazla 500 karakter olabilir")]
        public string PhotoUrl { get; set; }

        [Required(ErrorMessage = "Açıklama alanı boş bırakılamaz")]
        [StringLength(1000, ErrorMessage = "Açıklama en fazla 1000 karakter olabilir")]

        public string Explanation { get; set; }
    
}
}