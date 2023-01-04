using ReactiveUI;
using SampleRoot.SampleReactiveProject.ViewModel;

namespace SampleRoot.SampleReactiveProject.View;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : ReactiveWindow<MainWindowViewModel>
{
    public MainWindow()
    {
        InitializeComponent();
    }
}
