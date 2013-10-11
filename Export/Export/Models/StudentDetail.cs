using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace Export.Models
{    
    public class StudentDetail
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public String Name { get; set; }
        public String Address { get; set; }
        public String Marks { get; set; }        
    }
}