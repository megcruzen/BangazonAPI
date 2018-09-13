﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BangazonAPI.Models
{
    public class ProductOrder
    {
        [Key]
        public int ProductOrderId { get; set; }

        [Required] 
        public int OrderId { get; set; }

        [Required]
        public int ProductId { get; set; }
 


    }
}
