using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeCollision : MonoBehaviour
{
    public GameObject treeStump;
    public GameObject log;

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
        if (collision.collider.name == Constants.BLADE)
        {
            Instantiate(treeStump, gameObject.transform.position, Quaternion.identity);

            Vector3 logOffset = new Vector3(0, 0.92f, 0);
            Instantiate(log, gameObject.transform.position + logOffset, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
