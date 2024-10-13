using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ATO_enthusiast.CoreBusiness
{
    public class SuperDetails
    {
        [Required]
        public int SuperDetailsId { get; set; }

        [Required]
        public int PersonalId { get; set; }

        [Required]
        public string FundName { get; set; }

        [Required]
        public int FundABN { get; set; }

        [Required]
        public int MemberNo { get; set; }

        [Required]
        public string USI {  get; set; }

        [Required]
        public bool Insurance { get; set; }

        [Required]
        public string DateReported { get; set; }

        [Required]
        public string DateOpened { get; set; }
    }
}
