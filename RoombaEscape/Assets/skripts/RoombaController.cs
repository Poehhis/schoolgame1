using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoombaController : MonoBehaviour
{
    private GameObject bit;
    private GameObject[] bitsList;
    public GameObject target;
    public GameObject goal;
    bool alive = true;
    public float dist = 0f;
    public int bits = 10;
    private GUIStyle guiStyle = new GUIStyle();
    public int level;
    public GoalSkript goalSkript;
    // Use this for initialization
    void Start ()
    {
        level = target.GetComponent<GoalSkript>().lvl;
        
    }
    void OnGUI()
    {
        guiStyle.fontSize = 50;
        guiStyle.stretchHeight = true;
        guiStyle.stretchWidth = true;
        guiStyle.normal.textColor = Color.yellow;
        
        //GUILayout.BeginArea(new Rect(20, 20, 250, 120));

        GUILayout.Label("Bits left: " + bits +"   Current Level: " + level , guiStyle );
        //GUILayout.EndArea();
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
