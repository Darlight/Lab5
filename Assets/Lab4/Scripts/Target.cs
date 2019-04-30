using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    //Stata for the targets
    private float health =  30f;
    private AudioSource deathsound;
    private void Start()
    {
        deathsound = GetComponent<AudioSource>();
    }
    public void takeDamage(float amount)
    {   
        //Substracts the health of the target by a x amount of damage
        health -= amount;
        //If health is 0 or less, the target is destroyed
        if(health <= 0f)
        {
            //Plays the sounds. After 2.5 seconds, the object is destroyed.
            deathsound.Play();
            Destroy(this.gameObject,2.5f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
