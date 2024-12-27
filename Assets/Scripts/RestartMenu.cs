using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartMenu : MonoBehaviour

   {
    public void Restartgame()
    {
        SceneManager.LoadSceneAsync(0);
    }
}

