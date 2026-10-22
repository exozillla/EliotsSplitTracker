using System.Text.Json;
namespace EliotsSplitTracker.Components.Pages.Model;

public class WorkoutSplit
{
    public Queue<string> CurrentSplit {get; private set;}
    private List<string> MySplit { get; set; }
    private int splitLength;
    private int position;
    
    public WorkoutSplit()
    {
        CurrentSplit = new Queue<string>();
        MySplit = new List<string>();
        position = 0;
    }

    public void AddToSplit(string workOutDay)
    {
        CurrentSplit.Enqueue(workOutDay);
        MySplit.Add(workOutDay);
        splitLength++;
    }

    public string GetCurrentWorkOut()
    {
        if (CurrentSplit.Count > 0)
        {
            return CurrentSplit.Peek();
        }

        return "No Workouts Added!";
    }

    public string GetNextWorkout()
    {
        if (CurrentSplit.Count > 0)
        {
            return CurrentSplit.Dequeue();
        }
        return CurrentSplit.Dequeue();
    }

    public void WorkoutDone()
    {
        if (CurrentSplit.Count > 0)
        {
            CurrentSplit.Dequeue();
            if (CurrentSplit.Count == 0) 
            {
                foreach (String s in MySplit)
                {
                    CurrentSplit.Enqueue(s);
                }
            }
        }
    }
    
    public void SaveToDevice()
    {
        var stateJson = JsonSerializer.Serialize(this.CurrentSplit);
        Preferences.Default.Set("current_split_save", stateJson);
    }

    public void LoadFromDevice()
    {
        var savedJson = Preferences.Default.Get("current_split_save", string.Empty);
        if (!string.IsNullOrEmpty(savedJson))
        {
            CurrentSplit = JsonSerializer.Deserialize<Queue<string>>(savedJson) ?? new Queue<string>();
        }
    }
}