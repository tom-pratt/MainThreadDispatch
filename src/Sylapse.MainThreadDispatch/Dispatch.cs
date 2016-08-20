using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using GalaSoft.MvvmLight;

namespace Sylapse.MainThreadDispatch
{
    public delegate bool SetFunc<T>(Expression<Func<T>> propertyExpression, ref T field, T newValue);

    public static class DispatchExtensions
    {
        public static void Dispatch(this ObservableObject observableObject, Action action)
        {
#if PORTABLE
            throw new PlatformNotSupportedException("Make sure MainThreadDispatcher is added to your platform project. Otherwise, please visit the Sylapse.MainThreadDispatch Github page to find out about supporting other platforms");
#else
            MainThreadDispatcher.Instance.Execute(action);
#endif
        }
    }
}
