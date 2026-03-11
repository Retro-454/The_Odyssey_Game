using Unity.Cinemachine;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ending : MonoBehaviour
{
    public string sceneToLoad; // The name of the scene to load when the player reaches the ending
    public float triggerRadius = 10f; // The radius within which the player can trigger the ending

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ((collision.CompareTag("Player"))){
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
