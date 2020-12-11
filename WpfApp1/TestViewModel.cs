using System;
using System.Windows;
using Stylet;

namespace WpfApp1
{
    public class TestViewModel : Screen, IDisposable
    {
        public TestViewModel()
        {
            var s = $@"{GetHashCode()} {GetType().Name} Ctor";
            s.WriteLine();
        }

        public void ShowTest()
        {
            var mainViewModel = new MainViewModel();
            Bootstrapper.WindowManager.ShowWindow(mainViewModel);
        }

        public void Dispose()
        {
            var s = $@"{GetHashCode()} {GetType().Name} {nameof(Dispose)}";
            s.WriteLine();
            MessageBox.Show(s);
        }
    }
}