using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseToWorld : MonoBehaviour {

    private Camera cam;
    public Vector3 point = new Vector3();
    public float dist = 0f;
    public GameObject character;
    public float maxMoveDist = 4.0f;
    public float minMoveDist = 1.0f;
    private float moveDist;
    public Rigidbody rb;
    //private RoombaController roombaController;
    public float moveMulti = 20.0f;
    
    
    // Use this for initialization
    void Start () {
        cam = Camera.main;
        rb = character.GetComponent<Rigidbody>();
    }

   /* void OnGUI()
    {
        
        Event currentEvent = Event.current;
        Vector2 mousePos = new Vector2();

        // Get the mouse position from Event.
        // Note that the y position from Event is inverted.

        mousePos.x = currentEvent.mousePosition.x;
        mousePos.y = cam.pixelHeight/2 - currentEvent.mousePosition.y;
       

        //Debug.Log("x " + mousePos.x);
        //Debug.Log("y " + mousePos.y);

        //point = cam.ScreenToWorldPoint(new Vector3(mousePos.x, cam.nearClipPlane, mousePos.y));

        GUILayout.BeginArea(new Rect(20, 20, 250, 120));
        GUILayout.Label("Screen pixels: " + cam.pixelWidth + ":" + cam.pixelHeight);
        GUILayout.Label("Mouse position: " + mousePos);
        GUILayout.Label("World position: " + point.ToString("F3"));
        GUILayout.EndArea();
    }*/

    // Update is called once per frame
    void Update () {

        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        Physics.Raycast(ray.origin, ray.direction, out hit);
        point = hit.point;
        point.y = 0.0f;

        //Debug.DrawRay(ray.origin, ray.direction * Vector3.Distance(cam.transform.position,point), Color.yellow);
        Debug.DrawRay(character.transform.position,point, Color.red);

        dist = Vector3.Distance(rb.transform.position,point);
        //Debug.Log(dist);
        
        //what happens when LMB is pressed down
        if (Input.GetMouseButtonDown(0))
        { 
            Shoot(rb, point);
        }
    }

    void Shoot(Rigidbody roomba, Vector3 mouse)
    {
        //character can only move on y = 0.1f
       
        
        moveDist = Vector3.Distance(roomba.transform.position, mouse);
        
        if (moveDist > maxMoveDist)
        {
            moveDist = maxMoveDist;
        }

        if (moveDist < minMoveDist)
        {
            moveDist = minMoveDist;
        }

        roomba.AddForce(1.0f +(mouse.x - roomba.transform.position.x) * moveDist * moveMulti, 0.1f ,1.0f + (mouse.z - roomba.transform.position.z) * moveDist* moveMulti);
        
        //roomba.transform.position = mouse;
    }
}
