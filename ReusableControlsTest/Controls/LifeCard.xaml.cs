namespace ReusableControlsTest.Controls;

public partial class LifeCard : ContentView
{
	public LifeCard()
	{
		InitializeComponent();
	}

    public static readonly BindableProperty TitleProperty = CreateBindableProperty(nameof(Title), "");

    public string Title
    {
        get => (string)GetValue(TitleProperty);
        set => SetValue(TitleProperty, value);
    }

    public static readonly BindableProperty DescriptionProperty = CreateBindableProperty(nameof(Description), "");

    public string Description
    {
        get => (string)GetValue(DescriptionProperty);
        set => SetValue(DescriptionProperty, value);
    }

    public static readonly BindableProperty ImageUriProperty = CreateBindableProperty(nameof(ImageUri), "");

    public string ImageUri
    {
        get => (string)GetValue(ImageUriProperty);
        set => SetValue(ImageUriProperty, value);
    }

    private static BindableProperty CreateBindableProperty<T>(
string propertyName, T defaultValue, BindableProperty.BindingPropertyChangedDelegate propertyChanged = null, BindingMode defaultBindingMode = BindingMode.TwoWay)
    {
        return BindableProperty.Create(
            propertyName: propertyName,
            returnType: typeof(T),
            declaringType: typeof(LifeCard),
            defaultValue: defaultValue,
            defaultBindingMode: defaultBindingMode,
            propertyChanged: propertyChanged
        );
    }
}