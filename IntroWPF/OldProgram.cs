using System.Windows;
using System.Windows.Controls;

namespace IntroWPF
{
    class OldProgram
    {
        private static int _clicks;
        private static Label _label;

        [STAThread]
        public static void Mainx(string[] args)
        {
            var app = new Application();
            var window = new Window();
            var button = new Button { Content = "Klikk" };
            button.Click += ButtonClick;
            _label = new Label { Content = "0" };
            var panel = new StackPanel();
            panel.Children.Add(_label);
            panel.Children.Add(button);
            window.Content = panel;
            app.Run(window);
        }

        private static void ButtonClick(object sender, RoutedEventArgs e)
        {
            _clicks++;
            _label.Content = _clicks;
        }

        //{
        //    Width = 400,
        //    Height = 400,
        //    Title = "Min første WPF-app"
        //};
    }
}
