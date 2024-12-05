using System.Windows;
using System.Windows.Controls;

namespace IntroWPF
{
    class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            var app = new Application();
            var window = new Window();

            var clicker1 = new ClickerPanel();
            var clicker2 = new ClickerPanel();
            var clicker3 = new ClickerPanel();

            var panel = new StackPanel();
            panel.Children.Add(clicker1);
            panel.Children.Add(clicker2);
            panel.Children.Add(clicker3);

            //var clicker1 = new Clicker();
            //var clicker2 = new Clicker();
            //var clicker3 = new Clicker();

            //var panel = new StackPanel();
            //panel.Children.Add(clicker1.Panel);
            //panel.Children.Add(clicker2.Panel);
            //panel.Children.Add(clicker3.Panel);

            window.Content = panel;
            app.Run(window);
        }
    }
}
