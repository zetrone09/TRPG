using UnityEngine;
using UnityEngine.SceneManagement;

public class UserInterfaceManager : MonoBehaviour
{
    int sceneWorldindex = 1;

    public void NewGame()
    {
        SceneManager.LoadSceneAsync(sceneWorldindex);
    }
    public void LoadGame()
    {

    }
}
