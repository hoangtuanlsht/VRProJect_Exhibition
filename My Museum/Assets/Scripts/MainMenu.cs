using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartButton()
    {
        SceneManager.LoadScene("SceneExhibiton");
    }
    public void QuitButton()
    {
        Application.Quit();
    }
}
