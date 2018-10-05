using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowTransform : MonoBehaviour {

    public GameObject player;
    public GameObject arrowhead;
    MouseToWorld mouseToWorld;
    float anglPM;
    float anglAAh;
    Vector3 mousePos;
    Vector3 plrPos;
    Vector3 arwPos;
    Vector3 arwhdPos;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
        mousePos = new Vector3(Camera.main.GetComponent<MouseToWorld>().point.x, 0.0f,Camera.main.GetComponent<MouseToWorld>().point.z);
        plrPos = new Vector3(player.transform.position.x, 0.0f,player.transform.position.z);
        arwPos = new Vector3(transform.position.x, transform.position.z, 0.0f);
        arwhdPos = new Vector3(arrowhead.transform.position.x, 0.0f , arrowhead.transform.position.z);
        

        Debug.Log("mouse: " + mousePos);
        Debug.Log("arrowhead: " + arwhdPos);
        Debug.Log("player: " + plrPos);
        Debug.Log("arrow: " + arwPos);
       

        anglPM = Vector3.Angle(plrPos, mousePos);
        anglAAh = Vector3.Angle(arwPos, arwhdPos);

        //Debug.Log("player mouse: " + anglPM);
        //Debug.Log("arrow arrowhead: " + anglAAh);

        if (anglAAh < anglPM)
        {
            transform.Rotate(new Vector3(0.0f, 0.0f, 2.0f));
        }
        if (anglAAh > anglPM)
        {
            transform.Rotate(new Vector3(0.0f, 0.0f, -2.0f));
        }
        

    }
}
