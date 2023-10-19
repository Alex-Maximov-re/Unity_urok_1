using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFinishTrigger : MonoBehaviour
{
    private EndPoint[] _points;  //вручную добавить все события в поле

    private void OnEnable()
    {
        //_points = GameObject.FindObjectOfType<EndPoint>();
        _points = gameObject.GetComponentInChildren<EndPoint[]>();

        foreach (var point in _points)
        {
            point.Reached += OnEndPointReached; //добавляем событие
        }
    }

    private void OnDisable()
    {
        foreach (var point in _points)
        {
            point.Reached -= OnEndPointReached;  //отписываемся от события
        }   
    }

    private void OnEndPointReached()
    {
        foreach (var point in _points)
        {
            if (point.IsReached == false)
            {
                return;    
            }
        }
        Debug.Log("Finish!");
    }
}
