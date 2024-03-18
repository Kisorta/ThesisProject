using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnClick : MonoBehaviour
{
    public string sceneNameToLoad; // Name of the scene to load

    // This method is called when the button is clicked
    public void LoadScene()
    {
        SceneManager.LoadScene(sceneNameToLoad); // Load the scene specified by sceneNameToLoad
    }
}
