using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class LocomotionManager : MonoBehaviour
{
    public GameObject leftRay;
    public GameObject leftTeleportRay;

    private ContinuousMoveProviderBase _ContinuousMove;

    void Start()
    {
        _ContinuousMove = GetComponent<ContinuousMoveProviderBase>();
    }

    public void SetTeleport(bool isSet)
    {
        if (isSet)
        {
            leftRay.SetActive(!isSet);
            leftTeleportRay.SetActive(isSet);
            DisableContinuous();
        }
    }
    public void SetContinuous(bool isSet)
    {
        if (isSet)
        {
            leftRay.SetActive(isSet);
            leftTeleportRay.SetActive(!isSet);
            EnableContinuous();
        }
    }

    private void EnableContinuous()
    {
        _ContinuousMove.enabled = true;
    }
    private void DisableContinuous()
    {
        _ContinuousMove.enabled = false;
    }
}
