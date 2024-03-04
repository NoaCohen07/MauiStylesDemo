using MauiStylesDemo.Views;
namespace MauiStylesDemo;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new FormValidation();
	}
}
