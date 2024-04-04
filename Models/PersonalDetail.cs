using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KreamornLoanTrakerAPI.Models
{
    public class PersonalDetail
    {
        [Key]
        public int PersonalDetailId { get; set; }


        [Column(TypeName = "nvarchar(100)")]
        public string FullName { get; set; } = "";

        [Column(TypeName = "nvarchar(20)")]
        public string Title { get; set; } = "";

        [Column(TypeName = "nvarchar(50)")]
        public string DateOfBirth { get; set; } = "";
        
        [Column(TypeName = "nvarchar(20)")]
        public string MaritalStatus { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string Address { get; set; } = "";

        [Column(TypeName = "nvarchar(20)")]
        public string PhoneNumber { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string EmailAddress { get; set; } = "";

        [Column(TypeName = "nvarchar(20)")]
        public string WorkNumber { get; set; } = "";

        [Column(TypeName = "nvarchar(50)")]
        public string NationalId { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string Employer { get; set; } = "";

        [Column(TypeName = "nvarchar(20)")]
        public string JobTitle { get; set; } = "";

        [Column(TypeName = "nvarchar(20)")]
        public string WageFrequency { get; set; } = "";

        [Column(TypeName = "nvarchar(50)")]
        public string AnnualSalary { get; set; } = "";

        [Column(TypeName = "nvarchar(50)")]
        public string MonthlyIncome { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string Expense { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string Benefit { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string LoanAmount { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string LoanTenure { get; set; } = "";

        [Column(TypeName = "varbinary(MAX)")]
        public byte[]? ProofOfIdentity { get; set; }

        [Column(TypeName = "varbinary(MAX)")]
        public byte[]? ProofOfResidence { get; set; }

        [Column(TypeName = "varbinary(MAX)")]
        public byte[]? BankStatement { get; set; }

        [Column(TypeName = "varbinary(MAX)")]
        public byte[]? ProofOfIncome { get; set; }

        [Column(TypeName = "varbinary(MAX)")]
        public byte[]? BenefitDocument { get; set; }

        [Column(TypeName = "varbinary(MAX)")]
        public byte[]? EmploymentVerification { get; set; }

        [Column(TypeName = "varbinary(MAX)")]
        public byte[]? CollateralDocument { get; set; }

        [Column(TypeName = "varbinary(MAX)")]
        public byte[]? OtherDocument { get; set; }

        [Column(TypeName ="nvarchar(100)")]
        public string PersonalPassword { get; set; } = "";
    }

    public class LoanDetail
    {
        [Key]
        public int LoanDeatailId { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string ApplicationId { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string FullName { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string EmailAddress { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string NationalId { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string Approved { get; set; } = "";

        [Column(TypeName = "varbinary(MAX)")]
        public byte[]? LoanApprovalLetter { get; set;}

        [Column(TypeName = "varbinary(MAX)")]
        public byte[]? DisclosureStatements { get;set;}

        [Column(TypeName = "varbinary(MAX)")]
        public byte[]? RepaymentSchedule { get; set;}

        [Column(TypeName = "varbinary(MAX)")]
        public byte[]? ContactInformation { get; set;}

        [Column(TypeName = "varbinary(MAX)")]
        public byte[]? DeclinationLetter { get; set;}

    }

    public class AdminDetail
    {
        [Key]
        public int AdminDetailId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string FullName { get; set; } = "";

        [Column(TypeName = "nvarchar(50)")]
        public string EcNumber { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string EmailAddress { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string Password { get; set; } = "";
    }
}
