using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    private const System.String V = "MainScene";

    public void Play()
    {
        SceneManager.LoadScene(V);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
