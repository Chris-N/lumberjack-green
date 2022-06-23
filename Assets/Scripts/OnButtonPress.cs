using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

/// <summary>
/// Checks for button input on an input action from every device
/// </summary>
public class OnButtonPress : MonoBehaviour
{
    [Tooltip("Actions to check")]
    //public InputAction action = null;
    public InputActionReference actionRef = null;

    public UnityEvent OnPress = new UnityEvent();
    public UnityEvent OnRelease = new UnityEvent();

    private void Awake()
    {
        //action.started += Pressed;
        //action.canceled += Released;

        actionRef.action.started += Pressed;
        actionRef.action.canceled += Released;
    }

    private void OnDestroy()
    {
        //action.started -= Pressed;
        //action.canceled -= Released;

        actionRef.action.started += Pressed;
        actionRef.action.canceled += Released;
    }

    private void OnEnable()
    {
        //action.Enable();
        actionRef.action.Enable();
    }

    private void OnDisable()
    {
        //action.Disable();
        actionRef.action.Disable();
    }

    private void Pressed(InputAction.CallbackContext context)
    {
        OnPress.Invoke();
    }

    private void Released(InputAction.CallbackContext context)
    {
        OnRelease.Invoke();
    }
}
