using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAT_TeamProgramming.DATA.EF.Models
{
    public class CourseMetadata
    {
        [Required(ErrorMessage = "* Name is required")]
        [StringLength(50,ErrorMessage ="Max 50 characters")]
        [Display(Name = "Course Name")]
        public string CourseName { get; set; } = null!;

        [Required(ErrorMessage = "* Description is required")]
        [StringLength(500, ErrorMessage = "Max 500 characters")]
        [DataType(DataType.MultilineText)]
        [Display(Name ="Course Description")]
        public string CourseDescription { get; set; } = null!;

        [Required(ErrorMessage = "* Credit Hours is required")]
        [Display(Name = "Credit Hours")]
        [Range(1, 5, ErrorMessage = "Please enter the correct value 1 - 5")]
        public byte CreditHours { get; set; }

        [StringLength(250, ErrorMessage = "Max 250 characters")]
        [DataType(DataType.MultilineText)]
        public string? Curriculum { get; set; }

        [StringLength(500, ErrorMessage = "Max 500 characters")]
        [DataType(DataType.MultilineText)]
        public string? Notes { get; set; }

        [Display(Name ="Active ?")]
        public bool IsActive { get; set; }
    }

    public class StudentMetadata
    {
        [Required(ErrorMessage = "* First Name is required")]
        [StringLength(20, ErrorMessage = "Max 20 Characters")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; } = null!;

        [Required(ErrorMessage = "* Last Name is required")]
        [StringLength(20, ErrorMessage = "Max 20 Characters")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; } = null!;

        [StringLength(15, ErrorMessage = "Max 20 Characters")]
        public string? Major { get; set; }

        [StringLength(50, ErrorMessage = "Max 20 Characters")]
        public string? Address { get; set; }

        [StringLength(20, ErrorMessage = "Max 20 Characters")]
        public string? City { get; set; }

        [StringLength(2, ErrorMessage = "Max 2 Characters")]
        public string? State { get; set; }

        [StringLength(10, ErrorMessage = "Max 10 Characters")]
        [Display(Name = "Zip Code")]
        [DataType(DataType.PostalCode)]
        public string? ZipCode { get; set; }

        [StringLength(13, ErrorMessage ="* Max 13 characters")]
        [DataType(DataType.PhoneNumber)]
        public string? Phone { get; set; }


        [Required(ErrorMessage = "* Email is required")]
        [StringLength(60, ErrorMessage = "Max 60 Characters")]
        public string Email { get; set; } = null!;

        [StringLength(100, ErrorMessage = "Max 100 Characters")]
        public string? PhotoUrl { get; set; }
        
    }

    public class StudentStatusMetadata
    {
        [Required(ErrorMessage = "* Student Status is required")]
        [StringLength(30, ErrorMessage = "Max 30 Characters")]
        [Display(Name = "Student Status Type")]
        public string Ssname { get; set; } = null!;

        [StringLength(250, ErrorMessage = "Max 250 Characters")]
        [Display(Name = "Status Description")]
        public string? Ssdescription { get; set; }
    }

    public class EnrollmentMetadata
    {
        [Required(ErrorMessage = "* Student ID required")]
        public int StudentId { get; set; }
        
        
        [Required(ErrorMessage = "Schedule Class ID is required")]
        [Range(0, int.MaxValue)]
        public int ScheduledClassId { get; set; }


        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]//0:d => MM/dd/yyyy
        [Display(Name = "Enrollment Date")]
        [Required(ErrorMessage = "Enrollment Date is required")]
        public DateTime EnrollmentDate { get; set; }
    }

    public class ScheduledClassMetadata
    {
        [Required(ErrorMessage = "Course ID is required")]
        public int CourseId { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]//0:d => MM/dd/yyyy
        [Display(Name = "Start Date")]
        [Required (ErrorMessage="* Start Date is Required")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]//0:d => MM/dd/yyyy
        [Display(Name = "End Date")]
        [Required(ErrorMessage = "* End Date is Required")]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        [StringLength(40, ErrorMessage = "Max 40 Characters")]
        [Display(Name = "Instructor")]
        [Required (ErrorMessage="* Instructor is Required")]
        public string InstuctorName { get; set; } = null!;

        [StringLength(20, ErrorMessage = "Max 20 Characters")]
        [Required(ErrorMessage = "* Location is Required")] 
        public string Location { get; set; } = null!;

        [Required(ErrorMessage = "Scsid is required")]
        [Display(Name = "Scheduled Class ID")]
        public int Scsid { get; set; }
    }

    public class ScheduledClassStatusMetadata

    {
        [Required(ErrorMessage ="Scsname")]
        [Display(Name ="Class Status")]
        public string Scsname { get; set; } = null!;
    }
    
}
