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
            throw new PlatformNotSupportedException("Make sure Sylapse.MainThreadDispatcher is added to your platform project. If it is then you are probably using an unsupported platform, please visit https://github.com/Sylapse/MainThreadDispatch to find out about supporting other platforms");
        }
    }
}