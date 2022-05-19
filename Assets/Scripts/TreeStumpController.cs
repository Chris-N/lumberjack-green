using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class TreeStumpController : MonoBehaviour
{
    public void OnSelectEnter(SelectEnterEventArgs args)
    {
        LogController logCtrlReal = args.interactableObject.transform.gameObject.GetComponent<LogController>();
        logCtrlReal.IsToggleReadyToChop();
    }
    public void OnSelectExit(SelectExitEventArgs args)
    {
        LogController logCtrlReal = args.interactableObject.transform.gameObject.GetComponent<LogController>();
        logCtrlReal.IsToggleReadyToChop();
    }
}
