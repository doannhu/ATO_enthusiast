using System.Runtime.CompilerServices;
namespace ATO_enthusiast.Views.Controls;

public partial class PersonalDetailsControlMVVM : ContentView
{
	public bool IsForEdit { get; set; }
	public PersonalDetailsControlMVVM()
	{
		InitializeComponent();
	}

    protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        base.OnPropertyChanged(propertyName);

     if (IsForEdit)
            btnSave.SetBinding(Button.CommandProperty, "EditPersonalDetailsCommand");
    }
}