using UnityEngine.SceneManagement;
using UnityEngine;

public class TutorialManager : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown("q"))
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
