using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CPrint.Models
{
    // set class to public to allow access
    public class Category
    {
        // primary key
        [Key]
        public int Id { get; set; }


        [Display(Name="Category Name")]
        // required as name cannot be null
        [Required]
        // max length of the text can be 50
        [MaxLength(50)]
        public string Name { get; set; }

    }
}
