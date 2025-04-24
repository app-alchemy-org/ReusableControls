using BindablePropertyGenerator.Attributes;
using System.Windows.Input;

namespace ReusableControlsTest.Controls;

public partial class SwitchControl : ContentView
{
	public SwitchControl()
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
    public static readonly BindableProperty IsToggledProperty = CreateBindableProperty(nameof(IsToggled), false);
}