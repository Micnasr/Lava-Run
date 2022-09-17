using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grappleblock : MonoBehaviour
{

    public Transform player;
    public Material green;
    public Material red;

    public float distance = 40f;

    void Start()
    {
        
    }

    
    void Update()
    {
        float distanceFromPoint = Vector3.Distance(player.position, transform.position);

        if (distanceFromPoint > distance)
        {
            gameObject.GetComponent<Renderer>().material = red;
        } else
        {
            gameObject.GetComponent<Renderer>().material = green;
        }
    }
}
