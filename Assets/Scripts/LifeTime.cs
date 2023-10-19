using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Awake");
    }

    private void OnEnable()
    {
        Debug.Log("OnEnable");
    }

    private void OnDisable()
    {
        Debug.Log("OnDisable");
    }

    private void Start()
    {
        Debug.Log("Start - " + gameObject.name);
        Debug.Log("[" + Time.time + "]Start - " + gameObject.name);
    }

    private void Update()
    {
        //Debug.Log("Update - " + gameObject.name);
        //Debug.Log("[" + Time.time + "]Update - " + gameObject.name);
    }
}