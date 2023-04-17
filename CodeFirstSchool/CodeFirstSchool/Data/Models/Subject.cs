using CodeFirstSchool.Data.Models.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstSchool.Data.Models
{
    public class Subject
    {
        public Subject()
        {
            this.StudentsSubjects = new HashSet<StudentSubject>();
        }
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        [MinLength(3)]
        public string Name { get; set; }
        [Required]
        public SubjectType SubjectType { get; set; }
        [Range(2,6)]
        public double Grade{ get; set; }
        [Required]
        public DateTime RecievedOn { get; set; }
        public ICollection<StudentSubject> StudentsSubjects { get; set; }
    }
}