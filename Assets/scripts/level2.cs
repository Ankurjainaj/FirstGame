using UnityEngine;
using UnityEngine.SceneManagement;

public class level2 : MonoBehaviour {

	public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
