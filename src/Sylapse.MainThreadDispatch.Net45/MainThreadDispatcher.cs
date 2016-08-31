using System;

namespace Sylapse.MainThreadDispatch
{
    public class MainThreadDispatcher
    {
        public static MainThreadDispatcher Instance = new MainThreadDispatcher();

        public MainThreadDispatcher()
        {
        }

        public void Execute(Action action)
        {
            action();
        }
    }
}