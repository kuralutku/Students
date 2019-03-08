using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Students.Models
{
    public class StudentsContext :DbContext
    {
        public StudentsContext(DbContextOptions<StudentsContext> options):base(options)
        {

        }
        public DbSet<Student> Books { get; set; }
    }
}
