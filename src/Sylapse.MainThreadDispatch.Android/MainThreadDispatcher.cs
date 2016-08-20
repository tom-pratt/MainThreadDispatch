using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Sylapse.MainThreadDispatch
{
    public class MainThreadDispatcher
    {
        public static MainThreadDispatcher Instance = new MainThreadDispatcher();

        Handler handler;
        long looperId;
        public MainThreadDispatcher()
        {
            this.handler = new Handler(Looper.MainLooper);
            looperId = Looper.MainLooper.Thread.Id;
        }

        public void Execute(Action action)
        {
            if (looperId > 0 && looperId == Java.Lang.Thread.CurrentThread().Id)
            {
                action();
                return;
            }

            handler.Post(() => {
                action();
            });
        }
    }
}