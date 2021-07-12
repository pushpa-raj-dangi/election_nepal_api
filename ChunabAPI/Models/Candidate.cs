using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChunabAPI.Models
{
    public class Candidate
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public string Address { get; set; }
        public string Photo { get; set; }
        public string Vote { get; set; }


    }
}
