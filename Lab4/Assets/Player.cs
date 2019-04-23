using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private float contador;
    public GameObject text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<AudioSource>().Play();
            if (Physics.Raycast(myRay, out hitInfo))
            {
                if (hitInfo.collider.gameObject.CompareTag("Enemy"))
                {
                    contador++;
                    Destroy(hitInfo.collider.gameObject);
                    text.GetComponent<Text>().text = contador.ToString();
                }
            }
        }
    }

    
}
