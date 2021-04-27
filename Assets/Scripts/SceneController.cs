using UnityEngine;
using sm = UnityEngine.SceneManagement.SceneManager;

public class SceneController : MonoBehaviour
{
    public static void MenuScene()
    {
        sm.LoadScene("Menu");
    }

    public static void GameScene()
    {
        sm.LoadScene("Game");
    }

    public static void FinalScene()
    {
        sm.LoadScene("finalScreen");
    }

    public static void ExitGame()
    {
        Application.Quit();
    }
}
