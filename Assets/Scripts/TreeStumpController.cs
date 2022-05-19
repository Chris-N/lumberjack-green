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

    public void OnSelectEnter(SelectEnterEventArgs args)
    {
        Debug.Log("Log ENTER");
        LogController logCtrlReal = args.interactableObject.transform.gameObject.GetComponent<LogController>();
        logCtrlReal.IsToggleReadyToChop();
    }
    public void OnSelectExit(SelectExitEventArgs args)
    {
        Debug.Log("Log EXIT");

        // TODO: Still toggles readyToChop after log destroyed
        LogController logCtrlReal = args.interactableObject.transform.gameObject.GetComponent<LogController>();
        logCtrlReal.IsToggleReadyToChop();
    }
}
