using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogController : MonoBehaviour
{
    bool isReadyToChop;
    public GameObject wood;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Log Collision");
        //if (collision.gameObject.CompareTag("Axe"))
        if (collision.collider.name == "Blade")
        {
            Debug.Log("Log - Collision Collider name: " + collision.collider.name);
            Debug.Log("Break into wood");
        }
    }
}
