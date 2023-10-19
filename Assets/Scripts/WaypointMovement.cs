using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class WaypointMovement : MonoBehaviour
{
    [SerializeField] private Transform _path; //ссылку на корневой объект Трансформ

    private Transform[] _points; //массив с точками пути

    private int _currentPoint;
    [SerializeField] private float _speed;

    private void Start()
    {
        _points = new Transform[_path.childCount]; //массив для хранения точек

        for (int i = 0; i < _path.childCount; i++)
        {
            _points[i] = _path.GetChild(i);    
        }

        /*foreach (var child in _path)
        {
            
        }*/
    }

    private void Update()
    {
        Transform target = _points[_currentPoint];

        var direction =
            (target.position - transform.position)
            .normalized; //направление движения от одной точки до другой - вычесть из позиции цели текущую позицию
        //нормализуем этот вектор

        //transform.position += direction; //двигаемся

        transform.position = Vector3.MoveTowards(transform.position, target.position, _speed * Time.deltaTime);
        //предпочтиетльный вариант движения

        if (transform.position == target.position)
        {
            _currentPoint++;
            if (_currentPoint >= _points.Length)
            {
                _currentPoint = 0;
            }
        }
    }
}
