using System.ComponentModel.DataAnnotations;

namespace efcoreApp.Data
{
    public class Ogrenci
    {
        public int OgrenciId { get; set; }
        [Required]
        public string? OgrenciAd { get; set; }
        [Required]
        public string? OgrenciSoyad { get; set; }
        [Display(Name = "Öğrenci")]
        public string? AdSoyad 
        { 
            get
            {
                return this.OgrenciAd+" "+this.OgrenciSoyad;
            }
        }
        [Required]
        [Display(Name = "E-Posta")]
        public string? Eposta { get; set; }
        [Required]
        public string? Telefon { get; set; }
        public ICollection<KursKayit> KursKayitlari { get; set; } = new List<KursKayit>();
    }
}
