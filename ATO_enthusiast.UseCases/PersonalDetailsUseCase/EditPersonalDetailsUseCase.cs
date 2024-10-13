using ATO_enthusiast.CoreBusiness;
using ATO_enthusiast.UseCases.PersonalDetailsInterfaces;
using ATO_enthusiast.UseCases.PluginInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATO_enthusiast.UseCases.PersonalDetailsUseCase
{
    public class EditPersonalDetailsUseCase: IEditPersonalDetailsUseCase
    {
        internal readonly IPersonalDetailsRepository personalDetailsRepository;

        public EditPersonalDetailsUseCase(IPersonalDetailsRepository personalDetailsRepository)
        {
            this.personalDetailsRepository = personalDetailsRepository;
        }

        public async Task ExecuteEditPersonalUseCaseAsync(int personId, PersonalDetails personalDetails)
        {
            await this.personalDetailsRepository.UpdatePersonalDetailsAsync(personId, personalDetails);
        }
    }
}
