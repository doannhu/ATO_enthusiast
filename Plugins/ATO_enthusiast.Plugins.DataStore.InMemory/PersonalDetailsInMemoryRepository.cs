using ATO_enthusiast.UseCases.PluginInterfaces;
using PersonalDetails = ATO_enthusiast.CoreBusiness.PersonalDetails;

namespace ATO_enthusiast.Plugins.DataStore.InMemory
{
    // All the code in this file is included in all platforms.
    public class PersonalDetailsInMemoryRepository: IPersonalDetailsRepository
    {
        public static List<PersonalDetails> _personalDetails;
        public PersonalDetailsInMemoryRepository() {
            _personalDetails = new List<PersonalDetails>() {
                new PersonalDetails() {
                    PersonalId = 1,
                    Name = "John Doe",
                    DOB = new DateTime(1990, 5, 15), 
                    Resident = true,
                    TFN = "123-456-789",
                    WorkingHolidayMaker = false,
                    Address = "123 Main St, Sydney, NSW, 2000",
                    Phone = "0400 123 456",
                    Email = "john.doe@example.com"
                },
                new PersonalDetails()
                {
                    PersonalId = 2,
                    Name = "Jane Smith",
                    DOB = new DateTime(2005, 11, 22),
                    Resident = true,
                    TFN = "987-654-321",
                    WorkingHolidayMaker = false,
                    Address = "456 Park Ave, Melbourne, VIC, 3000",
                    Phone = "0411 222 333",
                    Email = "jane.smith@example.com"
                }
            };
        }

        public Task<PersonalDetails> GetPersonalDetailsByIdAsync(int personalId) {
            var personalDetails = _personalDetails.FirstOrDefault(x => x.PersonalId == personalId);
            if (personalDetails != null)
            {
                return Task.FromResult(new PersonalDetails 
                {   PersonalId = personalId,
                    Name = personalDetails.Name,
                    DOB = personalDetails.DOB,
                    Resident = personalDetails.Resident,
                    TFN = personalDetails.TFN,
                    WorkingHolidayMaker = personalDetails.WorkingHolidayMaker,
                    Address = personalDetails.Address,
                    Phone =  personalDetails.Phone,
                    Email = personalDetails.Email});
            }
            return null;
        }

       public Task UpdatePersonalDetailsAsync(int personalId, PersonalDetails personalDetails) {
            if (personalId != personalDetails.PersonalId) return Task.CompletedTask;
            var personalDetailsToUpdate = _personalDetails.FirstOrDefault(x => x.PersonalId == personalId);
            if (personalDetailsToUpdate != null)
            {
                personalDetailsToUpdate.Name = personalDetails.Name;
                personalDetailsToUpdate.DOB = personalDetails.DOB;
                personalDetailsToUpdate.Resident = personalDetails.Resident;
                personalDetailsToUpdate.TFN = personalDetails.TFN;
                personalDetailsToUpdate.WorkingHolidayMaker = personalDetails.WorkingHolidayMaker;
                personalDetailsToUpdate.Address = personalDetails.Address;
                personalDetailsToUpdate.Phone = personalDetails.Phone;
                personalDetailsToUpdate.Email = personalDetails.Email;
            }
            return Task.CompletedTask;
        }
    }
}
