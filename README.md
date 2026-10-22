Eliot's Split Tracker

Eliot's Split Tracker is a personal workout management application designed to help users track and cycle through their recurring fitness routines (such as a Push/Pull/Legs split). It features a modern, dark-themed UI with orange accents and keeps track of your current and upcoming workout days.

🛠 Tech Stack

Based on the current implementation, this project utilizes:

C# & .NET - Core application logic.

Blazor - Frontend framework and component architecture.

.NET MAUI (Inferred) - Cross-platform device storage integration (Preferences.Default).

Tailwind CSS - Utility-first CSS framework used for styling the responsive, dark-mode UI.

✨ Current Features

Routine Management: Utilizes a Queue-based system to cycle through workout days. When a cycle finishes, it automatically resets to the beginning.

Default Split: Currently initializes with a standard "Push", "Pull", "Legs" routine.

Dashboard UI: Displays "Today's Focus" and has placeholders for the "Up Next" workout.

Local Storage: Includes functionality to save and load the current state of the workout split directly to the device so progress isn't lost between sessions.

📁 Project Structure

The project currently separates concerns into Views and Models:

StartUpPage.razor & StartUpPage.razor.cs (View namespace): Handles the UI layout, styling, and data binding.

WorkoutSplit.cs (Model namespace): Contains the core business logic, including the workout queue, cycle advancement, and device persistence.

🚧 Work in Progress (Next Steps)

Wire up "Up Next" UI: Implement the getNextFocus() logic in the code-behind and bind it to the <h1 @bind=""></h1> element in the UI.

Button Actions: Connect the "Setup" and "Next" buttons to their respective methods (e.g., triggering WorkoutDone() and refreshing the UI).

Dynamic Customization: Build out the "Setup" page to allow users to add/remove custom days rather than hardcoding "Push/Pull/Legs".
