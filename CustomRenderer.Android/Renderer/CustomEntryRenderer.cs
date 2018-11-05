using CustomRenderer;
using CustomRenderer.Droid.Renderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: Xamarin.Forms.ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]
namespace CustomRenderer.Droid.Renderer
{
    public class CustomEntryRenderer:EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if(Control != null)
            {
                Control.SetBackgroundColor(Android.Graphics.Color.Yellow);
                Control.SetTextColor(Android.Graphics.Color.Blue);
            }
        }
    }
}