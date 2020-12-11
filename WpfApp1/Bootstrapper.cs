using Stylet;
using StyletIoC;

namespace WpfApp1
{
    public class Bootstrapper : Bootstrapper<TestViewModel>
    {
        public static IWindowManager WindowManager { get; private set; }

        protected override void Launch()
        {
            WindowManager = Container.Get<IWindowManager>();
            base.Launch();
        }
    }
}