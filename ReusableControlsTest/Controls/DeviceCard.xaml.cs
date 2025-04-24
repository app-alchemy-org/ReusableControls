using BindablePropertyGenerator.Attributes;
using System.Windows.Input;

namespace ReusableControlsTest.Controls;

public partial class DeviceCard : ContentView
{
    public DeviceCard()
    {
        InitializeComponent();
    }

    [GenerateBindableProperty(typeof(string))]
    public static readonly BindableProperty TitleProperty = CreateBindableProperty(nameof(Title), "");

    [GenerateBindableProperty(typeof(string))]
    public static readonly BindableProperty NameProperty = CreateBindableProperty(nameof(Name), "");

    [GenerateBindableProperty(typeof(string))]
    public static readonly BindableProperty StatusProperty = CreateBindableProperty(nameof(Status), "");

    [GenerateBindableProperty(typeof(string))]
    public static readonly BindableProperty IconUriProperty = CreateBindableProperty(nameof(IconUri), "");

    [GenerateBindableProperty(typeof(ICommand))]
    public static readonly BindableProperty CommandProperty = CreateBindableProperty<ICommand?>(nameof(Command), null);

    [GenerateBindableProperty(typeof(object))]
    public static readonly BindableProperty CommandParameterProperty = CreateBindableProperty<object?>(nameof(CommandParameter), null);
}