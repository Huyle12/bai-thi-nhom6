
using MucGungApp.Views;

namespace MucGungApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new HomeView();
	}
}
