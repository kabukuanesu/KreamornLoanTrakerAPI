using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KreamornLoanTrakerAPI.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdminDetails",
                columns: table => new
                {
                    AdminDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    EcNumber = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminDetails", x => x.AdminDetailId);
                });

            migrationBuilder.CreateTable(
                name: "LoanDetails",
                columns: table => new
                {
                    LoanDeatailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    NationalId = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    LoanApprovalLetter = table.Column<byte[]>(type: "varbinary(MAX)", nullable: true),
                    DisclosureStatements = table.Column<byte[]>(type: "varbinary(MAX)", nullable: true),
                    RepaymentSchedule = table.Column<byte[]>(type: "varbinary(MAX)", nullable: true),
                    ContactInformation = table.Column<byte[]>(type: "varbinary(MAX)", nullable: true),
                    DeclinationLetter = table.Column<byte[]>(type: "varbinary(MAX)", nullable: true),
                    IsApproved = table.Column<bool>(type: "bit", nullable: true),
                    IsAccepted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanDetails", x => x.LoanDeatailId);
                });

            migrationBuilder.CreateTable(
                name: "PersonalDetails",
                columns: table => new
                {
                    PersonalDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    DateOfBirth = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    MaritalStatus = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    WorkNumber = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    NationalId = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Employer = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    JobTitle = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    WageFrequency = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    AnnualSalary = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    MonthlyIncome = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Expense = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Benefit = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    LoanAmount = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    LoanTenure = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    ProofOfIdentity = table.Column<byte[]>(type: "varbinary(MAX)", nullable: false),
                    ProofOfResidence = table.Column<byte[]>(type: "varbinary(MAX)", nullable: false),
                    BankStatement = table.Column<byte[]>(type: "varbinary(MAX)", nullable: false),
                    ProofOfIncome = table.Column<byte[]>(type: "varbinary(MAX)", nullable: false),
                    BenefitDocument = table.Column<byte[]>(type: "varbinary(MAX)", nullable: true),
                    EmploymentVerification = table.Column<byte[]>(type: "varbinary(MAX)", nullable: false),
                    CollateralDocument = table.Column<byte[]>(type: "varbinary(MAX)", nullable: false),
                    OtherDocument = table.Column<byte[]>(type: "varbinary(MAX)", nullable: false),
                    PersonalPassword = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalDetails", x => x.PersonalDetailId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdminDetails");

            migrationBuilder.DropTable(
                name: "LoanDetails");

            migrationBuilder.DropTable(
                name: "PersonalDetails");
        }
    }
}
