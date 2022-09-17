using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class selector : MonoBehaviour
{
    public void Tutorial()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void l1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public void l2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }
    public void l3()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
    }
    public void l4()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);
    }
    public void l5()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 6);
    }
    public void l6()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 7);
    }
    public void freeroam()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 8);
    }

}
