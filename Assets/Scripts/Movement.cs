using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _speed;
    private void Update()
    {
        //Input.GetKeyDown();  клавишу только нажали, возращает булево
        //Input.GetKeyUp()   клавишу отпустили
        Input.GetKey(KeyCode.D);
        Input.GetKey(KeyCode.A);
        //Debug.Log(Input.GetKey(KeyCode.D));
        //Debug.Log(Input.GetKey(KeyCode.A));

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(_speed * Time.deltaTime, 0 ,0 );
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(_speed * Time.deltaTime * -1, 0 ,0 );
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, _speed * Time.deltaTime ,0 );
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, _speed * Time.deltaTime * -1 ,0 );
        }
    }
}
