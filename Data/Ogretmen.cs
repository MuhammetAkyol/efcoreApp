using System.ComponentModel.DataAnnotations;

namespace efcoreApp.Data
{
    public class Ogretmen
    {
        public int OgretmenId { get; set; }
        [Required]
        public string? Ad {  get; set; }
        [Required]
        public string? Soyad { get;set; }
        [Display(Name = "Öğretmen")]
        public string? AdSoyad
        {
            get
            {
                return this.Ad + " " + this.Soyad;
            }
        }
        [Required]
        [Display(Name = "E-Posta")]
        public string? Eposta { get; set; }
        [Required]
        public string? Telefon { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd-MM-yyyy}",ApplyFormatInEditMode = true)]
        [Required]
        [Display(Name = "Başlama Tarihi")]
        public DateTime BaslamaTarihi { get; set; }
        public ICollection<Kurs> Kurslar { get; set; } = new List<Kurs>();  


    }
}
