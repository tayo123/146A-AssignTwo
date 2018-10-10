using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialComplete : MonoBehaviour {

    public void LoadNextLevel()
    {
        SceneManager.LoadScene("Menu");
    }
}
