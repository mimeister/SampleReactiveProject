using ReactiveUI;

namespace SampleRoot.SampleReactiveProject.View;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow
{
    public MainWindow()
    {
        InitializeComponent();
        ViewModel = new();
        this.WhenActivated(d =>
        {
            this.OneWayBind(ViewModel, vm => vm.Title, v => v.Title.Text);
        });
    }
}
