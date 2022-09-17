using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialScript : MonoBehaviour
{
    public Transform player;
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public GameObject text4;


    public float distance = 30f;

    void Update()
    {
        //text1
        float distanceFromPoint1 = Vector3.Distance(player.position, text1.transform.position);

        if (distanceFromPoint1 > distance)
        {
            text1.SetActive(false);
        }
        else if (distanceFromPoint1 < distance)
        {
            
            text1.SetActive(true);
        }

        //text2
        float distanceFromPoint2 = Vector3.Distance(player.position, text2.transform.position);

        if (distanceFromPoint2 > distance)
        {
            text2.SetActive(false);
        }
        else if (distanceFromPoint2 < distance)
        {

            text2.SetActive(true);
        }

        //text3
        float distanceFromPoint3 = Vector3.Distance(player.position, text3.transform.position);

        if (distanceFromPoint3 > distance)
        {
            text3.SetActive(false);
        }
        else if (distanceFromPoint2 < distance)
        {

            text3.SetActive(true);
        }

        //text4
        float distanceFromPoint4 = Vector3.Distance(player.position, text4.transform.position);

        if (distanceFromPoint4 > distance)
        {
            text4.SetActive(false);
        }
        else if (distanceFromPoint4 < distance)
        {

            text4.SetActive(true);
        }

    }
}
