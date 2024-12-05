using System.Windows.Controls;
using System.Windows;

namespace IntroWPF
{
    class Clicker
    {
        private int _clicks;
        private readonly Label _label;
        public StackPanel Panel { get; }

        public Clicker()
        {
            var button = new Button { Content = "Klikk" };
            button.Click += ButtonClick;
            _label = new Label { Content = "0" };
            Panel = new StackPanel {Orientation = Orientation.Horizontal};
            Panel.Children.Add(_label);
            Panel.Children.Add(button);
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            _clicks++;
            _label.Content = _clicks;
        }
    }
}
