using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;

namespace SAT_TeamProgramming.DATA.EF.Models
{
    [ModelMetadataType(typeof(CourseMetadata))]
    public partial class Course
    {
    }

    [ModelMetadataType(typeof(StudentMetadata))]
    public partial class Student
    {
    }

    [ModelMetadataType(typeof(StudentStatusMetadata))]
    public partial class StudentStatus
    {
    }

    [ModelMetadataType(typeof(EnrollmentMetadata))]
    public partial class Enrollment
    {
    }

    [ModelMetadataType(typeof(ScheduledClassMetadata))]
    public partial class ScheduledClass
    {
    }

    [ModelMetadataType(typeof(ScheduledClassStatus))]
    public partial class ScheduledClassStatus
    {
    }
}
