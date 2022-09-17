using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lava : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        //riseUp
        gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 1f * Time.deltaTime, gameObject.transform.position.z);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        

    }
}
