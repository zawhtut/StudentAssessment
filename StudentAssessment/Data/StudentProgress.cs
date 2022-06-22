using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentAssessment.Data
{
    [Table("Student")]
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        public string? StudentName { get; set; }
        public int? Weight { get; set; }
        public int? Height { get; set; }

        public ICollection<Attendance>? Attendances { get; set; }

    }

    [Table("Attendance")]
    public class Attendance
    {
        [Key]
        public int AttendanceID { get; set; }
        public int? Month { get; set; }
        public int? Year { get; set; }
        public string? Class { get; set; }
        public int? DaysAttended { get; set; }

        //Foreign Key for Student
        public int StudentID { get; set; }
        public virtual Student? Student { get; set; }

        public virtual PhysicalDev? PhysicalDev { get; set; }
        public virtual SocialEmotionDev? SocialEmotionDev { get; set; }
        public virtual WorkHabit? WorkHabit { get; set; }
        public virtual LessonsLearned? LessonsLearned { get; set; }
        //public virtual MyProperty { get; set; } 

    }

    [Table("PhysicalDev")]
    public class PhysicalDev
    {
        [Key]
        public int AttendanceID { get; set; }
        public EvaluationKey FineMotorSkill { get; set; }
        public EvaluationKey GrossMotorSkill { get; set; }
        public EvaluationKey CombineBodyPart { get; set; }

        public virtual Attendance? Attendance { get; set; }

    }

    [Table("SocialEmotionDev")]
    public class SocialEmotionDev
    {
        [Key]
        public int AttendanceID { get; set; }
        public EvaluationKey? Sharing { get; set; }
        public EvaluationKey? RespondOthers { get; set; }
        public EvaluationKey? SelfControl { get; set; }
        public EvaluationKey? Confidence { get; set; }
        public EvaluationKey? Participation { get; set; }
        public EvaluationKey? SocalizingFriends { get; set; }

        public virtual Attendance? Attendance { get; set; }

    }

    [Table("WorkHabit")]
    public class WorkHabit
    {
        [Key]
        public int AttendanceID { get; set; }
        public EvaluationKey? FollowingInstruction { get; set; }
        public EvaluationKey? Attention { get; set; }
        public EvaluationKey? MakingChoice { get; set; }
        public EvaluationKey? AskingQuestion { get; set; }
        public EvaluationKey? StayingOnTask { get; set; }

        public virtual Attendance? Attendance { get; set; }

    }

    [Table("LessonsLearned")]
    public class LessonsLearned
    {
        [Key]
        public int AttendanceID { get; set; }
        public string? Letters { get; set; }
        public string? MyanmarLanguage { get; set; }
        public string? Math { get; set; }
        public string? Science { get; set; }
        public string? SocialStudies { get; set; }
        public string? Art { get; set; }

        public virtual Attendance? Attendance { get; set; }

    }

    public enum EvaluationKey
    {
        Excellent,
        GoodProgress,
        Developing,
        NeedImprovement
    }
}
