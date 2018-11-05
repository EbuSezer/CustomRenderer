
using Xamarin.Forms;

namespace CustomRenderer.Views
{
    public class MainPage : ContentPage
	{
		public MainPage ()
		{
            CustomEntry name = new CustomEntry();
            name.Placeholder = "İsminiz";
            StackLayout myLayout = new StackLayout();
            myLayout.Children.Add(name);
            Content = myLayout;
		}
	}
}