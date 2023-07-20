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
		//Added to use for Full Name display
		public string FullName { get { return $"{FirstName} {LastName}"; } }
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
		public string? SchClassInfo
		{
			get
			{ if(Course == null)
				{
					return null;
				} else
				{

					return string.Format($"{Course.CourseName} - {StartDate:d}");
				}

			}
		}
	}

	[ModelMetadataType(typeof(ScheduledClassStatus))]
	public partial class ScheduledClassStatus
	{
	}
}
