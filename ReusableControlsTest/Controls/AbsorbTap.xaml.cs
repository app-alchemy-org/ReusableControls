using BindablePropertyGenerator.Attributes;
using System.Windows.Input;

namespace ReusableControlsTest.Controls
{
    public partial class AbsorbTap : ContentView
    {
        public AbsorbTap()
        {
            InitializeComponent();
        }

        [GenerateBindableProperty(typeof(ICommand))]
        public static readonly BindableProperty CommandProperty = CreateBindableProperty<ICommand?>(nameof(Command), null);

        [GenerateBindableProperty(typeof(object))]
        public static readonly BindableProperty CommandParameterProperty = CreateBindableProperty<object?>(nameof(CommandParameter), null);
    }
}