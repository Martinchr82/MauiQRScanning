namespace MauiQRScanning;

public partial class QRPage : ContentPage
{
	public QRPage()
	{
		InitializeComponent();
	}

    private void CameraBarcodeReaderView_BarcodesDetected(object sender, ZXing.Net.Maui.BarcodeDetectionEventArgs e)
    {
        
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(AnotherPage));

    }
}