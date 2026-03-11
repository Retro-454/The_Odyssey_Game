using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuControler : MonoBehaviour
{
    public void OnStartClick()
    {
        SceneManager.LoadScene("oddyssy");
    }
    public void OnExitClick()
    {
#if UNITY_EDITOR
UnityEditor.EditorApplication.isPlaying =false;
#endif
        Application.Quit();
    }

}
