using System.Windows.Input;

namespace ReusableControlsTest.Controls;

public partial class AbsorbTap : ContentView
{
    public AbsorbTap()
    {
        InitializeComponent();
    }

    public static readonly BindableProperty CommandProperty = CreateBindableProperty<ICommand?>(nameof(Command), null);

    public ICommand? Command
    {
        get => (ICommand?)GetValue(CommandProperty);
        set => SetValue(CommandProperty, value);
    }

    public static readonly BindableProperty CommandParameterProperty = CreateBindableProperty<object?>(nameof(CommandParameter), null);

    public object? CommandParameter
    {
        get => (object?)GetValue(CommandParameterProperty);
        set => SetValue(CommandParameterProperty, value);
    }

    private static BindableProperty CreateBindableProperty<T>(
string propertyName, T defaultValue, BindableProperty.BindingPropertyChangedDelegate? propertyChanged = null, BindingMode defaultBindingMode = BindingMode.TwoWay)
    {
        return BindableProperty.Create(
            propertyName: propertyName,
            returnType: typeof(T),
            declaringType: typeof(AbsorbTap),
            defaultValue: defaultValue,
            defaultBindingMode: defaultBindingMode,
            propertyChanged: propertyChanged
        );
    }
}