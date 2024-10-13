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
    public class ViewPersonalDetailsUseCase: IViewPersonalDetailsUseCase
    {
        private readonly IPersonalDetailsRepository personalDetailsRepository;

        public ViewPersonalDetailsUseCase(IPersonalDetailsRepository personalDetailsRepository)
        {
            this.personalDetailsRepository = personalDetailsRepository;
        }

        public async Task<PersonalDetails> ExecuteViewPersonalDetailsUseCaseAsync(int personalId)
        {
            return await this.personalDetailsRepository.GetPersonalDetailsByIdAsync(personalId);
        }



    }
}
