using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSMain : MonoBehaviour
{   
    //Properties of the gun
    private static float range = 75f;
    private static float damage = 10f;
    private AudioSource gunsound;
    //Uses a camera as an origin coordinates of X,Y and Z  for the Raycaster
    public Camera fpsCam;
    private void Start()
    {
        gunsound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //Whever the left-right click of the mouse is pressed, it does the shoot function.
        if (Input.GetButtonDown("Fire1"))
        {
            gunsound.Play();
            shoot();
        }
    }

    public void shoot()
    {
        //Create a raycast hit 
        RaycastHit hit;
        // Uses the initial position of the MainCamera, takes whatever is in front of him, grabs the value in hit and only does it withing 75f meters
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range)){
            //Just displays which object is hitting
            Debug.Log(hit.transform.name);
            //Founds an object with the target denomination and saves the value in target
            Target target = hit.transform.GetComponent<Target>();
            //So, when the target is found, it takes 10f of damage to the target
            if (target != null)
            {
                target.takeDamage(damage);
            }
        }
    }
}
