using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BookCrudOperationASP_Net.Data
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string isbn { get; set; }
        public string Title { get; set; }
        public string Publisher { get; set; }
        public string Author { get; set; }
        public string Pages { get; set; }
    }
}