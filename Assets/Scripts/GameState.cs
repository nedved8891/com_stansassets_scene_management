using System;
using StansAssets.SceneManagement;
using UnityEngine;

public class GameState : MonoBehaviour
{
    public static GameStateChangDelegate StateDelegate { get; private set; } = null;

    public class GameStateChangDelegate : IApplicationStateDelegate<AppState>
    {
        public event Action OnApplicationStateChanged;

        public GameStateChangDelegate(IApplicationStateStack<AppState> stateStack)
        {
            stateStack.AddDelegate(this);
        }

        public void OnApplicationStateWillChanged(StackOperationEvent<AppState> e)
        {
            
        }

        public void ApplicationStateChangeProgressChanged(float progress, StackChangeEvent<AppState> e)
        {
           
        }

        public void ApplicationStateChanged(StackOperationEvent<AppState> e)
        {
            
        }
    }
    
    public static IApplicationStateStack<AppState> State { get; } = new ApplicationStateStack<AppState>();

    internal static void Init()
    {
        StateDelegate = new GameStateChangDelegate(State);

        State.RegisterState(AppState.MainMenu, new MainMenuAppState());
        State.RegisterState(AppState.Game, new GameAppState());
    }
}
