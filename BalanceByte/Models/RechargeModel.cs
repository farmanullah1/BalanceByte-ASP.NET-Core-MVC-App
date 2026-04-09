using System.ComponentModel.DataAnnotations;

namespace BalanceByte.Models
{
    public class RechargeModel
    {
        [Required(ErrorMessage = "Please enter a recharge amount.")]
        [Range(50, 10000, ErrorMessage = "Amount must be between 50 and 10,000 Rs.")]
        [Display(Name = "Recharge Amount (Rs)")]
        public decimal RechargeAmount { get; set; }

        [Required(ErrorMessage = "Please select your carrier.")]
        public string Carrier { get; set; }

        // The mathematically corrected formula for a 13.5% tax deduction
        public decimal ActualBalance => RechargeAmount * (1m - 0.135m);

        public bool IsCalculated { get; set; } = false;
    }
}