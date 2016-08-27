using System;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Sylapse.MainThreadDispatch
{
    public class MainThreadDispatcher
    {
        public static MainThreadDispatcher Instance = new MainThreadDispatcher();

        public MainThreadDispatcher()
        {
        }

        public async void Execute(Action action)
        {
            await CoreApplication.MainView.CoreWindow.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                action();
            });
        }
    }
}