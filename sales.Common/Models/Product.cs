

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
        public String Description{ get; set; }
        public Decimal Price { get; set; }
        public bool IsAvailable { get; set; }
        public DateTime PublishOn{ get; set; }
    }
}
