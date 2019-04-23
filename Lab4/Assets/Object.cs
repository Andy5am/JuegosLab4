using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{

    public int force;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnMouseOver()
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
    }
    private void OnMouseExit()
    {
        GetComponent<MeshRenderer>().material.color = Color.white;
    }

    private void OnMouseDown()
    {
        Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;

        if (Physics.Raycast(myRay, out hitInfo))
            rb.AddForce(-hitInfo.normal * force, ForceMode.Impulse);
    }
}
