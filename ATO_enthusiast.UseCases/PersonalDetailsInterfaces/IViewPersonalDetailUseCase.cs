using ATO_enthusiast.CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATO_enthusiast.UseCases.PersonalDetailsInterfaces
{
    public interface IViewPersonalDetailsUseCase
    {
        Task<PersonalDetails> ExecuteViewPersonalDetailsUseCaseAsync(int personalId);
    }
}
