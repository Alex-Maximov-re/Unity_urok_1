using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Block : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private float _jumpForce;
    
    public void OnPointerClick(PointerEventData eventData)   //метод вызывается когда кликают на наш объект
    {
        Debug.Log(gameObject.name);
        //_rigidbody2D.AddForce(Vector2.up, ForceMode2D.Force);   //варианты подпрыгивания
        //_rigidbody2D.AddForce(Vector2.up, ForceMode2D.Impulse);
        _rigidbody2D.AddForce(Vector2.up * _jumpForce);
    }
}