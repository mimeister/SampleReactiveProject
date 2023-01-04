using ReactiveUI;

namespace SampleRoot.SampleReactiveProject.ViewModel;

public class MainWindowViewModel : ReactiveObject
{
    string title = "I Am bound";
    public string Title
    {
        get => title;
        set
        {
            this.RaiseAndSetIfChanged(ref title, value);
        }
    }
}
