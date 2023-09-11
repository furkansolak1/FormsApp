using System.ComponentModel.DataAnnotations;

namespace FormsApp.Models
{
    public class Product{
        [Display(Name="Urun Id")]
        public int ProductId { get; set; }
        
        [Display(Name="Urun Adı")]
        [Required(ErrorMessage ="Gerekli bir alan")]
        public string Name { get; set; }=null!;// nullable bir att. erişidiğinde kesinlikle ben onu doldurmuş olacağım 

        [Display(Name="Fiyat")]
        [Required]
        [Range(0,150000)]
        public decimal? Price { get; set; }


        [Display(Name="Resim")]
        
        public string? Image { get; set; }

        public bool IsActive { get; set; }

        [Display(Name="Category")]
        [Required]
        public int? CategoryId { get; set; }


    }
}