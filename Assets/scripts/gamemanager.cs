using UnityEngine;
using UnityEngine.SceneManagement;

public class gamemanager : MonoBehaviour
{
    bool gamehasended = false;

    public float restartDelay = 2f;

    public GameObject completeLevelUI;

    public void CompleteLevel ()
    {
        completeLevelUI.SetActive(true);
        Debug.Log("LEVEL WON!!");
    }
    public void EndGame()

    {

        if (gamehasended == false)
        {
            gamehasended = true;
            Debug.Log("GAME OVER");
            Invoke("Restart" , restartDelay);//Restarting the game
        }
    }
    void Restart()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}

