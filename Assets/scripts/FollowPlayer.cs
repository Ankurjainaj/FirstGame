using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public Transform player;//add in unity the player in the component of main camera
    public Vector3 offset;
	
	// Update is called once per frame
	void Update ()
    {
        transform.position = player.position + offset;

	}
}
