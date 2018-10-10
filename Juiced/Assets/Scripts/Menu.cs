using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    public void StartGame () {
        SceneManager.LoadScene("Level01");
    }

    public void StartTutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }
}
