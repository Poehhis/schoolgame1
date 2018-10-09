using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalSkript : MonoBehaviour {

    // Use this for initialization
    static int level = 1;
    public int lvl;
	void Start () {
        Debug.Log(level);
        lvl = level;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Roomba")
        {
            Debug.Log("You WIN!");
            level++;
            SceneManager.LoadScene("OriginalLevel");
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
