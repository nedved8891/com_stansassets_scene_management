using UnityEngine;

public class LandingController : MonoBehaviour
{
    private bool isPause;
    
    // Start is called before the first frame update
    private void Start()
    {
        GameState.Init();
    }

    public void MainMenu()
    {
        GameState.State.Set(AppState.MainMenu);  
    }
    
    public void Game()
    {
        GameState.State.Set(AppState.Game);  
    }
    
    public void Pause()
    {
        if (!isPause)
        {
            GameState.State.Push(AppState.Pause);
            isPause = true;
        }
        else
        {
            isPause = false;
            GameState.State.Push(AppState.Game); 
        }
    }
}
