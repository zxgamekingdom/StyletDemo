using System;
using System.Windows;
using Stylet;

namespace WpfApp1
{
    public class MainViewModel : Screen, IDisposable
    {
        public MainViewModel()
        {
            var s = $@"{GetHashCode()} {GetType().Name} Ctor";
            s.WriteLine();
        }

        public void ShowTest()
        {
            var testViewModel = new TestViewModel();
            Bootstrapper.WindowManager.ShowWindow(testViewModel, this);
        }

        public void Dispose()
        {
            var s = $@"{GetHashCode()} {GetType().Name} {nameof(Dispose)}";
            s.WriteLine();
            MessageBox.Show(s);
        }
    }
}