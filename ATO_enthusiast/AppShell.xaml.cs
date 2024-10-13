using ATO_enthusiast.Views;

namespace ATO_enthusiast
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(EditPersonalDetailsPage), typeof(EditPersonalDetailsPage));
            Routing.RegisterRoute(nameof(PersonalDetailsPage), typeof(PersonalDetailsPage));
        }
    }
}
