using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalDetails = ATO_enthusiast.CoreBusiness.PersonalDetails;

namespace ATO_enthusiast.UseCases.PluginInterfaces
{
    public interface IPersonalDetailsRepository
    {
        Task<PersonalDetails> GetPersonalDetailsByIdAsync(int PersonalId);

        Task UpdatePersonalDetailsAsync(int personalId, PersonalDetails personalDetails);
    }
}
