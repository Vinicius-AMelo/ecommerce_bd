﻿using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        // public ICollection<Product> products { get; set; }
    }
}
