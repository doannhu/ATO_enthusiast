using ATO_enthusiast.ViewModels;

namespace ATO_enthusiast.Views;

[QueryProperty(nameof(PersonalId), "Id")]
public partial class EditPersonalDetailsPage : ContentPage
{
	private readonly PersonalDetailsViewModel personalDetailsViewModel;
	public EditPersonalDetailsPage(PersonalDetailsViewModel personalDetailsViewModel)
	{
		InitializeComponent();
		this.personalDetailsViewModel = personalDetailsViewModel;
		this.BindingContext = this.personalDetailsViewModel;
	}

	public string PersonalId { 
		set 
			{ 
				if(int.TryParse(value, out int personalId))
				{
					LoadPersonalDetails(personalId);
				}
			} 
	}

	private async void LoadPersonalDetails(int personalId)
	{
		await this.personalDetailsViewModel.LoadPersonalDetails(personalId);
	}

	//protected override async void OnAppearing()
	//{
	//	base.OnAppearing();
	//	await this.personalDetailsViewModel.LoadPersonalDetails(1);
	//}
}