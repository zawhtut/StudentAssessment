using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentAssessment.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    StudentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Weight = table.Column<int>(type: "int", nullable: true),
                    Height = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.StudentID);
                });

            migrationBuilder.CreateTable(
                name: "Attendance",
                columns: table => new
                {
                    AttendanceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Month = table.Column<int>(type: "int", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: true),
                    Class = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaysAttended = table.Column<int>(type: "int", nullable: true),
                    StudentID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendance", x => x.AttendanceID);
                    table.ForeignKey(
                        name: "FK_Attendance_Student_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Student",
                        principalColumn: "StudentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LessonsLearned",
                columns: table => new
                {
                    AttendanceID = table.Column<int>(type: "int", nullable: false),
                    Letters = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MyanmarLanguage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Math = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Science = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SocialStudies = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Art = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LessonsLearned", x => x.AttendanceID);
                    table.ForeignKey(
                        name: "FK_LessonsLearned_Attendance_AttendanceID",
                        column: x => x.AttendanceID,
                        principalTable: "Attendance",
                        principalColumn: "AttendanceID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhysicalDev",
                columns: table => new
                {
                    AttendanceID = table.Column<int>(type: "int", nullable: false),
                    FineMotorSkill = table.Column<int>(type: "int", nullable: false),
                    GrossMotorSkill = table.Column<int>(type: "int", nullable: false),
                    CombineBodyPart = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhysicalDev", x => x.AttendanceID);
                    table.ForeignKey(
                        name: "FK_PhysicalDev_Attendance_AttendanceID",
                        column: x => x.AttendanceID,
                        principalTable: "Attendance",
                        principalColumn: "AttendanceID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SocialEmotionDev",
                columns: table => new
                {
                    AttendanceID = table.Column<int>(type: "int", nullable: false),
                    Sharing = table.Column<int>(type: "int", nullable: true),
                    RespondOthers = table.Column<int>(type: "int", nullable: true),
                    SelfControl = table.Column<int>(type: "int", nullable: true),
                    Confidence = table.Column<int>(type: "int", nullable: true),
                    Participation = table.Column<int>(type: "int", nullable: true),
                    SocalizingFriends = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialEmotionDev", x => x.AttendanceID);
                    table.ForeignKey(
                        name: "FK_SocialEmotionDev_Attendance_AttendanceID",
                        column: x => x.AttendanceID,
                        principalTable: "Attendance",
                        principalColumn: "AttendanceID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkHabit",
                columns: table => new
                {
                    AttendanceID = table.Column<int>(type: "int", nullable: false),
                    FollowingInstruction = table.Column<int>(type: "int", nullable: true),
                    Attention = table.Column<int>(type: "int", nullable: true),
                    MakingChoice = table.Column<int>(type: "int", nullable: true),
                    AskingQuestion = table.Column<int>(type: "int", nullable: true),
                    StayingOnTask = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkHabit", x => x.AttendanceID);
                    table.ForeignKey(
                        name: "FK_WorkHabit_Attendance_AttendanceID",
                        column: x => x.AttendanceID,
                        principalTable: "Attendance",
                        principalColumn: "AttendanceID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Attendance_StudentID",
                table: "Attendance",
                column: "StudentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LessonsLearned");

            migrationBuilder.DropTable(
                name: "PhysicalDev");

            migrationBuilder.DropTable(
                name: "SocialEmotionDev");

            migrationBuilder.DropTable(
                name: "WorkHabit");

            migrationBuilder.DropTable(
                name: "Attendance");

            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}
