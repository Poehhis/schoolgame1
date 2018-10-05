using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BitsCollecting : MonoBehaviour {

    RoombaController roombacontroller;
    public bool enter = true;
    public GameObject mesh0;
    public GameObject mesh1;
	// Use this for initialization
	void Start () {
        MeshSelector();
	}
	
	// Update is called once per frame
	void Update () {
        // bits rotate from start
        transform.Rotate(0.0f, -40.0f * Time.deltaTime, 0.0f);
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Roomba")
        {
            Debug.Log("Bit hit !");
            //other.GetComponent<RoombaController>().bits -- ;
            Destroy(gameObject);
        }
    }
    
    //select mesh 1 or 0
    private void MeshSelector()
    {
        Mesh mesh = GetComponent<MeshFilter>().sharedMesh;

        int rand = Random.Range(1, 100);
        //Debug.Log(rand);
        if (rand % 2 == 1)
        {
            mesh = mesh1.GetComponent<MeshFilter>().sharedMesh;
        }
        if (rand % 2 == 0)
        {
            mesh = mesh0.GetComponent<MeshFilter>().sharedMesh;
        }

        
        
        //gameObject.GetComponent<MeshFilter>().mesh = mesh;
        GetComponent<MeshFilter>().sharedMesh = mesh;

    }
}
