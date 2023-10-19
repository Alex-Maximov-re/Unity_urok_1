using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    private void Update()
    {
        //RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector3.up);//всегда стреяет вверх
        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.up);//стреляет из вверха в разных направлениях
        
        Debug.DrawRay(transform.position, transform.up * 10, Color.red); //рисует луч направления дула

        if (hit)
        {
            Destroy(hit.collider.gameObject);
        }
    }
}