using System.ComponentModel.DataAnnotations;

namespace efcoreApp.Data
{
    public class KursKayit
    {
        [Key]
        public int KayitId { get; set; }
        [Required]
        [Display(Name = "Öğrenci Numarası")]
        public int OgrenciId { get; set; }
        [Required]
        [Display(Name = "Öğrenci")]
        public Ogrenci Ogrenci { get; set; } = null!;
        [Required]
        [Display(Name = "Kurs Numarası")]
        public int KursId { get; set; }
        [Required]
        [Display(Name = "Kurs")]
        public Kurs Kurs { get; set; } = null!;
        [Required]
        [Display(Name = "Kayıt Tarihi")]
        public DateTime KayitTarihi {  get; set; }    
    }
}
