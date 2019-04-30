using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneManager : MonoBehaviour
{
    private static bool booelean = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (booelean != false)
            {
                SceneManager.LoadScene(1);
                booelean = false;
            }
            else
            {
                SceneManager.LoadScene(0);
                booelean = true;
            }

        }
    }
}