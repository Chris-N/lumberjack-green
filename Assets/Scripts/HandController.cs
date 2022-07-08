using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

[RequireComponent(typeof(ActionBasedController))]
public class HandController : MonoBehaviour
{
    public Hand hand;

    ActionBasedController _controller;

    // Start is called before the first frame update
    void Start()
    {
        _controller = GetComponent<ActionBasedController>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Grip button: " + _controller.selectAction.action.ReadValue<float>());
        hand.SetGrip(_controller.selectAction.action.ReadValue<float>());
        hand.SetTrigger(_controller.activateAction.action.ReadValue<float>());
    }
}
