using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class LogController : MonoBehaviour
{
    public GameObject wood;

    public bool IsReadyToChop { get; private set; }

    // Start is called before the first frame update
    void Start()
    {

    }

    public void IsToggleReadyToChop()
    {
        IsReadyToChop = !IsReadyToChop;
        Debug.Log("Chop? " + IsReadyToChop);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Log Collision");
        Debug.Log("Ready to chop? " + IsReadyToChop);
        if (collision.collider.name == Constants.BLADE)
        {
            Debug.Log("Log - Collision Collider name: " + collision.collider.name);
            if (IsReadyToChop)
            {
                Vector3 piecesPosition = gameObject.transform.position;
                Instantiate(wood, piecesPosition, Quaternion.identity);
                Instantiate(wood, piecesPosition + new Vector3(0.25f, 0, 0), Quaternion.identity);
                Debug.Log("Break into wood");
                Destroy(gameObject);
            }
        }
    }
}
