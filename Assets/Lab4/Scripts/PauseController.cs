using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseController : MonoBehaviour
{
  
    //Corresponds to the booleans
    private bool isPaused = false;
    private AudioSource sound;
    // Start is called before the first frame update
    void Start()
    {
        sound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                sound.Play();
                ResumeGame();
            }
            else
            {
                sound.Play();
                PauseGame();
            }
            
        }
        
    }
    public void ResumeGame()
    {
        //Resumes the game
        isPaused = false;
        Time.timeScale = 1f;
        if (transform.Find("PauseMenu").gameObject != null)
        {
            transform.Find("PauseMenu").gameObject.SetActive(false);
        }
    }
    public void PauseGame()
    {   
        //Stop the time scale
        isPaused = true;
        Time.timeScale = 0f;
        if(transform.Find("PauseMenu").gameObject != null)
        {
            transform.Find("PauseMenu").gameObject.SetActive(true);
        }
        
    }   
    public void LoadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
