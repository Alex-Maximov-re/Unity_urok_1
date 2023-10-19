using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EndPoint : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _renderer;
    [SerializeField] private Color _reachedColor;
    [SerializeField] private UnityEvent _reached = new UnityEvent();
    private bool _isReached;
    
    public event UnityAction Reached
    {
        add => _reached.AddListener(value);
        remove => _reached.RemoveListener(value);
    }

    public bool IsReached2
    {
        get => _isReached;
        private set => _isReached = value;
    }
    
    public bool IsReached { get; private set; }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (IsReached)
        {
            return;
        }
        
        if (collision.TryGetComponent<Player>(out Player player))
        {
            IsReached = true;
            //_renderer.color = _reachedColor;
            _reached.Invoke(); //вызов события  ?проверяет что объект не нулл
        }
    }
}
