using System.ComponentModel.DataAnnotations;

namespace ATO_enthusiast.CoreBusiness
{
    // All the code in this file is included in all platforms.
    public class PersonalDetails
    {
        [Required]
        public int PersonalId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime DOB { get; set; }

        [Required]
        public bool Resident {  get; set; }

        [Required]
        public string TFN { get; set; }

        [Required]
        public bool WorkingHolidayMaker {  get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Phone {  get; set; }

        [Required]
        public string Email { get; set; }
    }
}
