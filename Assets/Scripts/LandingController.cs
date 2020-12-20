using UnityEngine;

public class LandingController : MonoBehaviour
{
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
}
