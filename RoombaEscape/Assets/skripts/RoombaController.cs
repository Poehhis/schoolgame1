using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoombaController : MonoBehaviour
{
    private GameObject bit;
    private GameObject[] bitsList;
    public GameObject target;
    bool alive = true;
    public float dist = 0f;
    public int bits = 10;
    // Use this for initialization
    void Start ()
    {
        
        
    }
	
	// Update is called once per frame
	void Update ()
    {
        //counting bits
        bitsList = GameObject.FindGameObjectsWithTag("Bit");
        bits = bitsList.Length;

        //destroy if collided with robots
        if (alive == false)
        {
            Destroy(gameObject);
        }

       
        
    }

    

    
}
