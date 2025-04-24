using BindablePropertyGenerator.Attributes;

namespace ReusableControlsTest.Controls;

public partial class LifeCard : ContentView
{
    public LifeCard()
    {
        InitializeComponent();
    }

    [GenerateBindableProperty(typeof(string))]
    public static readonly BindableProperty TitleProperty = CreateBindableProperty(nameof(Title), "");

    [GenerateBindableProperty(typeof(string))]
    public static readonly BindableProperty DescriptionProperty = CreateBindableProperty(nameof(Description), "");

    [GenerateBindableProperty(typeof(string))]
    public static readonly BindableProperty ImageUriProperty = CreateBindableProperty(nameof(ImageUri), "");

    [GenerateBindableProperty(typeof(bool))]
    public static readonly BindableProperty IsCompactLayoutProperty = CreateBindableProperty(nameof(IsCompactLayout), false);
}