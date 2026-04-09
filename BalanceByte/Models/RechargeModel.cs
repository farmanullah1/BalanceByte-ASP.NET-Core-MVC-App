using System.ComponentModel.DataAnnotations;

namespace BalanceByte.Models
{
    public class RechargeModel
    {
        [Required(ErrorMessage = "Mobile number is required.")]
        [RegularExpression(@"^03\d{9}$", ErrorMessage = "Enter a valid 11-digit number starting with 03 (e.g., 03001234567)")]
        [Display(Name = "Mobile Number")]
        public string MobileNumber { get; set; }

        [Required(ErrorMessage = "Please select your carrier.")]
        public string Carrier { get; set; }

        [Required(ErrorMessage = "Please enter a recharge amount.")]
        [Range(50, 10000, ErrorMessage = "Amount must be between 50 and 10,000 Rs.")]
        [Display(Name = "Recharge Amount (Rs)")]
        public decimal RechargeAmount { get; set; }

        // Core Calculations
        public decimal TaxPercentage => 0.135m; // 13.5% Tax
        public decimal TaxDeducted => RechargeAmount * TaxPercentage;
        public decimal ActualBalance => RechargeAmount - TaxDeducted;

        public bool IsCalculated { get; set; } = false;
    }
}