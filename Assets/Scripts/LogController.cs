using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class LogController : MonoBehaviour
{
    public GameObject wood;

    public bool IsReadyToChop { get; private set; }

    public void IsToggleReadyToChop()
    {
        IsReadyToChop = !IsReadyToChop;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == Constants.BLADE)
        {
            if (IsReadyToChop)
            {
                // Chopping sound
                Vector3 piecesPosition = gameObject.transform.position;
                Instantiate(wood, piecesPosition, Quaternion.identity);
                Instantiate(wood, piecesPosition + new Vector3(0.25f, 0, 0), Quaternion.identity);
                Destroy(gameObject);
            }
        }
    }
}
