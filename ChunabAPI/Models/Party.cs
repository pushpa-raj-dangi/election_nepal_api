﻿using System;
using System.ComponentModel.DataAnnotations;

namespace ChunabAPI.Models
{
    public class Party
    {

        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Logo { get; set; }
        public string Description { get; set; }

        public string Vote { get; set; }

    }
}
