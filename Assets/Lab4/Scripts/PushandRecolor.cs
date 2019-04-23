using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushandRecolor : MonoBehaviour
{
    public Rigidbody rb;
    public float force = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // FixedUpdate is called ten times longer than Update
    void FixedUpdate()
    {
        
    }
    
    public void OnMouseDown()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            rb.AddForce(-hit.normal * force, ForceMode.Impulse);
        }
    }
    public void OnMouseOver()
    {
        GetComponent<MeshRenderer>().material.color = Color.green;
    }
    public void OnMouseExit()
    {
        GetComponent<MeshRenderer>().material.color = Color.white;
    }
}
