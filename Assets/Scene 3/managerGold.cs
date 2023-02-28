using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class managerGold : MonoBehaviour
{
    public Transform spawn_pos;
    public Text clickstotalText;
    public GameObject worker1;
    public GameObject worker2;
    public GameObject worker3;




    float totalclicks;
    
    public void Addclicks()
    {
        totalclicks++;
        clickstotalText.text = totalclicks.ToString("0"); 
    }

    public void InstantiateCaller1()
    {
        Instantiate(worker1, transform);
    }

    public void InstantiateCaller2()
    {
        Instantiate(worker2, transform);
    }

    public void InstantiateCaller3()
    {
        Instantiate(worker3, transform);
    }


}
