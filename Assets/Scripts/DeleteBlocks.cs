using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteBlocks : MonoBehaviour
{
    
    private void Start()
    {
        var camera = GameObject.FindObjectOfType<Camera>(); //найти объект с компонентом Camera
        GameObject block1 = GameObject.Find("Block1");  // поиск по имени объекта
        Destroy(block1);  //Удалить объект из проекта

        GameObject[] blocks = GameObject.FindGameObjectsWithTag("BlockToDelete"); //возвращает массив объектов с тегом

        for (int i = 0; i < blocks.Length; i++)  //уничтожаем объекты с тегом
        {
            GameObject block = blocks[i];
            Destroy(block);
        }

        for (int i = 0; i < blocks.Length; i++)  //меняем цвет объектов с тегом
        {
            GameObject block = blocks[i];
            block.GetComponent<SpriteRenderer>().color = Color.red;
        }
    }

    
    
}
