using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public PlayerMove player;

    // Update is called once per frame
    void Update()
    {
        //Получение длины полосы
        float healthPercent = (player.currHealth / player.maxHealth) * 100;
        float healthLevel = healthPercent / 10;

        transform.localScale = new Vector3(healthLevel, 1f, 1f); //Изменение масштаба
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 4f, transform.position.z); //Изменение позиции

    }
}
