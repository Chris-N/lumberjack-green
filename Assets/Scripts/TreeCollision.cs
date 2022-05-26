using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeCollision : MonoBehaviour
{
    public GameObject treeStump;
    public GameObject log;

    [SerializeField] int health = 3;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == Constants.BLADE)
        {
            // Chopping sound
            health--;
            Debug.Log("Health? " + health);
            if (health == 0)
            {
                Debug.Log("CHOP");
                Instantiate(treeStump, gameObject.transform.position, Quaternion.identity);

                Vector3 logOffset = new Vector3(0, 0.92f, 0);
                Instantiate(log, gameObject.transform.position + logOffset, Quaternion.identity);
                Destroy(gameObject);
            }
        }
    }
}
