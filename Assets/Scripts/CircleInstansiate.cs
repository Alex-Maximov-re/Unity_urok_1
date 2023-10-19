using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleInstansiate : MonoBehaviour
{
    public GameObject Template;
    public int Count;
    public float Radius;
    public float Radius2;

    private void Start()
    {
        //создание объекта из префаба на старте
        GameObject newObject = Instantiate(Template, Vector3.zero, Quaternion.identity); //ссылка на игровой объект, без модификаций
        newObject.GetComponent<SpriteRenderer>().color = Color.blue; //меняем цвет новому объекту

        int angleStep = 360 / Count;

        for (int i = 0; i < Count; i++)
        {
            GameObject newObject2 = Instantiate(Template, new Vector3(0, 1, 0), Quaternion.identity);
            newObject2.GetComponent<SpriteRenderer>().color = Color.red;
            Transform newObjectTransform = newObject2.GetComponent<Transform>();
            newObjectTransform.position = new Vector3(Radius * Mathf.Cos(angleStep * (i + 1)), Radius * Mathf.Sin(angleStep * (i + 1)), 0);
            
            GameObject newObject3 = Instantiate(Template, new Vector3(0, 1, 0), Quaternion.identity);
            newObject2.GetComponent<SpriteRenderer>().color = Color.magenta;
            Transform newObjectTransform2 = newObject3.GetComponent<Transform>();
            newObjectTransform2.position = new Vector3(Radius2 * Mathf.Cos(angleStep * (i + 1) * Mathf.Deg2Rad), Radius2 * Mathf.Sin(angleStep * (i + 1) * Mathf.Deg2Rad), 0);
            // два вариант построения объектов по кругу. второй лучше.
        }
    }

}
