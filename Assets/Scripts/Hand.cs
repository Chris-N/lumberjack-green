using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Animator))]
public class Hand : MonoBehaviour
{
    [SerializeField] float _speed;

    Animator _animator;
    SkinnedMeshRenderer _mesh;

    float _gripCurrent;
    float _triggerCurrent;
    float _triggerTarget;
    float _gripTarget;

    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
        _mesh = GetComponentInChildren<SkinnedMeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        AnimateHand();
    }

    private void AnimateHand()
    {
        if(_gripCurrent != _gripTarget)
        {
            _gripCurrent = Mathf.MoveTowards(_gripCurrent, _gripTarget, Time.deltaTime * _speed);
            _animator.SetFloat("Grip", _gripCurrent);
        }
        if(_triggerCurrent != _triggerTarget)
        {
            _triggerCurrent = Mathf.MoveTowards(_triggerCurrent, _triggerTarget, Time.deltaTime * _speed);
            _animator.SetFloat("Trigger", _triggerCurrent);
        }
    }

    internal void SetGrip(float gripTarget)
    {
        _gripTarget = gripTarget;
    }

    internal void SetTrigger(float triggerTarget)
    {
        _triggerTarget = triggerTarget;
    }

    public void ToggleVisiblity()
    {
        _mesh.enabled = !_mesh.enabled;
    }
}
