using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChunabAPI.Models
{
    public class ElectionRegion
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }

    }
}
