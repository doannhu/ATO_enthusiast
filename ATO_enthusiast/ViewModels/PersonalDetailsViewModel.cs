using ATO_enthusiast.UseCases.PersonalDetailsInterfaces;
using ATO_enthusiast.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalDetails = ATO_enthusiast.CoreBusiness.PersonalDetails;


namespace ATO_enthusiast.ViewModels
{
    public partial class PersonalDetailsViewModel:ObservableObject
    {
        private PersonalDetails personalDetails;
        private readonly IViewPersonalDetailsUseCase viewPersonalDetailsUseCase;
        private readonly IEditPersonalDetailsUseCase editPersonalDetailsUseCase;

        public bool IsNameValidated { get; set; }
        public bool IsEmailProvided { get; set; }
        public bool IsEmailFormatValid { get; set; }

        public PersonalDetails PersonalDetails {

            get => personalDetails; 
            
            set { 
               SetProperty(ref personalDetails, value); 
            } 
        }

        public PersonalDetailsViewModel(IViewPersonalDetailsUseCase viewPersonalDetailsUseCase,
                                        IEditPersonalDetailsUseCase editPersonalDetailsUseCase)
        {
            this.PersonalDetails = new PersonalDetails();
            this.viewPersonalDetailsUseCase = viewPersonalDetailsUseCase;
            this.editPersonalDetailsUseCase = editPersonalDetailsUseCase;
        }

        public async Task LoadPersonalDetails(int PersonalId)
        {
            this.PersonalDetails = await this.viewPersonalDetailsUseCase.ExecuteViewPersonalDetailsUseCaseAsync(PersonalId);
        }

        private async Task<bool> ValidatePersonalDetails() {
            if(!this.IsNameValidated)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Name is required", "OK");
                return false;
            }

            if (!this.IsEmailProvided)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Email is required.", "OK");
                return false;
            }

            if (!this.IsEmailFormatValid)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Email format is incorrect.", "OK");
                return false;
            }

            return true;
        }

        [RelayCommand]
        public async Task ValidateDate()
        {
            if(this.PersonalDetails.DOB > DateTime.Today)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Invalid date of birth", "OK");
            }
        }

        [RelayCommand]
        public async Task EditPersonalDetails()
        {
            if (await ValidatePersonalDetails())
            {
                await this.editPersonalDetailsUseCase.ExecuteEditPersonalUseCaseAsync(this.personalDetails.PersonalId, this.personalDetails);
                await Shell.Current.GoToAsync($"{nameof(EditPersonalDetailsPage)}");
            }
        }

        [RelayCommand]
        public async Task ToEditPersonalDetails(int personalId)
        {
            await Shell.Current.GoToAsync($"{nameof(EditPersonalDetailsPage)}?Id={personalId}");
        }

        [RelayCommand]
        public async Task ToPersonalDetailsPage()
        {
            await Shell.Current.GoToAsync($"//{nameof(PersonalDetailsPage)}");
        }
    }
}
