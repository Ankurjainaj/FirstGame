using UnityEngine;

public class endline : MonoBehaviour

{
    public gamemanager gameManager;

    void OnTriggerEnter ()
    {

        gameManager.CompleteLevel();
    }

}
