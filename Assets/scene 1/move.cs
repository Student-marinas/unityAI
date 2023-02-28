using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class move : MonoBehaviour

{
    public NavMeshAgent thingy1;
    public Transform FinishLine;
    public Transform FinishLine2;

    // Start is called before the first frame update
    void Start()
    {
        thingy1 = GetComponent<NavMeshAgent>();
        thingy1.destination = FinishLine.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (thingy1.remainingDistance <= thingy1.stoppingDistance)
        {
            thingy1.destination = FinishLine2.position;
        }
    }
}
