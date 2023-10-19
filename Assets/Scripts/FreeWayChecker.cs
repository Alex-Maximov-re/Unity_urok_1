using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeWayChecker : MonoBehaviour
{
    [SerializeField] Rigidbody2D _rigidbody2D;
    [SerializeField] float _speed;
    [SerializeField] ContactFilter2D _filter;   // фильтр для столкноений по уровням
    private readonly RaycastHit2D[] _results = new RaycastHit2D[2]; //пустой масcив для записи всех хитов

    private void FixedUpdate()
    {
        var collisionCount = _rigidbody2D.Cast(transform.right,_filter, _results, 10);
        //Debug.Log(collisionCount);
        if (collisionCount == 0)
        {
            _rigidbody2D.velocity = transform.right * _speed;
        }
        else
        {
            _rigidbody2D.velocity = Vector2.zero;
        }
    }
}
