using StansAssets.SceneManagement;
using UnityEngine;

public class MainMenuAppState : IApplicationState<AppState>
{
   private IApplicationState<AppState> _applicationStateImplementation;

   public void ChangeState(StackChangeEvent<AppState> evt, IProgressReporter reporter)
   {
      switch (evt.Action)
      {
         case StackAction.Added:
            Debug.Log("StackAction.Added: " + evt.State + " " + evt.Action);
            break;
         case StackAction.Paused:
            Debug.Log("StackAction.Paused: "  + evt.State + " " + evt.Action);
            break;
         case StackAction.Resumed:
            Debug.Log("StackAction.Resumed: " + evt.State + " " + evt.Action);
            break;
         default:
            Debug.Log("StackAction.Removed: " + evt.State + " " + evt.Action);
            break;
      }
      
      reporter.SetDone();
   }
}
