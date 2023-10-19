using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Fader : MonoBehaviour
{
    [SerializeField] private Image _image;

    /*public void FadeIn()
    {
        var color = _image.color;

        for (int i = 0; i < 255; i++)
        {
            color.a = 1 - (1 / 255 * i);
            _image.color = color;
        }
    }*/

    private void Start()
    {
        var fadeInJob = StartCoroutine(FadeIn(1));  //запустить корутину
        
        //StopCoroutine(fadeInJob);  //остановить корутину
        
        //StopAllCoroutines();   //остановить все корутины на этом бихейворе
    }

    private IEnumerator FadeIn(float duration)
    {
        var color = _image.color;

        for (int i = 0; i < 255; i++)
        {
            color.a = 1f - (1f / 255f * i);
            _image.color = color;

            yield return null;  //после каждой итерации мы возращаемся из этой функции, ждем кадр и возвращаемся в эту же точку в след раз
            //yield return new WaitForSeconds(1f);   //продолжим работать чере з1 секунду
            //yield return new WaitForSecondsRealtime(1f);   //1 секунда без учета таймскейла, в режиме реального времени (без привязки к времени в игре)
            //yield return new WaitUntil();          ждет до определенного момента
            //yield return new WaitWhile();   ждет пока что то не случится
        }
    }
}
