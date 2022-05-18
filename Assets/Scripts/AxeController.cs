using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Axe Collision");
        if (collision.gameObject.CompareTag("Log"))
        {
            Debug.Log("Break into wood");
            Debug.Log("Axe - Collision Collider name: " + collision.collider.name);
        }
    }
}
