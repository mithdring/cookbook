namespace Namespace
{
    public static class DialogExtensions
    {
        public static readonly DependencyProperty ResultProperty = DependencyProperty.RegisterAttached(
            "Result",
            typeof(bool?),
            typeof(DialogExtensions),
            new PropertyMetadata(null, ResultCallback));

        private static void ResultCallback(DependencyObject sender, DependencyPropertyChangedEventArgs args)
            => (sender as System.Windows.Window)!.DialogResult = (bool?)args.NewValue;

        public static void SetResult(UIElement element, bool value)
            => element.SetValue(ResultProperty, value);

        public static bool GetResult(UIElement element)
            => (bool)element.GetValue(ResultProperty);
    }
}