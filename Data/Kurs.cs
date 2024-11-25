using System.ComponentModel.DataAnnotations;

namespace efcoreApp.Data
{
    public class Kurs
    {
        public int KursId { get; set; }
        [Required]
        [Display(Name = "Başlık")]
        public string? Baslik { get; set; }
        [Required]
        [Display(Name = "Öğretmen Numarası")]
        public int OgretmenId { get; set; }
        [Required]
        [Display(Name = "Öğretmen")]
        public Ogretmen Ogretmen { get; set; } = null!;
        public ICollection<KursKayit> KursKayitlari { get; set; } = new List<KursKayit>();
    }
}
