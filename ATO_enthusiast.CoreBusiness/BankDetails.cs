using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ATO_enthusiast.CoreBusiness
{
    public class BankDetails
    {
        [Required]
        public int BankDetailsId { get; set; }

        [Required]
        public int PersonalId { get; set; }

        [Required]
        public string AccountName {  get; set; }
        
        [Required]
        public string BSB {  get; set; }

        [Required]
        public string AccountNumber { get; set; }

        [Required]
        public string BankName { get; set; }

    }
}
