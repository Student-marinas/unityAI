using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; 

public class FolllowMouse : MonoBehaviour
{

    public NavMeshAgent thingy1;
    // Start is called before the first frame update
    void Start()
    {
        thingy1 = GetComponent<NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            setDestinationtoMouse();
        }
    }

    void setDestinationtoMouse()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray,out hit))
        {
            thingy1.SetDestination(hit.point);
        }
    }
}
