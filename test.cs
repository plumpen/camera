using Windows.Media.Capture;
using Windows.Storage;
using System;
using System.Threading.Tasks;

public class test
{
    public static async Task Main()
    {
	CameraCaptureUI captureUI = new CameraCaptureUI();
	captureUI.PhotoSettings.Format = CameraCaptureUIPhotoFormat.Jpeg;
	captureUI.PhotoSettings.CroppedSizeInPixels = new Size(200, 200); 

	StorageFile photo = await captureUI.CaptureFileAsync(CameraCaptureUIMode.Photo);

	if (photo == null)
	{
    	// User cancelled photo capture
    	return;	
	}
    }
}
