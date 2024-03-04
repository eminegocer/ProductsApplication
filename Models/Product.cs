using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace FormsApp.Models
{
    public class Product
    {
        [Display(Name = "Urun Id")]
        public int ProductId { get; set; }

        [Required(ErrorMessage ="Gerekli Bir Alan")]
        [StringLength(100,ErrorMessage ="En Fazla 100 Karakterlik Ürün Adı Girilebilir")]
        [Display(Name = "Urun Adı")]
        public string Name { get; set; }=null!;

        [Required]
        [Range(0,100000, ErrorMessage ="Girilen Değer 0 ile 100000 Arasında Olmalı")]
        [Display(Name = "Fiyat")]
        public decimal? Price { get; set; }


        [Display(Name = "Resim")]
        public string? Image { get; set; }=string.Empty;


        public bool IsActive { get; set; }

        [Display(Name = "Kategori")]

        [Required]
        public int? CategoryId { get; set; }
        
    }
}