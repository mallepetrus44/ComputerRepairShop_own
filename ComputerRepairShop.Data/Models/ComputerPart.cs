using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerRepairShop.Data.Models
{
    public class ComputerPart
    {
        public int Id { get; set; }
        [Required]
        public string PartName { get; set; }
        [Required]
        public string VendorName { get; set; }
        public decimal Price { get; set; }
        public string Status { get; set; }
    }

}
