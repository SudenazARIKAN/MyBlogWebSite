using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace travelproject.Models.Classes
{
    public class MyBlog
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Başlık boş bırakılamaz")]
        [StringLength(100, ErrorMessage = "Başlık en fazla 100 karakter olabilir")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Tarih alanı boş bırakılamaz")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Açıklama boş bırakılamaz")]
        [Column(TypeName = "text")]
        public string Explanation { get; set; }

        [Required(ErrorMessage = "Blog görseli boş bırakılamaz")]
        [StringLength(250, ErrorMessage = "Blog görsel URL'si en fazla 250 karakter olabilir")]
        public string BlogImage { get; set; }

        // Bire çok ilişki için yorumları ekliyorum.
        public ICollection<Comments> Comments { get; set; }
    }
}
