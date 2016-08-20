# MainThreadDispatch

A helper for MvvmLight to ensure that RaisePropertyChanged is called on the UI thread.

In your view models, instead of using these usual methods.

```
Set (() => MyProperty, ref _myProperty, value)
Set ("MyProperty", ref _myProperty, value)
Set (ref _myProperty, value)
```

Add `using Sylapse.MainThreadDispatch;` to your view model class and use the following extension methods.

```
this.DispatchSet (() => MyProperty, ref _myProperty, value)
this.DispatchSet ("MyProperty", ref _myProperty, value)
this.DispatchSet (ref _myProperty, value)
```

If you just want to execute some code on the UI thread then use

```
this.Dispatch (() => {
    // Code to execute on the UI thread
});
```

## Nuget

https://www.nuget.org/packages/Sylapse.MainThreadDispatch

Add MainThreadDispatch to your PCL and platform projects. Currently supported platforms are:

- Xamarin.Android
- Xamarin.iOS

UWP and other Windows platforms coming soon. Pull requests welcome.
