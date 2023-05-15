using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
   public class Manager
    {
        [Key]
        public string ManagerId { get; set; }

        [Required]
        public string MName { get; set; }

        [Required]
        public string MEmail { get; set; }

        
        [Required]
        public int MPhone { get; set; }

        [Required]
        public string MGender { get; set; }

        [Required]
        [StringLength(20)]
        public string MPassword { get; set; }
    }
}
