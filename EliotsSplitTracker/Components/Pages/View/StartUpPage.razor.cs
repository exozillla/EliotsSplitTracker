using EliotsSplitTracker.Components.Pages.Model;

namespace EliotsSplitTracker.Components.Pages.View;

public partial class StartUpPage
{
    private WorkoutSplit split;

    private string todaysFocus;

    public StartUpPage()
    {
        split = new WorkoutSplit();
        
        split.AddToSplit("Push");
        split.AddToSplit("Pull");
        split.AddToSplit("Legs");

        todaysFocus = split.GetCurrentWorkOut();
    }

    // public string getNextFocus()
    // {
    //     
    // }
    
}