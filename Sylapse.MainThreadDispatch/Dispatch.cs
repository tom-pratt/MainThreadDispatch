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
        public static bool Dispatch<T>(this ObservableObject observableObject, SetFunc<T> set, Expression<Func<T>> propertyExpression, ref T field, T newValue)
        {
#if PORTABLE
            throw new PlatformNotSupportedException("Please visit the Sylapse Github to find out about supporting other platforms");
#else
            return set(propertyExpression, ref field, newValue);
#endif
        }
    }
}
