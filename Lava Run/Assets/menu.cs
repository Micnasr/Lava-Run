using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{

    public GameObject selector;

    private void Start()
    {
        selector.SetActive(false);
    }

    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Levels()
    {
        selector.SetActive(true);
    }
}
