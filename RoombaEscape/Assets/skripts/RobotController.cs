using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class RobotController : MonoBehaviour {

    public GameObject goal;
    public float lookradius = 10f;
    private int lvl;
    NavMeshAgent agent;
    Transform target;
    
    // Use this for initialization
    void Start () {
       target = GameObject.FindGameObjectWithTag("Player").transform;
        agent = GetComponent<NavMeshAgent>();
        lvl = goal.GetComponent<GoalSkript>().lvl;
        agent.speed = agent.speed * lvl;
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Roomba")
        {
            Debug.Log("Player Hit !");
           
            SceneManager.LoadScene("OriginalLevel");
        }
    }

    // Update is called once per frame
    void Update () {
        float distance = Vector3.Distance(target.position, transform.position);

        if (distance <= lookradius)
        {
            agent.SetDestination(target.position);
        }
	}

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookradius);
    }

}
