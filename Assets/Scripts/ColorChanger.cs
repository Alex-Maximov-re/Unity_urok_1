using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public SpriteRenderer Target; // прячем поле из инспектора    
    [SerializeField] private float _duration; // есть в инспекторе хоть и прайвет

    private Color _startColor; // текущий цвет
    [SerializeField] private Color _targetColor;

    private float _runningtime;

    void Start()
    {
        Target = GetComponent<SpriteRenderer>(); //вызываем компонент и помещает ссыдку на него в поле
        // нужно чтобы в поле автоматически присваивался компонент данного объекта, а не в ручную
        _startColor = Target.color;
    }


    void Update()
    {
        //Debug.Log(Time.deltaTime);
        _runningtime += Time.deltaTime; // накапливаем фреймрейты
        float normalizeRunningTime = _runningtime / _duration;

        if (_runningtime <= _duration)
        {
            Debug.Log(_runningtime);
            Color newColor =
                new Color(_targetColor.r, _targetColor.b, _targetColor.b); // из чего состоит необходиый цвет
            Color newColor2 = new Color(_targetColor.r * normalizeRunningTime, _targetColor.b * normalizeRunningTime,
                _targetColor.b * normalizeRunningTime);
            //меняем необходимый цвет по отношению к прошедшему времени

            //Target.color = newColor2; // меняет черный цвет на нужный
            Target.color = Color.Lerp(_startColor, _targetColor, normalizeRunningTime); // меняет текущий цвет на нужный
        }

        if (_runningtime > _duration)
        {
            Target.color = Color.Lerp(_targetColor,_startColor, normalizeRunningTime - 1);
        }
        
        if (Target.color == _startColor)
        {
            _runningtime = 0;
        }
        
        //Debug.Log(normalizeRunningTime);
    }
}