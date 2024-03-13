using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KreamornLoanTrakerAPI.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigraion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LoanDetails",
                columns: table => new
                {
                    LoanDeatailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id = table.Column<int>(type: "int", nullable: false),
                    LoanApprovalLetter = table.Column<byte[]>(type: "varbinary(MAX)", nullable: false),
                    DisclosureStatements = table.Column<byte[]>(type: "varbinary(MAX)", nullable: false),
                    RepaymentSchedule = table.Column<byte[]>(type: "varbinary(MAX)", nullable: false),
                    ContactInformation = table.Column<byte[]>(type: "varbinary(MAX)", nullable: false)
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
                    Id = table.Column<int>(type: "int", nullable: false),
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
                    ProofOfIdentity = table.Column<byte[]>(type: "varbinary(MAX)", nullable: false),
                    ProofOfAddress = table.Column<byte[]>(type: "varbinary(MAX)", nullable: false),
                    BankStatement = table.Column<byte[]>(type: "varbinary(MAX)", nullable: false),
                    BenefitDocument = table.Column<byte[]>(type: "varbinary(MAX)", nullable: true),
                    PersonalPassword = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalDetails", x => x.PersonalDetailId);
                    table.ForeignKey(
                        name: "FK_PersonalDetails_LoanDetails_Id",
                        column: x => x.Id,
                        principalTable: "LoanDetails",
                        principalColumn: "LoanDeatailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonalDetails_Id",
                table: "PersonalDetails",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonalDetails");

            migrationBuilder.DropTable(
                name: "LoanDetails");
        }
    }
}
