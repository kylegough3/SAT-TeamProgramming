using System;
using System.Collections.Generic;

namespace SAT_TeamProgramming.DATA.EF.Models
{
    public partial class ScheduledClass
    {
        public ScheduledClass()
        {
            Enrollments = new HashSet<Enrollment>();
        }

        public int SchelduledClassId { get; set; }
        public int CourseId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string InstuctorName { get; set; } = null!;
        public string Location { get; set; } = null!;
        public int Scsid { get; set; }

        //modified Course and ScheduledClass status to allow nullable types in order create our own Courses and ScheduledClassStatus
        public virtual Course? Course { get; set; }
        public virtual ScheduledClassStatus? Scs { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
