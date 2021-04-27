using UnityEngine;

public class MenuCanvasController : MonoBehaviour
{
    public void PlayButton()
    {
        SceneController.GameScene();
    }

    public void ExitButton()
    {
        SceneController.ExitGame();
    }

    public void BackButton()
    {
        SceneController.MenuScene();
    }
}
