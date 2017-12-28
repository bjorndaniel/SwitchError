using Ooui;
using Xamarin.Forms;

namespace SwitchError
{
    public class SwitchPage
    {
        Ooui.Element Create()
        {
            var layout = new StackLayout();
            var label = new Xamarin.Forms.Label
            {
                Text = "Switch state goes here",
                HorizontalTextAlignment = TextAlignment.Center
            };
            var sw = new Switch
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };
            sw.Toggled += (sender, args) =>
            {
                label.Text = $"Switch state is :{((Switch)sender).IsToggled}";
            };
            layout.Children.Add(label);
            layout.Children.Add(sw);
            return new ContentPage
            {
                Content = layout
            }.GetOouiElement();
        }

        public void Publish()
        {
            UI.Publish("/switch", Create);
        }
    }
}