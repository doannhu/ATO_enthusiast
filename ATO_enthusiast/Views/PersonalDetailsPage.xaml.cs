using ATO_enthusiast.ViewModels;

namespace ATO_enthusiast.Views;

public partial class PersonalDetailsPage : ContentPage
{
	private readonly PersonalDetailsViewModel personalDetailsViewModel;
	public PersonalDetailsPage(PersonalDetailsViewModel personalDetailsViewModel)
	{
		InitializeComponent();
		this.personalDetailsViewModel = personalDetailsViewModel;
		this.BindingContext = personalDetailsViewModel;
	}

	protected override async void OnAppearing()
	{
		base.OnAppearing();

		await this.personalDetailsViewModel.LoadPersonalDetails(2);
	}
}