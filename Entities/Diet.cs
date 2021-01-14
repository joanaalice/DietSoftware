using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class Diet
    {
        [Key]
        public int ID { get; set; }
        public List<Food> Foods { get; set; }
    }
}
