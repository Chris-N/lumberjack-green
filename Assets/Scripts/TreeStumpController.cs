using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class TreeStumpController : MonoBehaviour
{
    XRSocketInteractor socket;

    // Start is called before the first frame update
    void Start()
    {
        socket = GetComponentInChildren<XRSocketInteractor>();
    }

    public void OnHoverEnter()
    {
        Debug.Log("Hover IN");
    }
    public void OnHoverExit()
    {
        Debug.Log("Hover OUT");
    }
}
