using System;
using StansAssets.SceneManagement;
using UnityEngine;

namespace StansAssets.SceneManagement
{
   public class GameAppState : IApplicationState<AppState>
   {
      public delegate void ChangeStateDelegate(string name, string action);

      public static ChangeStateDelegate OnChangeStateDelegate;
      
      private IApplicationState<AppState> _applicationStateImplementation;

      public void ChangeState(StackChangeEvent<AppState> evt, IProgressReporter reporter)
      {
         switch (evt.Action)
         {
            case StackAction.Added:
               Debug.Log("StackAction.Added");
               OnChangeStateDelegate?.Invoke("Game", "Added");
               break;
            case StackAction.Paused:
               Debug.Log("StackAction.Paused");
               OnChangeStateDelegate?.Invoke("Game", "Paused");
               break;
            case StackAction.Resumed:
               OnChangeStateDelegate?.Invoke("Game", "Resumed");
               Debug.Log("StackAction.Resumed");
               break;
            case StackAction.Removed:
               Debug.Log("StackAction.Removed");
               OnChangeStateDelegate?.Invoke("Game", "Removed");
               break;
            default:
               Debug.Log("evt.Action not found");
               break;
         }
         
         reporter.SetDone();
      }
   }
}
