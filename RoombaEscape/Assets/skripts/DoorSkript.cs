using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSkript : MonoBehaviour {

    private Vector3 zMove = new Vector3(0, 0, 2.1f);
    private RoombaController roombaController;
    private int bits;
    public GameObject player;
    public GameObject door;
    private bool allCollected = false;
	
    // Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {

        //Debug.Log("bit count: " + bits);
        bits = player.GetComponent<RoombaController>().bits;
        if ( bits <= 0 && allCollected == false)
        {
            if (door.name == "LeftDoor")
            {
                door.transform.position = door.transform.position - zMove;
            }
            if (door.name == "RightDoor")
            {
                door.transform.position = door.transform.position + zMove;
            }
            allCollected = true;
        }
	}
}
