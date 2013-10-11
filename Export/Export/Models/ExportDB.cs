using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Export.Models
{
    public class Export_Excel : DbContext
    {
        public DbSet<StudentDetail> Studentrecord { get; set; }
    }
}