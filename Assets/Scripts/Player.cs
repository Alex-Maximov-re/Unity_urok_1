using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class Player : MonoBehaviour
{
    [SerializeField] private UnityEvent _hit;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.collider.gameObject.name);   //проверка на работу метода
        if (collision.collider.TryGetComponent(out Block block))
        {
            _hit?.Invoke();     //инициализируем событие
        }
    }
}
