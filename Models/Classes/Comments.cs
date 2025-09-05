using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace travelproject.Models.Classes
{
    public class Comments
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Kullanıcı adı boş bırakılamaz")]
        [StringLength(50, ErrorMessage = "Kullanıcı adı en fazla 50 karakter olabilir")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "E-posta adresi boş bırakılamaz")]
        [EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi giriniz")]
        [StringLength(100, ErrorMessage = "E-posta adresi en fazla 100 karakter olabilir")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Yorum boş bırakılamaz")]
        [StringLength(1000, ErrorMessage = "Yorum en fazla 1000 karakter olabilir")]
        public string Comment { get; set; }

        // Foreign Key alanı
        [Required]
        public int BlogID { get; set; }

        [ForeignKey("BlogID")]
        public virtual MyBlog Blog { get; set; }
    }
}
