using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Animator))]
public class Hand : MonoBehaviour
{
    [SerializeField] float speed;

    Animator _animator;
    float _gripCurrent;
    float _triggerCurrent;
    float _triggerTarget;
    float _gripTarget;

    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
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
            _gripCurrent = Mathf.MoveTowards(_gripCurrent, _gripTarget, Time.deltaTime * speed);
            _animator.SetFloat("Grip", _gripCurrent);
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
}
