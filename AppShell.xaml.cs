namespace MauiQRScanning;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(AnotherPage), typeof(AnotherPage));
	}
}
