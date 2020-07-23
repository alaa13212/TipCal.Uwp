using MvvmCross.Platforms.Uap.Core;
using MvvmCross.Platforms.Uap.Views;

namespace TipCalc.Uwp
{
    public sealed partial class App
    {
        public App()
        {
            InitializeComponent();
        }
    }

    public abstract class TipCalcApp : MvxApplication<MvxWindowsSetup<Core.App>, Core.App>
    {

    }
}
