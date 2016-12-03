using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views.Animations;

namespace MyANIMATION
{
    [Activity(Label = "MyANIMATION", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
           SetContentView (Resource.Layout.Main);

            Animation myAnimation = AnimationUtils.LoadAnimation(this, Resource.Animation.MyAnimation);
            ImageView myImage = FindViewById<ImageView>(Resource.Id.imageView1);
            FindViewById<Button>(Resource.Id.button1).Click += delegate
            {
                myImage.StartAnimation(myAnimation);
            };
            
        }
    }
}

