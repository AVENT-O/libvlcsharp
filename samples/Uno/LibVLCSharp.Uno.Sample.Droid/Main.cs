using Android.App;
using Android.Runtime;
using Com.Nostra13.Universalimageloader.Core;
using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media;

namespace LibVLCSharp.Uno.Sample.Droid
{
    [Application(
        Label = "@string/ApplicationName",
        LargeHeap = true,
        HardwareAccelerated = true,
        Theme = "@style/AppTheme"
    )]
    public class Application : NativeApplication
    {
        public Application(IntPtr javaReference, JniHandleOwnership transfer)
            : base(() => new App(), javaReference, transfer)
        {
            ConfigureUniversalImageLoader();
        }

        private void ConfigureUniversalImageLoader()
        {
            // Create global configuration and initialize ImageLoader with this config
            ImageLoaderConfiguration config = new ImageLoaderConfiguration
                .Builder(Context)
                .Build();

            ImageLoader.Instance.Init(config);

            ImageSource.DefaultImageLoader = ImageLoader.Instance.LoadImageAsync;
        }
    }
}
