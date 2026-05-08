using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenTranslate : MonoBehaviour
{
    public void LoadNewLevel(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }
}
