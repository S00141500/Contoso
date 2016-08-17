using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name="Last Name")]
        public string LastName { get; set; }

        [Required]
        [StringLength(50, ErrorMessage="Firstname cannot be longer than 50 characters")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd:mm:yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }
        
        public string Secret { get; set; }


        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstName;
            }
        }


        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
