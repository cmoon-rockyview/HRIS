using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HRIS.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "RV");

            migrationBuilder.EnsureSchema(
                name: "TRN");

            migrationBuilder.CreateTable(
                name: "Employee",
                schema: "RV",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmpIdNoZero = table.Column<int>(type: "int", nullable: true),
                    RVEmployeeId = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PreferredName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoginName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SuperLoginName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Section = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Locn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PositionCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PositionDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkZone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Building = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GLCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Picture = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    AccessiblePositions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccessibleLogins = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Acting = table.Column<bool>(type: "bit", nullable: false),
                    Rehire = table.Column<bool>(type: "bit", nullable: false),
                    EndofEmployment = table.Column<bool>(type: "bit", nullable: false),
                    AcceptedByHR = table.Column<bool>(type: "bit", nullable: false),
                    ReportsTo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ReportsToDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportsToEmpId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportsToFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportsToLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportsToPreferredName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportsToFullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportsToLogin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportsToEMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportsToPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportsTo2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportsToEmpId2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportsToLogin2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportsToEMail2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportsToPhone2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportsToFirstName2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportsToLastName2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportsToPreferredName2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportsToFullName2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PositionType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HRApproval = table.Column<bool>(type: "bit", nullable: false),
                    IsDirectReport = table.Column<bool>(type: "bit", nullable: false),
                    Division = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DivisionNum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TrainingRequest",
                schema: "TRN",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PreferredName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoginName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Section = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Locn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PositionCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PositionDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkZone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Building = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GLCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MangerEmpId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManagerFullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EDEmpId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EDFullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrnName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrnType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrnProvider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AchievementType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrnLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrnOption = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DevelopmentGoal = table.Column<bool>(type: "bit", nullable: false),
                    ReuglarHour = table.Column<bool>(type: "bit", nullable: false),
                    OutofProvince = table.Column<bool>(type: "bit", nullable: false),
                    TrnHours = table.Column<float>(type: "real", nullable: false),
                    CoursDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RationalForAttending = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequestorLogin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequestedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ApprovalStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProgressStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingRequest", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee",
                schema: "RV");

            migrationBuilder.DropTable(
                name: "TrainingRequest",
                schema: "TRN");
        }
    }
}
