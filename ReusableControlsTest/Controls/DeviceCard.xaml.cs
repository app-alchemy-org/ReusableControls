namespace ReusableControlsTest.Controls;

public partial class DeviceCard : ContentView
{
    public DeviceCard()
    {
        InitializeComponent();
    }

    public static readonly BindableProperty TitleProperty = CreateBindableProperty(nameof(Title), "");

    public string Title
    {
        get => (string)GetValue(TitleProperty);
        set => SetValue(TitleProperty, value);
    }

    public static readonly BindableProperty NameProperty = CreateBindableProperty(nameof(Name), "");

    public string Name
    {
        get => (string)GetValue(NameProperty);
        set => SetValue(NameProperty, value);
    }

    public static readonly BindableProperty StatusProperty = CreateBindableProperty(nameof(Status), "");

    public string Status
    {
        get => (string)GetValue(StatusProperty);
        set => SetValue(StatusProperty, value);
    }

    public static readonly BindableProperty IconUriProperty = CreateBindableProperty(nameof(IconUri), "");

    public string IconUri
    {
        get => (string)GetValue(IconUriProperty);
        set => SetValue(IconUriProperty, value);
    }

    private static BindableProperty CreateBindableProperty<T>(
    string propertyName, T defaultValue, BindableProperty.BindingPropertyChangedDelegate propertyChanged = null, BindingMode defaultBindingMode = BindingMode.TwoWay)
    {
        return BindableProperty.Create(
            propertyName: propertyName,
            returnType: typeof(T),
            declaringType: typeof(DeviceCard),
            defaultValue: defaultValue,
            defaultBindingMode: defaultBindingMode,
            propertyChanged: propertyChanged
        );
    }
}