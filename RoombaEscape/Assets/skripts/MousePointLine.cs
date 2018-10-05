using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePointLine : MonoBehaviour {
    MouseToWorld mouseToWorld;
    public GameObject player;
    LineRenderer line;
    Vector3 mousePos;
    Vector3 playerPos;
    public float maxDist = 5.0f;
	// Use this for initialization
	void Start () {
        line = GetComponent<LineRenderer>();
	}
	
	// Update is called once per frame
	void Update () {

        mousePos = Camera.main.GetComponent<MouseToWorld>().point;
        mousePos.y = 0.1f;
        playerPos = player.transform.position;
        playerPos.y = 0.1f;

        Vector3 dir = mousePos - playerPos;
        float dist = Mathf.Clamp(Vector3.Distance(playerPos, mousePos), 0, maxDist);
        mousePos = playerPos + (dir.normalized * dist);
        line.SetPosition(0, playerPos);
        line.SetPosition(1, mousePos);
        
	}
}
