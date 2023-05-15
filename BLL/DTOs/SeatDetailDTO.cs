using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class SeatDetailDTO
    {
        public string SeatId { get; set; }

        [Required]
        public string SRow { get; set; }

        [Required]
        public string SType { get; set; }
    }
}
