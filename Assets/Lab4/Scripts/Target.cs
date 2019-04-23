using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    //Stata for the targets
    private float health =  30f;
    
    public void takeDamage(float amount)
    {   
        //Substracts the health of the target by a x amount of damage
        health -= amount;
        //If health is 0 or less, the target is destoyed
        if(health <= 0f)
        {
            Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
