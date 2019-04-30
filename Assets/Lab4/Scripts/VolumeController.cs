using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeController : MonoBehaviour
{
    // Reference of the music
    private AudioSource bgmusic;
    public Slider Volume;
    // Music volume variable. Modifiable with
    // the dragging slider
    private float musicVolume = 1f;
    // Start is called before the first frame update
    void Start()
    {
        //Asign this variable the Audio Source component
        bgmusic = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // The volume is modify by the scroller
        bgmusic.volume = Volume.value;
        if (Input.GetKeyDown(KeyCode.M))
            // Mutes the music
            bgmusic.mute = !bgmusic.mute;
    }
}

