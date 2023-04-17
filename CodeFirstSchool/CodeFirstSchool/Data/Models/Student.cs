using Microsoft.Build.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace CodeFirstSchool.Data.Models
{
    public class Student
    {

        public Student()
        {
            this.StudentsSubjects = new HashSet<StudentSubject>();
        }
        public int Id { get; set; }
        [Required]
        [MaxLength(15)]
        [MinLength(3)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(15)]
        [MinLength(3)]
        public string LastName { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Email { get; set; }
        public ICollection<StudentSubject> StudentsSubjects { get; set; }
    }
}
