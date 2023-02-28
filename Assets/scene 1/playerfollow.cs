using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class playerfollow : MonoBehaviour
{
    public NavMeshAgent thingy1;
    public NavMeshAgent followplayer;
    

    // Start is called before the first frame update
    void Start()
    {
        thingy1 = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        thingy1.SetDestination(followplayer.transform.position);

    }


}
