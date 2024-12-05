using System.Windows.Controls;
using System.Windows;

namespace IntroWPF
{
    internal class ClickerPanel : StackPanel
    {
        private int _clicks;
        private readonly Label _label;

        public ClickerPanel()
        {
            var button = new Button { Content = "Klikk" };
            button.Click += ButtonClick;
            _label = new Label { Content = "0" };
            Orientation = Orientation.Horizontal;
            Children.Add(_label);
            Children.Add(button);
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            _clicks++;
            _label.Content = _clicks;
        }
    }
}
