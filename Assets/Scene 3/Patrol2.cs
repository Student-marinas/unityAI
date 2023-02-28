using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Patrol2 : MonoBehaviour
{

    public Transform[] points;
    public NavMeshAgent agent;
    public int DestinationPoints = 0;
    public float StoppingDistance;
    public float Radius;
    



    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.autoBraking = false;

        GotoNextpoint();
    }

    public void GotoNextpoint()
    {
        if (points.Length == 0)
        {
            return;
        }

        agent.destination = points[DestinationPoints].position;

        DestinationPoints = (DestinationPoints + 1) % points.Length;
    }

    // Update is called once per frame
    void Update()
    {
        if (!agent.pathPending && agent.remainingDistance < StoppingDistance)
        {
            GotoNextpoint();
        }

        


    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.white;
        Gizmos.DrawWireSphere(transform.position, Radius); 
    }
}
