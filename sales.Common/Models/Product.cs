

namespace sales.Common.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    //Using dentro del namespace 
    public class Product
    {
        [Key]//Autoincremental sql DataAnnotations
        public int ProductId { get; set; }

        [Required] //Campo Obligatorio
        [StringLength(50)]
        public String Description { get; set; }

        [DataType(DataType.MultilineText)]
        public String Remarks { get; set; }

        [Display(Name = "Image")]
        public String ImagePath { get; set; } 

        [DisplayFormat(DataFormatString ="{0:C2}", ApplyFormatInEditMode = false)]
        public Decimal Price { get; set; }

        [Display(Name = "Is Available")]
        public bool IsAvailable { get; set; }

        [Display(Name = "Publish On")]
        [DataType(DataType.Date)]
        public DateTime PublishOn{ get; set; }

        public override string ToString()
        {
            return this.Description; 
        }
    }
}
