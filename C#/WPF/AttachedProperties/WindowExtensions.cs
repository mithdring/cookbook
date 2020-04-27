namespace Namespace
{
    public static class WindowExtensions
    {
        public static readonly DependencyProperty IsOpenProperty = DependencyProperty.RegisterAttached(
            "IsOpen",
            typeof(bool),
            typeof(WindowExtensions),
            new PropertyMetadata(true, IsOpenCallback));

        private static void IsOpenCallback(DependencyObject sender, DependencyPropertyChangedEventArgs args)
        {
            if (!(bool)args.NewValue)
                (target as System.Windows.Window)!.Close();
        }

        public static void SetIsOpen(UIElement element, bool value)
            => element.SetValue(IsOpenProperty, value);

        public static bool GetIsOpen(UIElement element)
            => (bool)element.GetValue(IsOpenProperty);
    }
}