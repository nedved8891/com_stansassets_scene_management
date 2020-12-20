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
            Debug.Log("StackAction.Added");
            break;
         case StackAction.Removed:
            Debug.Log("StackAction.Removed");
            break;
         case StackAction.Paused:
            Debug.Log("StackAction.Paused");
            break;
         case StackAction.Resumed:
            Debug.Log("StackAction.Resumed");
            break;
         default:
            Debug.Log("evt.Action not found");
            break;
      }
      
      reporter.SetDone();
   }
}
