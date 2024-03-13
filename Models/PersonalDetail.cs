using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KreamornLoanTrakerAPI.Models
{
    public class PersonalDetail
    {
        [Key]
        public int PersonalDetailId { get; set; }

        [ForeignKey("Id")]
        public int Id { get; set; } // Foreign Key Property

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

        [Column(TypeName = "varbinary(MAX)")]
        public required byte[] ProofOfIdentity { get; set; }

        [Column(TypeName = "varbinary(MAX)")]
        public required byte[] ProofOfAddress { get; set; }

        [Column(TypeName = "varbinary(MAX)")]
        public required byte[] BankStatement { get; set; }

        [Column(TypeName = "varbinary(MAX)")]
        public byte[]? BenefitDocument { get; set; }

        [Column(TypeName ="nvarchar(100)")]
        public string PersonalPassword { get; set; } = "";

        [ForeignKey("Id")]
        public required LoanDetail LoanDetail { get; set; } // Navigation Property
    }

    public class LoanDetail
    {
        [Key]
        public int LoanDeatailId { get; set; }

        [ForeignKey("Id")]
        public int Id { get; set; } // Foreign Key Property

        [Column(TypeName = "varbinary(MAX)")]
        public required byte[] LoanApprovalLetter { get; set;}

        [Column(TypeName = "varbinary(MAX)")]
        public required byte[] DisclosureStatements { get;set;}

        [Column(TypeName = "varbinary(MAX)")]
        public required byte[] RepaymentSchedule { get; set;}

        [Column(TypeName = "varbinary(MAX)")]
        public required byte[] ContactInformation { get; set;}

        public required ICollection<PersonalDetail> PersonalDetails { get; set; } // Navigation Property
    }
}
