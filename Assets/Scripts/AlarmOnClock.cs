using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlarmOnClock : MonoBehaviour
{
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnMouseDown()   //событие когда на объект кликают мышкой или тап по экрану
    {
        _animator.SetTrigger("penguin_atack_01");
    }
}
